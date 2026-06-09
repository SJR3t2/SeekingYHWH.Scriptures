using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SeekingYHWH.Scriptures;

/// <summary>
/// Interaction logic for DownloadWindow.xaml
/// </summary>
public partial class DownloadWindow : Window
{
	private LanguageInfo language;
	private string languagePath;
	private string booksBRPath;
	private string booksHSHPath;
	private readonly List<DownloadBookModel> books = new List<DownloadBookModel>();

	public DownloadWindow()
	{
		InitializeComponent();
	}

	public override void EndInit()
	{
		base.EndInit();

		if (Languages.Masters.Count <= 0)
		{
			Languages.Download();
		}
		languagesCombo.ItemsSource = Languages.Masters;
		if (Languages.Locals.Count == 1 &&
			Languages.MastersTryIndexOf(Languages.Locals[0], out var offset))
		{
			languagesCombo.SelectedIndex = offset;
		}
	}

	private void OnLanguagesDownload(object sender, RoutedEventArgs args)
	{
		Languages.Download();
	}

	private void OnLanguagesChanged(object sender, SelectionChangedEventArgs args)
	{
		var offset = languagesCombo.SelectedIndex;
		var languages = Languages.Masters;
		if (offset < 0 || offset >= languages.Count)
		{
			return;
		}
		language = languages[offset];
		languagePath = BookInfosPaths.GetFolder(Stores.Path, language);
		booksBRPath = BookInfosPaths.GetBrPath(languagePath);
		booksHSHPath = BookInfosPaths.GetHashPath(languagePath);

		if (File.Exists(booksHSHPath))
		{
			BooksRead();
		}
		else
		{
			OnBooksDownload(null, null);
		}
	}

	private async void OnBooksDownload(object sender, EventArgs args)
	{
		var client = new HttpClient();

		var booksHSHURL = URLs.GetBooksHSH(language);
		var hash = await client.GetByteArrayAsync(booksHSHURL);

		if (File.Exists(booksHSHPath))
		{
			var old = File.ReadAllBytes(booksHSHPath);
			if (HashConverter.Equals(hash, old))
			{
				return;
			}
		}

		Directory.CreateDirectory(languagePath);

		var booksBRURL = URLs.GetBooksBR(language);
		using (var response = await client.GetAsync(booksBRURL))
		{
			if (!response.IsSuccessStatusCode)
			{
				return;
			}

			using (var writer = new FileStream(booksBRPath, FileMode.Create, FileAccess.Write, FileShare.Read))
			{
				response.Content.CopyTo(writer, null, CancellationToken.None);
			}
		}

		File.WriteAllBytes(booksHSHPath, hash);

		var removes = books.ToArray();

		BooksRead();

		var set = new HashSet<string>();
		var downloadeds = 0;
		foreach (var value in books)
		{
			set.Add(value.Code);
			if (value.Downloaded)
			{
				++downloadeds;
			}
		}
		if (downloadeds > 0)
		{
			foreach (var value in removes)
			{
				var book = value.Book;

				if (set.Contains(book.Code))
				{
					continue;
				}

				Options.Remove(language, book);
				File.Delete(System.IO.Path.Combine(languagePath, value.Code + ".tsv.hsh"));
				File.Delete(System.IO.Path.Combine(languagePath, value.Code + ".tsv.br"));
			}
		}
		else
		{
			Languages.LocalsRemove(language);
			Options.Remove(language);
		}
	}

	private void OnBooksRemove(object sender, EventArgs args)
	{
		booksList.ItemsSource = null;
		booksRemove.IsEnabled = false;

		Languages.LocalsRemove(language);
		Options.Remove(language);

		Directory.Delete(languagePath, recursive: true);
	}

	private void BooksRead()
	{
		booksList.ItemsSource = null;

		books.Clear();
		using (var reader = BookInfosReader.OpenBr(booksBRPath))
		{
			while (reader.TryRead(out var value))
			{
				var bookBRName = value.Code + ".tsv.br";
				var bookBRPath = System.IO.Path.Combine(languagePath, bookBRName);
				var downloaded = File.Exists(bookBRPath);
				var model = new DownloadBookModel(value, downloaded);
				books.Add(model);
			}
		}

		booksList.ItemsSource = books;
		booksRemove.IsEnabled = true;
	}

	private async void OnDownloadBook(object sender, RoutedEventArgs args)
	{
		if (sender is not Button button)
		{
			return;
		}
		if (button.DataContext is not DownloadBookModel model)
		{
			return;
		}

		var client = new HttpClient();

		var bookHSHName = model.Code + ".tsv.hsh";
		var bookHSHURL = URLs.GetBook(language, bookHSHName);
		var hash = await client.GetByteArrayAsync(bookHSHURL);
		var bookHSHPath = System.IO.Path.Combine(languagePath, bookHSHName);
		if (File.Exists(bookHSHPath))
		{
			var old = File.ReadAllBytes(bookHSHPath);
			if (HashConverter.Equals(hash, old))
			{
				return;
			}
		}

		var bookBRName = model.Code + ".tsv.br";
		var bookBRURL = URLs.GetBook(language, bookBRName);
		var bookBRPath = System.IO.Path.Combine(languagePath, bookBRName);
		using (var response = await client.GetAsync(bookBRURL))
		{
			if (!response.IsSuccessStatusCode)
			{
				return;
			}

			using (var writer = new FileStream(bookBRPath, FileMode.Create, FileAccess.Write, FileShare.Read))
			{
				response.Content.CopyTo(writer, null, CancellationToken.None);
			}
		}

		File.WriteAllBytes(bookHSHPath, hash);

		var found = false;
		foreach (var value in books)
		{
			if (value.Downloaded)
			{
				found = true;
				break;
			}
		}
		if (!found)
		{
			Languages.LocalsAdd(language);
		}

		var code = model.Code;
		var offset = 0;
		foreach (var value in books)
		{
			if (code == value.Code)
			{
				break;
			}
			if (value.Downloaded)
			{
				++offset;
			}
		}
		Options.Add(language, model.Book, offset);

		model.OnDownloaded();
	}

	private void OnRemoveBook(object sender, RoutedEventArgs args)
	{
		if (sender is not Button button)
		{
			return;
		}
		if (button.DataContext is not DownloadBookModel model)
		{
			return;
		}

		model.OnRemoved();

		Options.Remove(language, model.Book);

		var keep = false;
		foreach (var value in books)
		{
			if (value.Downloaded)
			{
				keep = true;
				break;
			}
		}
		if (!keep)
		{
			Languages.LocalsRemove(language);
		}

		var bookHSHName = model.Code + ".tsv.hsh";
		var bookHSHPath = System.IO.Path.Combine(languagePath, bookHSHName);
		File.Delete(bookHSHPath);

		var bookBRName = model.Code + ".tsv.br";
		var bookBRPath = System.IO.Path.Combine(languagePath, bookBRName);
		File.Delete(bookBRPath);
	}

	protected override void OnClosed(EventArgs args)
	{
		base.OnClosed(args);

		Options.Save();
	}
}

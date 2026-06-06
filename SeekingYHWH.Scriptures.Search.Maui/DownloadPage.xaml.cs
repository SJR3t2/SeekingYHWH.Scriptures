namespace SeekingYHWH.Scriptures;

public partial class DownloadPage : ContentPage
{
	private LanguageInfo language;
	private string languagePath;
	private string booksBRPath;
	private string booksHSHPath;
	private readonly List<DownloadBookModel> books = new List<DownloadBookModel>();

	public DownloadPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		if (Languages.Masters.Count <= 0)
		{
			Languages.Download();
		}
		languagesPicker.ItemsSource = Languages.Masters;
		if (Languages.Locals.Count == 1 &&
			Languages.MastersTryIndexOf(Languages.Locals[0], out var offset))
		{
			languagesPicker.SelectedIndex = offset;
		}
	}

	private async void LanguagesDownload(object sender, EventArgs args)
	{
		Languages.Download();
	}

	private void LanguagesChanged(object sender, EventArgs args)
	{
		var offset = languagesPicker.SelectedIndex;
		var languages = Languages.Masters;
		if (offset < 0 || offset >= languages.Count)
		{
			return;
		}
		language = languages[offset];
		languagePath = BookInfosPaths.GetFolder(Stores.Path, language);
		booksBRPath = BookInfosPaths.GetBrPath(languagePath);
		booksHSHPath = BookInfosPaths.GetHashPath(languagePath);
		booksRefresh.IsEnabled = true;

		if (File.Exists(booksHSHPath))
		{
			BooksRead();
		}
		else
		{
			BooksDownload(null, null);
		}
	}

	private async void BooksDownload(object sender, EventArgs args)
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
				File.Delete(Path.Combine(languagePath, value.Code + ".tsv.hsh"));
				File.Delete(Path.Combine(languagePath, value.Code + ".tsv.br"));
			}
		}
		else
		{
			Languages.LocalsRemove(language);
			Options.Remove(language);
		}
	}

	private void BooksRemove(object sender, EventArgs args)
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
				var bookBRPath = Path.Combine(languagePath, bookBRName);
				var downloaded = File.Exists(bookBRPath);
				var model = new DownloadBookModel(value, downloaded);
				books.Add(model);
			}
		}

		booksList.ItemsSource = books;
		booksRemove.IsEnabled = true;
	}

	private async void BookDownload(object sender, EventArgs args)
	{
		if (sender is not Button button)
		{
			return;
		}
		if (button.BindingContext is not DownloadBookModel model)
		{
			return;
		}

		var client = new HttpClient();

		var bookHSHName = model.Code + ".tsv.hsh";
		var bookHSHURL = URLs.GetBook(language, bookHSHName);
		var hash = await client.GetByteArrayAsync(bookHSHURL);
		var bookHSHPath = Path.Combine(languagePath, bookHSHName);
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
		var bookBRPath = Path.Combine(languagePath, bookBRName);
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

	private void BookRemove(object sender, EventArgs args)
	{
		if (sender is not Button button)
		{
			return;
		}
		if (button.BindingContext is not DownloadBookModel model)
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
		var bookHSHPath = Path.Combine(languagePath, bookHSHName);
		File.Delete(bookHSHPath);

		var bookBRName = model.Code + ".tsv.br";
		var bookBRPath = Path.Combine(languagePath, bookBRName);
		File.Delete(bookBRPath);
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();

		Options.Save();
	}
}
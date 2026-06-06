using System.Collections.ObjectModel;

using Innovoft.IO;

namespace SeekingYHWH.Scriptures;

public static class Options
{
	private const byte readSeparator = BytesSplitReader.Tab;
	private const char writeSeparator = '\t';
	public const string PortionSentence = "S";
	private const byte portionSentenceByte = 0x53;
	public const string PortionVerse = "V";
	private const byte portionVerseByte = 0x56;
	public const string PortionChapter = "C";
	private const byte portionChapterByte = 0x43;

	private static string optionsPath;

	private static string languageCode;
	private static string languagePath;
	private static string portion;
	private static readonly ObservableCollection<OptionsBookModel> books = new ObservableCollection<OptionsBookModel>();

	private static bool changed = false;

	private static Searcher searcher = new Searcher();

	public static string LanguageCode => languageCode;
	public static string LanguagePath => languagePath;
	public static string Portion => portion;
	public static ObservableCollection<OptionsBookModel> Books => books;

	public static void Prepare(string path)
	{
		optionsPath = Path.Combine(path, "Options.tsv");

		searcher.SearchByVerse();

		if (!File.Exists(optionsPath))
		{
			return;
		}

		Read();
	}

	public static void Save()
	{
		var changed = Options.changed;
		if (changed)
		{
			Options.changed = false;
			foreach (var book in books)
			{
				book.ResetChanged();
			}
		}
		else
		{
			foreach (var book in books)
			{
				if (!book.Changed)
				{
					continue;
				}
				changed = true;
				book.ResetChanged();
			}
			if (!changed)
			{
				return;
			}
		}

		Write();
	}

	public static bool IsSelected()
	{
		if (languageCode is null)
		{
			return false;
		}
		foreach (var book in books)
		{
			if (book.Include)
			{
				return true;
			}
		}
		return false;
	}

	public static void PortionSetSentence()
	{
		if (portion == PortionSentence)
		{
			return;
		}

		portion = PortionSentence;
		searcher.SearchBySentence();
		changed = true;
	}

	public static void PortionSetVerse()
	{
		if (portion == PortionVerse)
		{
			return;
		}

		portion = PortionVerse;
		searcher.SearchByVerse();
		changed = true;
	}

	public static void PortionSetChapter()
	{
		if (portion == PortionChapter)
		{
			return;
		}

		portion = PortionChapter;
		searcher.SearchByChapter();
		changed = true;
	}

	public static List<string> Search(QueryProvider provider)
	{
		var values = new List<BookInfo>();
		foreach (var value in books)
		{
			if (value.Include)
			{
				values.Add(value.Book);
			}
		}
		return searcher.Search(languagePath, values, provider);
	}

	public static void Change(LanguageInfo language)
	{
		if (language.Code == languageCode)
		{
			return;
		}

		languageCode = language.Code;
		languagePath = BookInfosPaths.GetFolder(Stores.Path, language);
		changed = true;

		var prevs = new Dictionary<string, OptionsBookModel>();
		foreach (var model in books)
		{
			prevs.Add(model.Code, model);
		}

		books.Clear();
		var booksBRPath = BookInfosPaths.GetBrPath(languagePath);
		using (var reader = BookInfosReader.OpenBr(booksBRPath))
		{
			while (reader.TryRead(out var value))
			{
				var bookBRName = value.Code + ".tsv.br";
				var bookBRPath = Path.Combine(languagePath, bookBRName);
				if (!File.Exists(bookBRPath))
				{
					continue;
				}
				var model = new OptionsBookModel(value);
				if (prevs.TryGetValue(value.Code, out var prev))
				{
					model.Include = prev.Include;
					model.PreUse = prev.PreUse;
				}
				books.Add(model);
			}
		}
	}

	public static void Add(LanguageInfo language, BookInfo book, int offset)
	{
		if (languageCode is null)
		{
			return;
		}
		if (language.Code != languageCode)
		{
			return;
		}

		var bookCode = book.Code;
		foreach (var value in books)
		{
			if (bookCode == value.Code)
			{
				return;
			}
		}

		var model = new OptionsBookModel(book);
		books.Insert(offset, model);
		changed = true;
	}

	public static void Remove(LanguageInfo language)
	{
		if (languageCode is null)
		{
			return;
		}
		if (language.Code != languageCode)
		{
			return;
		}

		languageCode = null;
		books.Clear();
		changed = true;
	}

	public static void Remove(LanguageInfo language, BookInfo book)
	{
		if (languageCode is null)
		{
			return;
		}
		if (language.Code != languageCode)
		{
			return;
		}

		var bookCode = book.Code;
		for (var i = books.Count - 1; i >= 0; --i)
		{
			var value = books[i];
			if (bookCode != value.Code)
			{
				continue;
			}
			books.RemoveAt(i);
			changed = true;
			return;
		}
	}

	private static void Read()
	{
		books.Clear();

		FileStream? readerStream = null;
		BytesSplitReader? reader = null;
		var x = new BytesColumn();
		try
		{
			readerStream = new FileStream(optionsPath, FileMode.Open, FileAccess.Read, FileShare.Read);
			reader = new BytesSplitReader(readerStream);

			var column = new BytesColumn[1] { x, };

			//Language
			x.Clear();
			if (!reader.ReadColumnsEnding(readSeparator, column) ||
				x.Count <= 0)
			{
				languageCode = null;
				portion = PortionVerse;
				searcher.SearchByVerse();
				return;
			}
			languageCode = x.ToString();
			if (!Languages.LocalsContains(languageCode))
			{
				languageCode = null;
				portion = PortionVerse;
				searcher.SearchByVerse();
				return;
			}
			languagePath = Path.Combine(Stores.Path, languageCode);

			//Portion
			x.Clear();
			if (!reader.ReadColumnsEnding(readSeparator, column) ||
				x.Count != 1)
			{
				portion = PortionVerse;
				searcher.SearchByVerse();
			}
			else
			{
				switch (x[0])
				{
				case portionSentenceByte:
					portion = PortionSentence;
					searcher.SearchBySentence();
					break;

				default:
				case portionVerseByte:
					portion = PortionVerse;
					searcher.SearchByVerse();
					break;

				case portionChapterByte:
					portion = PortionChapter;
					searcher.SearchByChapter();
					break;
				}
			}

			//Books
			ReadBooks(reader, x);
		}
		catch
		{
		}
		finally
		{
			reader?.Dispose();
			readerStream?.Dispose();
		}

		if (changed)
		{
			changed = false;
			Write();
		}
	}

	private static void ReadBooks(BytesSplitReader reader, BytesColumn x)
	{
		var booksBRPath = BookInfosPaths.GetBrPath(languagePath);
		if (!File.Exists(booksBRPath))
		{
			return;
		}
		var models = new Dictionary<string, OptionsBookModel>();
		BookInfosReader? booksReader = null;
		try
		{
			booksReader = BookInfosReader.OpenBr(booksBRPath);
			while (booksReader.TryRead(out var value))
			{
				var bookBRName = value.Code + ".tsv.br";
				var bookBRPath = Path.Combine(languagePath, bookBRName);
				if (!File.Exists(bookBRPath))
				{
					continue;
				}
				var model = new OptionsBookModel(value);
				models.Add(value.Code, model);
				books.Add(model);
			}
		}
		catch
		{
		}
		finally
		{
			booksReader?.Dispose();
		}
		var y = new BytesColumn();
		var z = new BytesColumn();
		var columns = new BytesColumn[3] { x, y, z, };
		while (true)
		{
			BytesColumns.Clear(columns);
			if (!reader.ReadColumnsEnding(readSeparator, columns))
			{
				break;
			}
			if (x.Count <= 0)
			{
				continue;
			}

			var bookCode = x.ToString();
			if (!models.TryGetValue(bookCode, out var model))
			{
				changed = true;
				continue;
			}
			if (y.Count == 1)
			{
				model.Include = y[0] == '1';
			}
			else
			{
				model.Include = false;
			}
			if (z.Count == 1)
			{
				model.PreUse = z[0] == '1';
			}
			else
			{
				model.PreUse = false;
			}
			model.ResetChanged();
		}
	}

	private static void Write()
	{
		FileStream? writerStream = null;
		StreamWriter? writer = null;
		try
		{
			writerStream = new FileStream(optionsPath, FileMode.Create, FileAccess.Write, FileShare.Read);
			writer = new StreamWriter(writerStream);

			writer.WriteLine(languageCode);

			writer.WriteLine(portion);

			foreach (var value in books)
			{
				writer.Write(value.Code);
				writer.Write(writeSeparator);
				if (value.Include)
				{
					writer.Write('1');
				}
				else
				{
					writer.Write('0');
				}
				writer.Write(writeSeparator);
				if (value.PreUse)
				{
					writer.WriteLine('1');
				}
				else
				{
					writer.WriteLine('0');
				}
			}
		}
		catch
		{
		}
		finally
		{
			writer?.Dispose();
			writerStream?.Dispose();
		}
	}
}

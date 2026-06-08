using System.IO;
using System.IO.Compression;
using System.Net;

namespace SeekingYHWH.Scriptures.Search.BibleAPI;

internal static class Program
{
	private const string schema = "https";
	private const string host = "bible-api.com";
	private const string bibleURL = schema + "://" + host + "/data/{0}";

	private const char separator = '\t';

	private static int Main(string[] args)
	{
		Prepare();
		return Execute();
	}

	private static string scripturesPath = @"D:\Projects\SeekingYHWH.Scriptures.Search";
	private static TimeSpan wait = TimeSpan.FromSeconds(3);
	private static bool tsvDelete = true;

	private static readonly HashSet<string> ot = new HashSet<string>() //Missing Ester and Songs of Solomon on purpose
	{
		"GEN", "EXO", "LEV", "NUM", "DEU", "JOS", "JDG", "RUT",
		"1SA", "2SA", "1KI", "2KI", "1CH", "2CH", "EZR", "NEH",
		"JOB", "PSA", "PRO", "ECC", "ISA", "JER", "LAM", "EZK",
		"DAN", "HOS", "JOL", "AMO", "OBA", "JON", "MIC", "NAM",
		"HAB", "ZEP", "HAG", "ZEC", "MAL",
	};
	private static readonly HashSet<string> nt = new HashSet<string>()
	{
		"MAT", "MRK", "LUK", "JHN", "ACT", "ROM", "1CO", "2CO",
		"GAL", "EPH", "PHP", "COL", "1TH", "2TH", "1TI", "2TH",
		"1TI", "2TI", "TIT", "PHM", "HEB", "JAS", "1PE", "2PE",
		"1JN", "2JN", "3JN", "JUD", "REV",
	};
	private static readonly LanguageInfo[] languages = new LanguageInfo[]
	{
		new LanguageInfo()
		{
			Code = "chr",
			Name = "ᏤᏬᎩ",
			Collections = new CollectionInfo[]
			{
				new CollectionInfo()
				{
					Code = "NT-CNT",
					Name = "Cherokee New Testament",
					Pre = "CNT",
					Id = "cherokee",
					Includes = nt,
				},
			},
		},
		new LanguageInfo()
		{
			Code = "eng",
			Name = "English",
			Collections = new CollectionInfo[]
			{
				new CollectionInfo()
				{
					Code = "OT-WEB",
					Name = "Old Testament - WEB",
					Pre = "WEB",
					Id = "web",
					Includes = ot,
				},
				new CollectionInfo()
				{
					Code = "NT-WEB",
					Name = "New Testament - WEB",
					Pre = "WEB",
					Id = "web",
					Includes = nt,
				},
			},
		}
	};
	private static HttpClient client;
	private static readonly byte[] buffer = new byte[32 * 1024];
	private static readonly List<BookInfo> books = new List<BookInfo>();
	private static readonly List<ChapterInfo> chapters = new List<ChapterInfo>();
	private static readonly List<VerseInfo> verses = new List<VerseInfo>();

	private static void Prepare()
	{
		PrepareClient();
	}

	private static void PrepareClient()
	{
		var handler = new HttpClientHandler()
		{
			AutomaticDecompression = DecompressionMethods.All,
		};
		client = new HttpClient(handler);
		client.BaseAddress = new Uri(schema + "://" + host + "/");
		var headers = client.DefaultRequestHeaders;
		headers.Add("Host", host);
		headers.Add("Connection", "Keep-Alive");
	}

	private static int Execute()
	{
		WriteLanguages();
		foreach (var language in languages)
		{
			ProcessLanguage(language);
		}
		return 0;
	}

	private static void WriteLanguages()
	{
		var values = new List<LanguageInfo>();
		foreach (var value in languages)
		{
			var collections = value.Collections;
			if (collections == null || collections.Length <= 0)
			{
				continue;
			}

			values.Add(value);
		}
		if (values.Count <= 0)
		{
			return;
		}
		Languages.Update(scripturesPath, values);
	}

	private static void ProcessLanguage(LanguageInfo language)
	{
		var languageCode = language.Code;
		var languagePath = Path.Combine(scripturesPath, languageCode);
		try
		{
			Directory.CreateDirectory(languagePath);
		}
		catch (Exception exception)
		{
			Console.Error.WriteLine("Can't create {0} {1}", languagePath, exception.Message);
			return;
		}
		try
		{
			Directory.CreateDirectory(languageCode);
		}
		catch (Exception exception)
		{
			Console.Error.WriteLine("Can't create {0} {1}", languageCode, exception.Message);
			return;
		}

		foreach (var collection in language.Collections)
		{
			ProcessCollection(language, collection);
		}

		if (tsvDelete)
		{
			try
			{
				Directory.Delete(languageCode, true);
			}
			catch (Exception exception)
			{
				Console.Error.WriteLine("Can't delete {0} {1}", languageCode, exception.Message);
			}
		}
	}

	private static void ProcessCollection(LanguageInfo language, CollectionInfo collection)
	{
		var languageCode = language.Code;
		var bookCode = collection.Code;

		books.Clear();
		Thread.Sleep(wait);
		var url = string.Format(bibleURL, collection.Id);
		Console.WriteLine(url);
		using (var reader = client.GetStreamAsync(url).Result)
		{
			BibleConverter.Parse(books, reader, buffer);
		}

		var includes = collection.Includes;
		var included = 0;
		foreach (var book in books)
		{
			if (includes.Contains(book.Id))
			{
				++included;
			}
		}
		if (included <= 0)
		{
			Console.WriteLine("No books included for {0}", collection.Id);
			return;
		}

		var tsvPath = Path.Combine(languageCode, bookCode + ".tsv");
		using (var writerStream = new FileStream(tsvPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		using (var writer = new StreamWriter(writerStream))
		{
			foreach (var book in books)
			{
				if (!includes.Contains(book.Id!))
				{
					continue;
				}

				ProcessBook(writer, collection, book);
			}
		}


		var languagePath = Path.Combine(scripturesPath, languageCode);

		var hashPath = Path.Combine(languagePath, bookCode + ".tsv.hsh");
		Hash.Compute(tsvPath, hashPath);

		var brPath = Path.Combine(languagePath, bookCode + ".tsv.br");
		using (var writerStream = new FileStream(brPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		using (var writer = new BrotliStream(writerStream, CompressionLevel.SmallestSize))
		using (var reader = new FileStream(tsvPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			reader.CopyTo(writer);
		}

		Books.Update(languagePath, new[] { collection });

		if (tsvDelete)
		{
			try
			{
				File.Delete(tsvPath);
			}
			catch (Exception exception)
			{
				Console.Error.WriteLine("Can't delete {0} {1}", tsvPath, exception.Message);
			}
		}
	}

	private static void ProcessBook(StreamWriter writer, CollectionInfo collection, BookInfo book)
	{
		chapters.Clear();

		Thread.Sleep(wait);
		var url = book.URL;
		Console.WriteLine(url);
		using (var reader = client.GetStreamAsync(url).Result)
		{
			BookConverter.Parse(chapters, reader, buffer);
		}

		var bookName = book.Name;
		foreach (var chapter in chapters)
		{
			ProcessChapter(writer, bookName, chapter);
		}
	}

	private static void ProcessChapter(StreamWriter writer, string bookName, ChapterInfo chapter)
	{
		verses.Clear();

		Thread.Sleep(wait);
		var url = chapter.URL;
		Console.WriteLine(url);
		using (var reader = client.GetStreamAsync(url).Result)
		{
			ChapterConverter.Parse(verses, reader, buffer);
		}

		writer.Write(bookName);
		writer.Write(' ');
		writer.Write(chapter.Chapter);
		writer.WriteLine();

		foreach (var verse in verses)
		{
			var verseText = verse.Text.Trim();
			writer.Write(verse.Verse);
			writer.Write(separator);
			writer.Write(verseText);
			writer.WriteLine();
		}

		writer.WriteLine();
	}
}

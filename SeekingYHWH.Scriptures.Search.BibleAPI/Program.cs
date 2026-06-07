using System.IO;
using System.IO.Compression;
using System.Net;
using System.Security.Cryptography;

namespace SeekingYHWH.Scriptures.Search.BibleAPI;

internal static class  Program
{
	private const string schema = "https";
	private const string host = "bible-api.com";
	private const string bookURL = schema + "://" + host + "/data/{0}/{1}";

	private const char separator = '\t';

	private static int Main(string[] args)
	{
		Prepare();
		return Execute();
	}

	private static string scripturesPath = @"D:\Projects\SeekingYHWH.Scriptures.Search";
	private static TimeSpan wait = TimeSpan.FromSeconds(3);
	private static bool tsvDelete = true;

	private static readonly string[] ot = new string[]
	{
		"GEN", "EXO", "LEV", "NUM", "DEU", "JOS", "JDG", "RUT",
		"1SA", "2SA", "1KI", "2KI", "1CH", "2CH", "EZR", "NEH",
		"JOB", "PSA", "PRO", "ECC", "ISA", "JER", "LAM", "EZK",
		"DAN", "HOS", "JOL", "AMO", "OBA", "JON", "MIC", "NAM",
		"HAB", "ZEP", "HAG", "ZEC", "MAL",
	};
	private static readonly string[] nt = new string[]
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
					Books = nt,
				},
			},
		},
	};
	private static HttpClient client;
	private static readonly byte[] buffer = new byte[32 * 1024];
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

		var tsvPath = Path.Combine(languageCode, bookCode + ".tsv");
		var books = collection.Books;
		using (var writerStream = new FileStream(tsvPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		using (var writer = new StreamWriter(writerStream))
		{
			foreach (var book in books)
			{
				ProcessBook(writer, collection, book, chapters);
			}
		}

		byte[] hash;
		using (var hasher = SHA256.Create())
		using (var reader = new FileStream(tsvPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			hash = hasher.ComputeHash(reader);
		}

		var languagePath = Path.Combine(scripturesPath, languageCode);

		var hashPath = Path.Combine(languagePath, bookCode + ".tsv.hsh");
		using (var writer = new FileStream(hashPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		{
			writer.Write(hash, 0, hash.Length);
		}

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

	private static void ProcessBook(StreamWriter writer, CollectionInfo collection, string book, List<ChapterInfo> chapters)
	{
		chapters.Clear();

		Thread.Sleep(wait);
		var url = string.Format(bookURL, collection.Id, book);
		Console.WriteLine(url);
		using (var reader = client.GetStreamAsync(url).Result)
		{
			BookConverter.Parse(chapters, reader, buffer);
		}

		foreach (var chapter in chapters)
		{
			ProcessChapter(writer, chapter);
		}
	}

	private static void ProcessChapter(StreamWriter writer, ChapterInfo chapter)
	{
		verses.Clear();

		Thread.Sleep(wait);
		var url = chapter.URL;
		Console.WriteLine(url);
		using (var reader = client.GetStreamAsync(url).Result)
		{
			ChapterConverter.Parse(verses, reader, buffer);
		}

		writer.Write(chapter.Book);
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

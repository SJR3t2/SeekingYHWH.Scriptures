using System.ComponentModel.DataAnnotations;
using System.Net;

namespace SeekingYHWH.Scriptures.Search.BibleAPI;

internal static class  Program
{
	private const string schema = "https";
	private const string host = "bible-api.com";
	private const string bookURL = "/data/{0}/{1}";

	private static int Main(string[] args)
	{
		Prepare();
		return Execute();
	}

	private static string scripturesPath = @"D:\Projects\SeekingYHWH.Scriptures.Search";

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
					Books = new string[]
					{
						"MAT", "MRK", "LUK", "JHN", "ACT", "ROM", "1CO", "2CO",
						"GAL", "EPH", "PHP", "COL", "1TH", "2TH", "1TI", "2TH",
						"1TI", "2TI", "TIT", "PHM",	"HEB", "JAS", "1PE", "2PE",
						"1JN", "2JN", "3JN", "JUD", "REV",
					},
				},
			},
		},
	};
	private static HttpClient client;
	private static readonly byte[] buffer = new byte[4096];
	private static readonly List<ChapterInfo> chapters = new List<ChapterInfo>();

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
		try
		{
			Directory.CreateDirectory(language.Code);
		}
		catch (Exception exception)
		{
			Console.Error.WriteLine("Can't create {0} {1}", language.Code, exception.Message);
			return;
		}

		foreach (var collection in language.Collections)
		{
			ProcessCollection(language, collection);
		}

		try
		{
			Directory.Delete(language.Code, true);
		}
		catch (Exception exception)
		{
			Console.Error.WriteLine("Can't delete {0} {1}", language.Code, exception.Message);
		}
	}

	private static void ProcessCollection(LanguageInfo language, CollectionInfo collection)
	{
		var tsvPath = Path.Combine(language.Code, collection.Code + ".tsv");
		var books = collection.Books;
		using (var writerStream = new FileStream(tsvPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		using (var writer = new StreamWriter(writerStream))
		{
			for (var b = 0; true; )
			{
				var book = books[b];
				ProcessBook(writer, collection, book, chapters);

				++b;
				if (b >= books.Length)
				{
					break;
				}

				writer.WriteLine();
			}
		}
	}

	private static void ProcessBook(StreamWriter writer, CollectionInfo collection, string book, List<ChapterInfo> chapters)
	{
		chapters.Clear();

		var url = string.Format(bookURL, collection.Id, book);
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
		var url = chapter.URL;
		using (var reader = client.GetStreamAsync(url).Result)
		{
			//TODO: Verses
		}
	}
}

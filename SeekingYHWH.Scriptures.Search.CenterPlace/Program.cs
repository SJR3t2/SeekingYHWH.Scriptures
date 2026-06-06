using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace SeekingYHWH.Scriptures.Search.CenterPlace;

//http://centerplace.org/
internal static class Program
{
	private const string schema = "http";
	private const string host = "centerplace.org";
	private const char separator = '\t';

	private static int Main(string[] args)
	{
		var errors = ParseCommandLine(args);
		if (errors != null)
		{
			PrintHelp(errors);
			return -1;
		}

		Prepare();
		return Run();
	}

	private static string scripturesPath = @"D:\Projects\SeekingYHWH.Scriptures.Search";
	private static string languageCode = "eng";
	private static readonly BookInfo[] books = new BookInfo[]
	{
		new BookInfo() { Code = "OT-IVC", Name = "Old Testament - Inspired Version CenterPlace", Pre = "IVC", Chapterss = new ChaptersInfo[]
		{
			new ChaptersInfo("Revelation To Moses", "hs/iv/revela.htm", ParserMoses),
			new ChaptersInfo("Genesis", "hs/iv/genesis.htm", ParserIVC),
			new ChaptersInfo("Exodus", "hs/iv/exodus.htm", ParserIVC),
			new ChaptersInfo("Leviticus", "hs/iv/leviticus.htm", ParserIVC),
			new ChaptersInfo("Numbers", "hs/iv/numbers.htm", ParserIVC),
			new ChaptersInfo("Deuteronomy", "hs/iv/deuteronomy.htm", ParserIVC),
			new ChaptersInfo("Joshua", "hs/iv/joshua.htm", ParserIVC),
			new ChaptersInfo("Judges", "hs/iv/judges.htm", ParserIVC),
			new ChaptersInfo("Ruth", "hs/iv/ruth.htm", ParserIVC),
			new ChaptersInfo("1 Samuel", "hs/iv/1samuel.htm", ParserIVC),
			new ChaptersInfo("2 Samuel", "hs/iv/2samuel.htm", ParserIVC),
			new ChaptersInfo("1 Kings", "hs/iv/1kings.htm", ParserIVC),
			new ChaptersInfo("2 Kings", "hs/iv/2kings.htm", ParserIVC),
			new ChaptersInfo("1 Chronicles", "hs/iv/1chronicles.htm", ParserIVC),
			new ChaptersInfo("2 Chronicles", "hs/iv/2chronicles.htm", ParserIVC),
			new ChaptersInfo("Ezra", "hs/iv/ezra.htm", ParserIVC),
			new ChaptersInfo("Nehemiah", "hs/iv/nehemiah.htm", ParserIVC),
			new ChaptersInfo("Job", "hs/iv/job.htm", ParserIVC),
			new ChaptersInfo("Psalms", "hs/iv/psalms.htm", ParserIVC),
			new ChaptersInfo("Proverbs", "hs/iv/proverbs.htm", ParserIVC),
			new ChaptersInfo("Ecclesiastes", "hs/iv/ecclesiastes.htm", ParserIVC),
			new ChaptersInfo("Isaiah", "hs/iv/isaiah.htm", ParserIVC),
			new ChaptersInfo("Jeremiah", "hs/iv/jeremiah.htm", ParserIVC),
			new ChaptersInfo("Lamentations", "hs/iv/lamentations.htm", ParserIVC),
			new ChaptersInfo("Ezekiel", "hs/iv/ezekiel.htm", ParserIVC),
			new ChaptersInfo("Daniel", "hs/iv/daniel.htm", ParserIVC),
			new ChaptersInfo("Hosea", "hs/iv/hosea.htm", ParserIVC),
			new ChaptersInfo("Joel", "hs/iv/joel.htm", ParserIVC),
			new ChaptersInfo("Amos", "hs/iv/amos.htm", ParserIVC),
			new ChaptersInfo("Obadiah", "hs/iv/obadiah.htm", ParserIVC),
			new ChaptersInfo("Jonah", "hs/iv/jonah.htm", ParserIVC),
			new ChaptersInfo("Micah", "hs/iv/micah.htm", ParserIVC),
			new ChaptersInfo("Nahum", "hs/iv/nahum.htm", ParserIVC),
			new ChaptersInfo("Habakkuk", "hs/iv/habakkuk.htm", ParserIVC),
			new ChaptersInfo("Zephaniah", "hs/iv/zephaniah.htm", ParserIVC),
			new ChaptersInfo("Haggai", "hs/iv/haggai.htm", ParserIVC),
			new ChaptersInfo("Zechariah", "hs/iv/zechariah.htm", ParserIVC),
			new ChaptersInfo("Malachi", "hs/iv/malachi.htm", ParserIVC),
		}, },
		new BookInfo() { Code = "NT-IVC", Name = "New Testament - Inspired Version CenterPlace", Pre = "IVC", Chapterss = new ChaptersInfo[]
		{
			new ChaptersInfo("Matthew", "hs/iv/matthew.htm", ParserIVC),
			new ChaptersInfo("Mark", "hs/iv/mark.htm", ParserIVC),
			new ChaptersInfo("Luke", "hs/iv/luke.htm", ParserIVC),
			new ChaptersInfo("John", "hs/iv/john.htm", ParserIVC),
			new ChaptersInfo("Acts", "hs/iv/acts.htm", ParserIVC),
			new ChaptersInfo("Romans", "hs/iv/romans.htm", ParserIVC),
			new ChaptersInfo("1 Corinthians", "hs/iv/1corinthians.htm", ParserIVC),
			new ChaptersInfo("2 Corinthians", "hs/iv/2corinthians.htm", ParserIVC),
			new ChaptersInfo("Galatians", "hs/iv/galatians.htm", ParserIVC),
			new ChaptersInfo("Ephesians", "hs/iv/ephesians.htm", ParserIVC),
			new ChaptersInfo("Philippians", "hs/iv/philippians.htm", ParserIVC),
			new ChaptersInfo("Colossians", "hs/iv/colossians.htm", ParserIVC),
			new ChaptersInfo("1 Thessalonians", "hs/iv/1thessalonians.htm", ParserIVC),
			new ChaptersInfo("2 Thessalonians", "hs/iv/2thessalonians.htm", ParserIVC),
			new ChaptersInfo("1 Timothy", "hs/iv/1timothy.htm", ParserIVC),
			new ChaptersInfo("2 Timothy", "hs/iv/2timothy.htm", ParserIVC),
			new ChaptersInfo("Titus", "hs/iv/titus.htm", ParserIVC),
			new ChaptersInfo("Philemon", "hs/iv/philemon.htm", ParserIVC),
			new ChaptersInfo("Hebrews", "hs/iv/hebrews.htm", ParserIVC),
			new ChaptersInfo("James", "hs/iv/james.htm", ParserIVC),
			new ChaptersInfo("1 Peter", "hs/iv/1peter.htm", ParserIVC),
			new ChaptersInfo("2 Peter", "hs/iv/2peter.htm", ParserIVC),
			new ChaptersInfo("1 John", "hs/iv/1john.htm", ParserIVC),
			new ChaptersInfo("2 John", "hs/iv/2john.htm", ParserIVC),
			new ChaptersInfo("3 John", "hs/iv/3john.htm", ParserIVC),
			new ChaptersInfo("Jude", "hs/iv/jude.htm", ParserIVC),
			new ChaptersInfo("Revelation", "hs/iv/revelation.htm", ParserIVC),
		}, },
		new BookInfo() { Code = "BoM-RLDS", Name = "Book of Mormon - RLDS 1908", Pre = "RLDS", Chapterss = new ChaptersInfo[]
		{
			new ChaptersInfo("Book of Mormon Title Page", "hs/bm/titlepage.htm", ParserBoMTitle),
			new ChaptersInfo("Testimony of Three Witnesses", "Testimony of Three Witnesses", Parser3Witnesses),
			new ChaptersInfo("Testimony of Eight Witnesses", "Testimony of Eight Witnesses", Parser8Witnesses),
			new ChaptersInfo("1 Nephi", "hs/bm/1nephi.htm", ParserBoMBookIntros),
			new ChaptersInfo("2 Nephi", "hs/bm/2nephi.htm", ParserBoMBookIntros),
			new ChaptersInfo("Jacob", "hs/bm/jacob.htm", ParserBoMBookIntros),
			new ChaptersInfo("Enos", "hs/bm/enos.htm", ParserBoMNoIntros),
			new ChaptersInfo("Jarom", "hs/bm/jarom.htm", ParserBoMNoIntros),
			new ChaptersInfo("Omni", "hs/bm/omni.htm", ParserBoMNoIntros),
			new ChaptersInfo("Words of Mormon", "hs/bm/wordsofmormon.htm", ParserBoMNoIntros),
			new ChaptersInfo("Mosiah", "hs/bm/mosiah.htm", ParserMosiah),
			new ChaptersInfo("Alma", "hs/bm/alma.htm", ParserAlma),
			new ChaptersInfo("Helaman", "hs/bm/helaman.htm", ParserHelaman),
			new ChaptersInfo("3 Nephi", "hs/bm/3nephi.htm", Parser3Nephi),
			new ChaptersInfo("4 Nephi", "hs/bm/4nephi.htm", Parser4Nephi),
			new ChaptersInfo("Mormon", "hs/bm/mormon.htm", ParserBoMNoIntros),
			new ChaptersInfo("Ether", "hs/bm/ether.htm", ParserBoMNoIntros),
			new ChaptersInfo("Moroni", "hs/bm/moroni.htm", ParserMoroni),
		}, },
		new BookInfo() { Code = "DnC-RLDS", Name = "Doctrine and Covenants - RLDS", Pre = "RLDS", Chapterss = new ChaptersInfo[]
		{
			new ChaptersInfo("D&C 1", "hs/dc/section001.htm", ParserDnC),
			new ChaptersInfo("D&C 2", "hs/dc/section002.htm", ParserDnC),
			new ChaptersInfo("D&C 3", "hs/dc/section003.htm", ParserDnC),
			new ChaptersInfo("D&C 4", "hs/dc/section004.htm", ParserDnC),
			new ChaptersInfo("D&C 5", "hs/dc/section005.htm", ParserDnC),
			new ChaptersInfo("D&C 6", "hs/dc/section006.htm", ParserDnC),
			new ChaptersInfo("D&C 7", "hs/dc/section007.htm", ParserDnC),
			new ChaptersInfo("D&C 8", "hs/dc/section008.htm", ParserDnC),
			new ChaptersInfo("D&C 9", "hs/dc/section009.htm", ParserDnC),
			new ChaptersInfo("D&C 10", "hs/dc/section010.htm", ParserDnC),
			new ChaptersInfo("D&C 11", "hs/dc/section011.htm", ParserDnC),
			new ChaptersInfo("D&C 12", "hs/dc/section012.htm", ParserDnC),
			new ChaptersInfo("D&C 13", "hs/dc/section013.htm", ParserDnC),
			new ChaptersInfo("D&C 14", "hs/dc/section014.htm", ParserDnC),
			new ChaptersInfo("D&C 15", "hs/dc/section015.htm", ParserDnC),
			new ChaptersInfo("D&C 16", "hs/dc/section016.htm", ParserDnC),
			new ChaptersInfo("D&C 17", "hs/dc/section017.htm", ParserDnC),
			new ChaptersInfo("D&C 18", "hs/dc/section018.htm", ParserDnC),
			new ChaptersInfo("D&C 19", "hs/dc/section019.htm", ParserDnC),
			new ChaptersInfo("D&C 20", "hs/dc/section020.htm", ParserDnC),
			new ChaptersInfo("D&C 21", "hs/dc/section021.htm", ParserDnC),
			new ChaptersInfo("D&C 22", "hs/dc/section022.htm", ParserDnC),
			new ChaptersInfo("D&C 23", "hs/dc/section023.htm", ParserDnC),
			new ChaptersInfo("D&C 24", "hs/dc/section024.htm", ParserDnC),
			new ChaptersInfo("D&C 25", "hs/dc/section025.htm", ParserDnC),
			new ChaptersInfo("D&C 26", "hs/dc/section026.htm", ParserDnC),
			new ChaptersInfo("D&C 27", "hs/dc/section027.htm", ParserDnC),
			new ChaptersInfo("D&C 28", "hs/dc/section028.htm", ParserDnC),
			new ChaptersInfo("D&C 29", "hs/dc/section029.htm", ParserDnC),
			new ChaptersInfo("D&C 30", "hs/dc/section030.htm", ParserDnC),
			new ChaptersInfo("D&C 31", "hs/dc/section031.htm", ParserDnC),
			new ChaptersInfo("D&C 32", "hs/dc/section032.htm", ParserDnC),
			new ChaptersInfo("D&C 33", "hs/dc/section033.htm", ParserDnC),
			new ChaptersInfo("D&C 34", "hs/dc/section034.htm", ParserDnC),
			new ChaptersInfo("D&C 35", "hs/dc/section035.htm", ParserDnC),
			new ChaptersInfo("D&C 36", "hs/dc/section036.htm", ParserDnC),
			new ChaptersInfo("D&C 37", "hs/dc/section037.htm", ParserDnC),
			new ChaptersInfo("D&C 38", "hs/dc/section038.htm", ParserDnC),
			new ChaptersInfo("D&C 39", "hs/dc/section039.htm", ParserDnC),
			new ChaptersInfo("D&C 40", "hs/dc/section040.htm", ParserDnC),
			new ChaptersInfo("D&C 41", "hs/dc/section041.htm", ParserDnC),
			new ChaptersInfo("D&C 42", "hs/dc/section042.htm", ParserDnC),
			new ChaptersInfo("D&C 43", "hs/dc/section043.htm", ParserDnC),
			new ChaptersInfo("D&C 44", "hs/dc/section044.htm", ParserDnC),
			new ChaptersInfo("D&C 45", "hs/dc/section045.htm", ParserDnC),
			new ChaptersInfo("D&C 46", "hs/dc/section046.htm", ParserDnC),
			new ChaptersInfo("D&C 47", "hs/dc/section047.htm", ParserDnC),
			new ChaptersInfo("D&C 48", "hs/dc/section048.htm", ParserDnC),
			new ChaptersInfo("D&C 49", "hs/dc/section049.htm", ParserDnC),
			new ChaptersInfo("D&C 50", "hs/dc/section050.htm", ParserDnC),
			new ChaptersInfo("D&C 51", "hs/dc/section051.htm", ParserDnC),
			new ChaptersInfo("D&C 52", "hs/dc/section052.htm", ParserDnC),
			new ChaptersInfo("D&C 53", "hs/dc/section053.htm", ParserDnC),
			new ChaptersInfo("D&C 54", "hs/dc/section054.htm", ParserDnC),
			new ChaptersInfo("D&C 55", "hs/dc/section055.htm", ParserDnC),
			new ChaptersInfo("D&C 56", "hs/dc/section056.htm", ParserDnC),
			new ChaptersInfo("D&C 57", "hs/dc/section057.htm", ParserDnC),
			new ChaptersInfo("D&C 58", "hs/dc/section058.htm", ParserDnC),
			new ChaptersInfo("D&C 59", "hs/dc/section059.htm", ParserDnC),
			new ChaptersInfo("D&C 60", "hs/dc/section060.htm", ParserDnC),
			new ChaptersInfo("D&C 61", "hs/dc/section061.htm", ParserDnC),
			new ChaptersInfo("D&C 62", "hs/dc/section062.htm", ParserDnC),
			new ChaptersInfo("D&C 63", "hs/dc/section063.htm", ParserDnC),
			new ChaptersInfo("D&C 64", "hs/dc/section064.htm", ParserDnC),
			new ChaptersInfo("D&C 65", "hs/dc/section065.htm", ParserDnC),
			new ChaptersInfo("D&C 66", "hs/dc/section066.htm", ParserDnC),
			new ChaptersInfo("D&C 67", "hs/dc/section067.htm", ParserDnC),
			new ChaptersInfo("D&C 68", "hs/dc/section068.htm", ParserDnC),
			new ChaptersInfo("D&C 69", "hs/dc/section069.htm", ParserDnC),
			new ChaptersInfo("D&C 70", "hs/dc/section070.htm", ParserDnC),
			new ChaptersInfo("D&C 71", "hs/dc/section071.htm", ParserDnC),
			new ChaptersInfo("D&C 72", "hs/dc/section072.htm", ParserDnC),
			new ChaptersInfo("D&C 73", "hs/dc/section073.htm", ParserDnC),
			new ChaptersInfo("D&C 74", "hs/dc/section074.htm", ParserDnC),
			new ChaptersInfo("D&C 75", "hs/dc/section075.htm", ParserDnC),
			new ChaptersInfo("D&C 76", "hs/dc/section076.htm", ParserDnC),
			new ChaptersInfo("D&C 77", "hs/dc/section077.htm", ParserDnC),
			new ChaptersInfo("D&C 78", "hs/dc/section078.htm", ParserDnC),
			new ChaptersInfo("D&C 79", "hs/dc/section079.htm", ParserDnC),
			new ChaptersInfo("D&C 80", "hs/dc/section080.htm", ParserDnC),
			new ChaptersInfo("D&C 81", "hs/dc/section081.htm", ParserDnC),
			new ChaptersInfo("D&C 82", "hs/dc/section082.htm", ParserDnC),
			new ChaptersInfo("D&C 83", "hs/dc/section083.htm", ParserDnC),
			new ChaptersInfo("D&C 84", "hs/dc/section084.htm", ParserDnC),
			new ChaptersInfo("D&C 85", "hs/dc/section085.htm", ParserDnC),
			new ChaptersInfo("D&C 86", "hs/dc/section086.htm", ParserDnC),
			new ChaptersInfo("D&C 87", "hs/dc/section087.htm", ParserDnC),
			new ChaptersInfo("D&C 88", "hs/dc/section088.htm", ParserDnC),
			new ChaptersInfo("D&C 89", "hs/dc/section089.htm", ParserDnC),
			new ChaptersInfo("D&C 90", "hs/dc/section090.htm", ParserDnC),
			new ChaptersInfo("D&C 91", "hs/dc/section091.htm", ParserDnC),
			new ChaptersInfo("D&C 92", "hs/dc/section092.htm", ParserDnC),
			new ChaptersInfo("D&C 93", "hs/dc/section093.htm", ParserDnC),
			new ChaptersInfo("D&C 94", "hs/dc/section094.htm", ParserDnC),
			new ChaptersInfo("D&C 95", "hs/dc/section095.htm", ParserDnC),
			new ChaptersInfo("D&C 96", "hs/dc/section096.htm", ParserDnC),
			new ChaptersInfo("D&C 97", "hs/dc/section097.htm", ParserDnC),
			new ChaptersInfo("D&C 98", "hs/dc/section098.htm", ParserDnC),
			new ChaptersInfo("D&C 100", "hs/dc/section100.htm", ParserDnC),
			new ChaptersInfo("D&C 101", "hs/dc/section101.htm", ParserDnC),
			new ChaptersInfo("D&C 102", "hs/dc/section102.htm", ParserDnC),
			new ChaptersInfo("D&C 103", "hs/dc/section103.htm", ParserDnC),
			new ChaptersInfo("D&C 104", "hs/dc/section104.htm", ParserDnC),
			new ChaptersInfo("D&C 105", "hs/dc/section105.htm", ParserDnC),
			new ChaptersInfo("D&C 106", "hs/dc/section106.htm", ParserDnC),
			new ChaptersInfo("D&C 108", "hs/dc/section108.htm", ParserDnC),
			new ChaptersInfo("D&C 111", "hs/dc/section111.htm", ParserDnC),
			new ChaptersInfo("D&C 112", "hs/dc/section112.htm", ParserDnC),
		}, },
	};

	private static HttpClient client;
	private static string languagePath;

	private static readonly StringBuilder builder = new StringBuilder();

	private static List<string> ParseCommandLine(string[] args)
	{
		return null;
	}

	private static void PrintHelp(List<string> errors)
	{
		Console.WriteLine();
		Console.WriteLine("SeekingYHWH.Scriptures.Search.CenterPlace.exe");
		Console.WriteLine(" Required");
		Console.WriteLine(" Optional");
		Console.WriteLine();

		if (errors != null && errors.Count > 0)
		{
			foreach (var error in errors)
			{
				Console.Error.WriteLine(error);
			}
			Console.WriteLine();
		}
	}

	private static void Prepare()
	{
		Console.Title = "SeekingYHWH.Scriptures.Search.CenterPlace";

		PrepareClient();
		PrepareLanguagePath();

		GC.Collect();
	}

	private static void PrepareClient()
	{
		var handler = new HttpClientHandler()
		{
			AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
		};
		client = new HttpClient(handler);
		client.BaseAddress = new Uri(schema + "://" + host + "/");
		var headers = client.DefaultRequestHeaders;
		headers.Add("Host", host);
		headers.Add("Connection", "Keep-Alive");
		headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
		headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("deflate"));
	}

	private static void PrepareLanguagePath()
	{
		languagePath = Path.Combine(scripturesPath, languageCode);
	}

	private static int Run()
	{
		foreach (var book in books)
		{
			Console.WriteLine(book.Name);

			ProcessBook(book);
		}
		Books.Update(languagePath, books);
		return 0;
	}

	private static void ProcessBook(BookInfo book)
	{
		var brPath = Path.Combine(languagePath, book.Code + ".tsv.br");
		using (var writerFile = new FileStream(brPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		using (var writerStream = new BrotliStream(writerFile, CompressionLevel.SmallestSize))
		using (var writer = new StreamWriter(writerStream))
		{
			var chapterss = book.Chapterss;
			for (var i = 0; true; )
			{
				var chapters = chapterss[i];

				Console.WriteLine(chapters.URL);

				chapters.Parser(writer, chapters);
				++i;
				if (i >= chapterss.Length)
				{
					break;
				}
				writer.WriteLine();
			}
		}

		byte[] hash;
		using (var readerFile = new FileStream(brPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (var readerStream = new BrotliStream(readerFile, CompressionMode.Decompress))
		using (var hasher = SHA256.Create())
		{
			hash = hasher.ComputeHash(readerStream);
		}
		var hashPath = Path.Combine(languagePath, book.Code + ".tsv.hsh");
		using (var writerFile = new FileStream(hashPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		{
			writerFile.Write(hash, 0, hash.Length);
		}
	}

	private static void ParserMoses(StreamWriter writer, ChaptersInfo info)
	{
		var book = info.Book;
		var html = client.GetStringAsync(info.URL).Result;
		using (var reader = new StringReader(html))
		{
			if (!GetStartsWith(reader, "<body"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<H2 ", out var line))
			{
				return;
			}
			writer.Write(book);
			writer.Write(' ');
			writer.WriteLine("1");
			var verse = 0;
			while (true)
			{
				line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				if (line.StartsWith("<P>"))
				{
					builder.Clear();
					++verse;
					line = line.Substring(3).Trim();
					while (true)
					{
						var ending = line.IndexOf("</P>");
						if (ending >= 0)
						{
							line = line.Substring(0, ending).Trim();
							builder.Append(line);
							break;
						}
						builder.Append(line);
						line = reader.ReadLine();
						if (line is null)
						{
							break;
						}
						line = line.Trim();
						builder.Append(' ');
					}
					line = builder.ToString();
					writer.Write(verse);
					writer.Write(separator);
					writer.WriteLine(line);
				}
				else
				{
					continue;
				}
			}
		}
	}

	private static void ParserIVC(StreamWriter writer, ChaptersInfo info)
	{
		var book = info.Book;
		var html = client.GetStringAsync(info.URL).Result;
		using (var reader = new StringReader(html))
		{
			if (!GetStartsWith(reader, "<body"))
			{
				return;
			}
			if (!GetStartsWith(reader, "</header>"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<h2 class=\"Book"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<a name=\"c", out var line))
			{
				return;
			}
			var chapter = ExtractChapter(line);
			writer.Write(book);
			writer.Write(' ');
			writer.WriteLine(chapter);
			while (true)
			{
				line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				if (line.StartsWith("<a name=\"c"))
				{
					chapter = ExtractChapter(line);
					writer.WriteLine();
					writer.Write(book);
					writer.Write(' ');
					writer.WriteLine(chapter);
					continue;
				}
				else if (line.StartsWith("<a name=\"v"))
				{
					builder.Clear();
					var colon = line.IndexOf(':');
					if (colon < 0)
					{
						continue;
					}
					var verseOffset = colon + 1;
					var verseNext = verseOffset + 1;
					while (char.IsDigit(line[verseNext]))
					{
						++verseNext;
					}
					var verseLength = verseNext - verseOffset;
					var verse = line.Substring(verseOffset, verseLength);
					line = line.Substring(verseNext + 1);
					while (true)
					{
						var ending = line.IndexOf("</p></a>");
						if (ending >= 0)
						{
							line = line.Substring(0, ending).Trim();
							builder.Append(line);
							break;
						}
						builder.Append(line);
						line = reader.ReadLine();
						if (line is null)
						{
							break;
						}
						line = line.Trim();
						builder.Append(' ');
					}
					line = builder.ToString();
					writer.Write(verse);
					writer.Write(separator);
					writer.WriteLine(line);
					continue;
				}
				else
				{
					continue;
				}
			}
		}
	}

	private static void ParserBoMTitle(StreamWriter writer, ChaptersInfo info)
	{
		var book = info.Book;
		var html = client.GetStringAsync(info.URL).Result;
		using (var reader = new StringReader(html))
		{
			if (!GetStartsWith(reader, "<body"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<h4"))
			{
				return;
			}
			writer.WriteLine(book);
			if (!GetStartsWith(reader, "<h3"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<h4", out var line))
			{
				return;
			}
			line = ExtractH4(line);
			writer.Write(separator);
			writer.Write(line);
			if (!line.EndsWith('.'))
			{
				writer.Write('.');
			}
			writer.WriteLine();
			while (true)
			{
				line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				if (line.StartsWith("<p>"))
				{
					builder.Clear();
					line = line.Substring(3).Trim();
					while (true)
					{
						var ending = line.IndexOf("</p>");
						if (ending >= 0)
						{
							line = line.Substring(0, ending).Trim();
							builder.Append(line);
							break;
						}
						builder.Append(line);
						line = reader.ReadLine();
						if (line is null)
						{
							break;
						}
						line = line.Trim();
						builder.Append(' ');
					}
					line = builder.ToString();
					writer.Write(separator);
					writer.WriteLine(line);
				}
				else
				{
					continue;
				}
			}
		}
	}

	private static void Parser3Witnesses(StreamWriter writer, ChaptersInfo info)
	{
		writer.WriteLine(info.Book);
		writer.Write(separator);
		writer.WriteLine("Be it known unto all nations, kindreds, tongues, and people, unto whom this work shall come: That we, through the grace of God the Father, and our Lord Jesus Christ, have seen the plates which contain this record, which is a record of the people of Nephi, and also of the Lamanites, their brethren, and also of the people of Jared, who came from the tower of which hath been spoken. And we also know that they have been translated by the gift and power of God, for his voice hath declared it unto us; wherefore we know of a surety that the work is true. And we also testify that we have seen the engravings which are upon the plates; and they have been shown unto us by the power of God, and not of man. And we declare with words of soberness, that an angel of God came down from heaven, and he brought and laid before our eyes, that we beheld and saw the plates, and the engravings thereon; and we know that it is by the grace of God the Father, and our Lord Jesus Christ, that we beheld and bear record that these things are true. And it is marvelous in our eyes. Nevertheless, the voice of the Lord commanded us that we should bear record of it; wherefore, to be obedient unto the commandments of God, we bear testimony of these things. And we know that if we are faithful in Christ, we shall rid our garments of the blood of all men, and be found spotless before the judgment-seat of Christ, and shall dwell with him eternally in the heavens. And the honor be to the Father, and to the Son, and to the Holy Ghost, which is one God. Amen.");
		writer.Write(separator);
		writer.WriteLine("Oliver Cowdery, David Whitmer, Martin Harris");
	}

	private static void Parser8Witnesses(StreamWriter writer, ChaptersInfo info)
	{
		writer.WriteLine(info.Book);
		writer.Write(separator);
		writer.WriteLine("Be it known unto all nations, kindreds, tongues, and people, unto whom this work shall come: That Joseph Smith, Jun., the translator of this work, has shown unto us the plates of which hath been spoken, which have the appearance of gold; and as many of the leaves as the said Smith has translated we did handle with our hands; and we also saw the engravings thereon, all of which has the appearance of ancient work, and of curious workmanship. And this we bear record with words of soberness, that the said Smith has shown unto us, for we have seen and hefted, and know of a surety that the said Smith has got the plates of which we have spoken. And we give our names unto the world, to witness unto the world that which we have seen. And we lie not, God bearing witness of it.");
		writer.Write(separator);
		writer.WriteLine("Christian Whitmer, Jacob Whitmer, Peter Whitmer Jun, John Whitmer, Hiram Page, Joseph Smith Sen, Hyrum Smith, Samuel H. Smith");
	}

	private static void ParserBoMBookIntros(StreamWriter writer, ChaptersInfo info)
	{
		var book = info.Book;
		var html = client.GetStringAsync(info.URL).Result;
		using (var reader = new StringReader(html))
		{
			if (!GetStartsWith(reader, "<body"))
			{
				return;
			}
			if (!GetStartsWith(reader, "</header>"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<h2 class=\"Book"))
			{
				return;
			}
			string line;
			var intro = false;
			while (true)
			{
				line = reader.ReadLine();
				if (line is null)
				{
					return;
				}
				line = line.Trim();
				if (line.StartsWith("<a name=\"c"))
				{
					break;
				}
				else if (line.StartsWith("<p"))
				{
					builder.Clear();
					var gt = line.IndexOf('>');
					if (gt < 0)
					{
						continue;
					}
					line = line.Substring(gt + 1);
					while (true)
					{
						var ending = line.IndexOf("</p>");
						if (ending >= 0)
						{
							line = line.Substring(0, ending).Trim();
							builder.Append(line);
							break;
						}
						builder.Append(line);
						line = reader.ReadLine();
						if (line is null)
						{
							break;
						}
						line = line.Trim();
						builder.Append(' ');
					}
					if (!intro)
					{
						writer.WriteLine(book);
						intro = true;
					}
					line = builder.ToString();
					writer.Write(separator);
					writer.WriteLine(line);
					continue;
				}
				else
				{
					continue;
				}
			}
			if (intro)
			{
				writer.WriteLine();
			}
			var chapter = ExtractChapter(line);
			writer.Write(book);
			writer.Write(' ');
			writer.WriteLine(chapter);
			while (true)
			{
				line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				if (line.StartsWith("<a name=\"c"))
				{
					chapter = ExtractChapter(line);
					writer.WriteLine();
					writer.Write(book);
					writer.Write(' ');
					writer.WriteLine(chapter);
					continue;
				}
				else if (line.StartsWith("<a name=\"v"))
				{
					builder.Clear();
					var colon = line.IndexOf(':');
					if (colon < 0)
					{
						continue;
					}
					var verseOffset = colon + 1;
					var verseNext = verseOffset + 1;
					while (char.IsDigit(line[verseNext]))
					{
						++verseNext;
					}
					var verseLength = verseNext - verseOffset;
					var verse = line.Substring(verseOffset, verseLength);
					line = line.Substring(verseNext + 1);
					while (true)
					{
						var ending = line.IndexOf("</p></a>");
						if (ending >= 0)
						{
							line = line.Substring(0, ending).Trim();
							builder.Append(line);
							break;
						}
						builder.Append(line);
						line = reader.ReadLine();
						if (line is null)
						{
							break;
						}
						line = line.Trim();
						builder.Append(' ');
					}
					line = builder.ToString();
					writer.Write(verse);
					writer.Write(separator);
					writer.WriteLine(line);
					continue;
				}
				else
				{
					continue;
				}
			}
		}
	}

	private static void ParserBoMNoIntros(StreamWriter writer, ChaptersInfo info)
	{
		var book = info.Book;
		var html = client.GetStringAsync(info.URL).Result;
		using (var reader = new StringReader(html))
		{
			if (!GetStartsWith(reader, "<body"))
			{
				return;
			}
			if (!GetStartsWith(reader, "</header>"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<h2 class=\"Book"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<a name=\"c", out var line))
			{
				return;
			}
			var chapter = ExtractChapter(line);
			writer.Write(book);
			writer.Write(' ');
			writer.WriteLine(chapter);
			while (true)
			{
				line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				if (line.StartsWith("<a name=\"c"))
				{
					chapter = ExtractChapter(line);
					writer.WriteLine();
					writer.Write(book);
					writer.Write(' ');
					writer.WriteLine(chapter);
					continue;
				}
				else if (line.StartsWith("<a name=\"v"))
				{
					builder.Clear();
					var colon = line.IndexOf(':');
					if (colon < 0)
					{
						continue;
					}
					var verseOffset = colon + 1;
					var verseNext = verseOffset + 1;
					while (char.IsDigit(line[verseNext]))
					{
						++verseNext;
					}
					var verseLength = verseNext - verseOffset;
					var verse = line.Substring(verseOffset, verseLength);
					line = line.Substring(verseNext + 1);
					while (true)
					{
						var ending = line.IndexOf("</p></a>");
						if (ending >= 0)
						{
							line = line.Substring(0, ending).Trim();
							builder.Append(line);
							break;
						}
						builder.Append(line);
						line = reader.ReadLine();
						if (line is null)
						{
							break;
						}
						line = line.Trim();
						builder.Append(' ');
					}
					line = builder.ToString();
					writer.Write(verse);
					writer.Write(separator);
					writer.WriteLine(line);
					continue;
				}
				else
				{
					continue;
				}
			}
		}
	}

	private static void ParserMosiah(StreamWriter writer, ChaptersInfo info)
	{
		var book = info.Book;
		var html = client.GetStringAsync(info.URL).Result;
		using (var reader = new StringReader(html))
		{
			if (!GetStartsWith(reader, "<body"))
			{
				return;
			}
			if (!GetStartsWith(reader, "</header>"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<h2 class=\"Book"))
			{
				return;
			}
			var chapter = default(string);
			while (true)
			{
				var line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				if (line.StartsWith("<a name=\"c"))
				{
					if (chapter is not null)
					{
						writer.WriteLine();
					}
					chapter = ExtractChapter(line);
					writer.Write(book);
					writer.Write(' ');
					writer.WriteLine(chapter);
					continue;
				}
				else if (chapter is null)
				{
					continue;
				}
				else if (line.StartsWith("<a name=\"v"))
				{
					builder.Clear();
					var colon = line.IndexOf(':');
					if (colon < 0)
					{
						continue;
					}
					var verseOffset = colon + 1;
					var verseNext = verseOffset + 1;
					while (char.IsDigit(line[verseNext]))
					{
						++verseNext;
					}
					var verseLength = verseNext - verseOffset;
					var verse = line.Substring(verseOffset, verseLength);
					line = line.Substring(verseNext + 1);
					while (true)
					{
						var ending = line.IndexOf("</p></a>");
						if (ending >= 0)
						{
							line = line.Substring(0, ending).Trim();
							builder.Append(line);
							break;
						}
						builder.Append(line);
						line = reader.ReadLine();
						if (line is null)
						{
							break;
						}
						line = line.Trim();
						builder.Append(' ');
					}
					line = builder.ToString();
					writer.Write(verse);
					writer.Write(separator);
					writer.WriteLine(line);
					continue;
				}
				else if (line.StartsWith("<p class=\"Pcope"))
				{
					if (chapter == "6")
					{
						builder.Clear();
						var gt = line.IndexOf('>');
						if (gt < 0)
						{
							continue;
						}
						line = line.Substring(gt + 1);
						while (true)
						{
							var ending = line.IndexOf("</p>");
							if (ending >= 0)
							{
								line = line.Substring(0, ending).Trim();
								builder.Append(line);
								break;
							}
							builder.Append(line);
							line = reader.ReadLine();
							if (line is null)
							{
								break;
							}
							line = line.Trim();
							builder.Append(' ');
						}
						line = builder.ToString();
						writer.Write(separator);
						writer.WriteLine(line);
						continue;
					}
					else if(chapter == "11")
					{
						while (!line.EndsWith("</p>"))
						{
							line = reader.ReadLine();
							if (line is null)
							{
								break;
							}
							line = line.Trim();
						}
						writer.Write(separator);
						writer.WriteLine("An account of Alma and the people of the Lord, who were driven into the wilderness by the people of King Noah.");
						continue;
					}
					else
					{
						continue;
					}
				}
				else
				{
					continue;
				}
			}
		}
	}

	private static void ParserAlma(StreamWriter writer, ChaptersInfo info)
	{
		var intros = new Dictionary<string, string>()
		{
			{ "3", "The words which Alma, the high priest, according to the holy order of God, delivered to the people in their cities and villages throughout the land." },
			{ "5", "The words of Alma which he delivered to the people in Gideon, according to his own record." },
			{ "7", "The words of Alma and also the words of Amulek, which were declared unto the people who were in the land of Ammonihah. And also they are cast into prison and delivered by the miraculous power of God which was in them, according to the record of Alma." },
			{ "12", "An account of the sons of Mosiah, who rejected their rights to the kingdom for the word of God and went up to the land of Nephi to preach to the Lamanites. Their sufferings and deliverance, according to the record of Alma." },
			{ "17", "The commandments of Alma to his son Helaman." },
			{ "18", "The commandments of Alma to his son Shiblon." },
			{ "19", "The commandments of Alma to his son Corianton." },
			{ "21", "The account of the people of Nephi, and their wars and dissensions, in the days of Helaman, according to the record of Helaman, which he kept in his days." },
		};
		var book = info.Book;
		var html = client.GetStringAsync(info.URL).Result;
		using (var reader = new StringReader(html))
		{
			if (!GetStartsWith(reader, "<body"))
			{
				return;
			}
			if (!GetStartsWith(reader, "</header>"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<h2 class=\"Book"))
			{
				return;
			}
			writer.WriteLine(book);
			writer.Write(separator);
			writer.WriteLine("THE SON OF ALMA.");
			writer.Write(separator);
			writer.WriteLine("The account of Alma, who was the son of Alma, the first and chief judge over the people of Nephi, and also the high priest over the church. An account of the reign of the judges and the wars and contentions among the people. And also an account of a war between the Nephites and the Lamanites, according to the record of Alma, the first and chief judge.");
			var chapter = default(string);
			while (true)
			{
				var line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				if (line.StartsWith("<a name=\"c"))
				{
					writer.WriteLine();
					chapter = ExtractChapter(line);
					writer.Write(book);
					writer.Write(' ');
					writer.WriteLine(chapter);
					continue;
				}
				else if (chapter is null)
				{
					continue;
				}
				else if (line.StartsWith("<a name=\"v"))
				{
					builder.Clear();
					var colon = line.IndexOf(':');
					if (colon < 0)
					{
						continue;
					}
					var verseOffset = colon + 1;
					var verseNext = verseOffset + 1;
					while (char.IsDigit(line[verseNext]))
					{
						++verseNext;
					}
					var verseLength = verseNext - verseOffset;
					var verse = line.Substring(verseOffset, verseLength);
					line = line.Substring(verseNext + 1);
					while (true)
					{
						var ending = line.IndexOf("</p></a>");
						if (ending >= 0)
						{
							line = line.Substring(0, ending).Trim();
							builder.Append(line);
							break;
						}
						builder.Append(line);
						line = reader.ReadLine();
						if (line is null)
						{
							break;
						}
						line = line.Trim();
						builder.Append(' ');
					}
					line = builder.ToString();
					writer.Write(verse);
					writer.Write(separator);
					writer.WriteLine(line);
					continue;
				}
				else if (line.StartsWith("<p class=\"Pcope"))
				{
					if (intros.Remove(chapter, out var intro))
					{
						while (!line.EndsWith("</p>"))
						{
							line = reader.ReadLine();
							if (line is null)
							{
								break;
							}
							line = line.Trim();
						}
						writer.Write(separator);
						writer.WriteLine(intro);
						continue;
					}
					else
					{
						continue;
					}
				}
				else
				{
					continue;
				}
			}
		}
	}

	private static void ParserHelaman(StreamWriter writer, ChaptersInfo info)
	{
		var intross = new Dictionary<string, string[]>()
		{
			{ "3", new string[]
				{
					"THE PROPHECY OF NEPHI, THE SON OF HELAMAN",
					"God threatens the people of Nephi that he will visit them in his anger, to their utter destruction, except they repent of their wickedness. God smiteth the people of Nephi with pestilence; they repent and turn unto him. Samuel, a Lamanite, prophesies unto the Nephites.",
				} },
			{ "5", new string[]
				{
					"The prophecy of Samuel the Lamanite to the Nephites.",
				} },
		};
		var book = info.Book;
		var html = client.GetStringAsync(info.URL).Result;
		using (var reader = new StringReader(html))
		{
			if (!GetStartsWith(reader, "<body"))
			{
				return;
			}
			if (!GetStartsWith(reader, "</header>"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<h2 class=\"Book"))
			{
				return;
			}
			writer.WriteLine(book);
			writer.Write(separator);
			writer.WriteLine("An account of the Nephites, their wars and contentions, and their dissensions. And also the prophecies of many holy prophets before the coming of Christ, according to the record of Helaman, who was the son of Helaman, and also according to the records of his sons, even down to the coming of Christ. And also many of the Lamanites are converted. An account of their conversion. An account of the righteousness of the Lamanites, and the wickedness and abominations of the Nephites, according to the record of Helaman and his sons, even down to the coming of Christ, which is called the book of Helaman.");
			var chapter = default(string);
			while (true)
			{
				var line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				if (line.StartsWith("<a name=\"c"))
				{
					writer.WriteLine();
					chapter = ExtractChapter(line);
					writer.Write(book);
					writer.Write(' ');
					writer.WriteLine(chapter);
					continue;
				}
				else if (chapter is null)
				{
					continue;
				}
				else if (line.StartsWith("<a name=\"v"))
				{
					builder.Clear();
					var colon = line.IndexOf(':');
					if (colon < 0)
					{
						continue;
					}
					var verseOffset = colon + 1;
					var verseNext = verseOffset + 1;
					while (char.IsDigit(line[verseNext]))
					{
						++verseNext;
					}
					var verseLength = verseNext - verseOffset;
					var verse = line.Substring(verseOffset, verseLength);
					line = line.Substring(verseNext + 1);
					while (true)
					{
						var ending = line.IndexOf("</p></a>");
						if (ending >= 0)
						{
							line = line.Substring(0, ending).Trim();
							builder.Append(line);
							break;
						}
						builder.Append(line);
						line = reader.ReadLine();
						if (line is null)
						{
							break;
						}
						line = line.Trim();
						builder.Append(' ');
					}
					line = builder.ToString();
					writer.Write(verse);
					writer.Write(separator);
					writer.WriteLine(line);
					continue;
				}
				else if (line.StartsWith("<p class=\"Pcope"))
				{
					if (intross.Remove(chapter, out var intros))
					{
						while (!line.EndsWith("</p>"))
						{
							line = reader.ReadLine();
							if (line is null)
							{
								break;
							}
							line = line.Trim();
						}
						foreach (var intro in intros)
						{
							writer.Write(separator);
							writer.WriteLine(intro);
						}
						continue;
					}
					else
					{
						continue;
					}
				}
				else
				{
					continue;
				}
			}
		}
	}

	private static void Parser3Nephi(StreamWriter writer, ChaptersInfo info)
	{
		var intros = new Dictionary<string, string>()
		{
			{ "5", "Jesus Christ showeth himself unto the people of Nephi, as the multitude were gathered together in the land Bountiful, and did minister unto them; and on this wise did he show himself unto them." },
		};
		var book = info.Book;
		var html = client.GetStringAsync(info.URL).Result;
		using (var reader = new StringReader(html))
		{
			if (!GetStartsWith(reader, "<body"))
			{
				return;
			}
			if (!GetStartsWith(reader, "</header>"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<h2 class=\"Book"))
			{
				return;
			}
			writer.WriteLine(book);
			writer.Write(separator);
			writer.WriteLine("THE SON OF NEPHI, WHO WAS THE SON OF HELAMAN.");
			writer.Write(separator);
			writer.WriteLine("And Helaman was the son of Helaman, who was the son of Alma, who was the son of Alma, being a descendant of Nephi, who was the son of Lehi, who came out of Jerusalem in the first year of the reign of Zedekiah, the king of Judah.");
			var chapter = default(string);
			while (true)
			{
				var line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				if (line.StartsWith("<a name=\"c"))
				{
					writer.WriteLine();
					chapter = ExtractChapter(line);
					writer.Write(book);
					writer.Write(' ');
					writer.WriteLine(chapter);
					continue;
				}
				else if (chapter is null)
				{
					continue;
				}
				else if (line.StartsWith("<a name=\"v"))
				{
					builder.Clear();
					var colon = line.IndexOf(':');
					if (colon < 0)
					{
						continue;
					}
					var verseOffset = colon + 1;
					var verseNext = verseOffset + 1;
					while (char.IsDigit(line[verseNext]))
					{
						++verseNext;
					}
					var verseLength = verseNext - verseOffset;
					var verse = line.Substring(verseOffset, verseLength);
					line = line.Substring(verseNext + 1);
					while (true)
					{
						var ending = line.IndexOf("</p></a>");
						if (ending >= 0)
						{
							line = line.Substring(0, ending).Trim();
							builder.Append(line);
							break;
						}
						builder.Append(line);
						line = reader.ReadLine();
						if (line is null)
						{
							break;
						}
						line = line.Trim();
						builder.Append(' ');
					}
					line = builder.ToString();
					writer.Write(verse);
					writer.Write(separator);
					writer.WriteLine(line);
					continue;
				}
				else if (line.StartsWith("<p class=\"Pcope"))
				{
					if (intros.Remove(chapter, out var intro))
					{
						while (!line.EndsWith("</p>"))
						{
							line = reader.ReadLine();
							if (line is null)
							{
								break;
							}
							line = line.Trim();
						}
						writer.Write(separator);
						writer.WriteLine(intro);
						continue;
					}
					else
					{
						continue;
					}
				}
				else
				{
					continue;
				}
			}
		}
	}

	private static void Parser4Nephi(StreamWriter writer, ChaptersInfo info)
	{
		var book = info.Book;
		var html = client.GetStringAsync(info.URL).Result;
		using (var reader = new StringReader(html))
		{
			if (!GetStartsWith(reader, "<body"))
			{
				return;
			}
			if (!GetStartsWith(reader, "</header>"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<h2 class=\"Book"))
			{
				return;
			}
			writer.WriteLine(book);
			writer.Write(separator);
			writer.WriteLine("WHO IS THE SON OF NEPHI, ONE OF THE DISCIPLES OF JESUS CHRIST.");
			writer.Write(separator);
			writer.WriteLine("An account of the people of Nephi, according to his record.");
			var chapter = default(string);
			while (true)
			{
				var line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				if (line.StartsWith("<a name=\"c"))
				{
					writer.WriteLine();
					chapter = ExtractChapter(line);
					writer.Write(book);
					writer.Write(' ');
					writer.WriteLine(chapter);
					continue;
				}
				else if (chapter is null)
				{
					continue;
				}
				else if (line.StartsWith("<a name=\"v"))
				{
					builder.Clear();
					var colon = line.IndexOf(':');
					if (colon < 0)
					{
						continue;
					}
					var verseOffset = colon + 1;
					var verseNext = verseOffset + 1;
					while (char.IsDigit(line[verseNext]))
					{
						++verseNext;
					}
					var verseLength = verseNext - verseOffset;
					var verse = line.Substring(verseOffset, verseLength);
					line = line.Substring(verseNext + 1);
					while (true)
					{
						var ending = line.IndexOf("</p></a>");
						if (ending >= 0)
						{
							line = line.Substring(0, ending).Trim();
							builder.Append(line);
							break;
						}
						builder.Append(line);
						line = reader.ReadLine();
						if (line is null)
						{
							break;
						}
						line = line.Trim();
						builder.Append(' ');
					}
					line = builder.ToString();
					writer.Write(verse);
					writer.Write(separator);
					writer.WriteLine(line);
					continue;
				}
				else
				{
					continue;
				}
			}
		}
	}

	private static void ParserMoroni(StreamWriter writer, ChaptersInfo info)
	{
		var intros = new Dictionary<string, string>()
		{
			{ "9", "The second epistle of Mormon to his son Moroni." },
		};
		var book = info.Book;
		var html = client.GetStringAsync(info.URL).Result;
		using (var reader = new StringReader(html))
		{
			if (!GetStartsWith(reader, "<body"))
			{
				return;
			}
			if (!GetStartsWith(reader, "</header>"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<h2 class=\"Book"))
			{
				return;
			}
			var chapter = default(string);
			while (true)
			{
				var line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				if (line.StartsWith("<a name=\"c"))
				{
					if (chapter is not null)
					{
						writer.WriteLine();
					}
					chapter = ExtractChapter(line);
					writer.Write(book);
					writer.Write(' ');
					writer.WriteLine(chapter);
					continue;
				}
				else if (chapter is null)
				{
					continue;
				}
				else if (line.StartsWith("<a name=\"v"))
				{
					builder.Clear();
					var colon = line.IndexOf(':');
					if (colon < 0)
					{
						continue;
					}
					var verseOffset = colon + 1;
					var verseNext = verseOffset + 1;
					while (char.IsDigit(line[verseNext]))
					{
						++verseNext;
					}
					var verseLength = verseNext - verseOffset;
					var verse = line.Substring(verseOffset, verseLength);
					line = line.Substring(verseNext + 1);
					while (true)
					{
						var ending = line.IndexOf("</p></a>");
						if (ending >= 0)
						{
							line = line.Substring(0, ending).Trim();
							builder.Append(line);
							break;
						}
						builder.Append(line);
						line = reader.ReadLine();
						if (line is null)
						{
							break;
						}
						line = line.Trim();
						builder.Append(' ');
					}
					line = builder.ToString();
					writer.Write(verse);
					writer.Write(separator);
					writer.WriteLine(line);
					continue;
				}
				else if (line.StartsWith("<p class=\"Pcope"))
				{
					if (intros.Remove(chapter, out var intro))
					{
						while (!line.EndsWith("</p>"))
						{
							line = reader.ReadLine();
							if (line is null)
							{
								break;
							}
							line = line.Trim();
						}
						writer.Write(separator);
						writer.WriteLine(intro);
						continue;
					}
					else
					{
						continue;
					}
				}
				else
				{
					continue;
				}
			}
		}
	}

	private static void ParserDnC(StreamWriter writer, ChaptersInfo info)
	{
		var book = info.Book;
		var html = client.GetStringAsync(info.URL).Result;
		using (var reader = new StringReader(html))
		{
			if (!GetStartsWith(reader, "<body"))
			{
				return;
			}
			if (!GetStartsWith(reader, "</header>"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<h2 class=\"Book"))
			{
				return;
			}
			writer.WriteLine(book);
			while (true)
			{
				var line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				if (line.StartsWith("<a name=\"v"))
				{
					builder.Clear();
					var colon = line.IndexOf(':');
					if (colon < 0)
					{
						continue;
					}
					var verseOffset = colon + 1;
					var verseNext = verseOffset + 1;
					while (!char.IsWhiteSpace(line[verseNext]))
					{
						++verseNext;
					}
					var verseLength = verseNext - verseOffset;
					var verse = line.Substring(verseOffset, verseLength);
					line = line.Substring(verseNext + 1);
					while (true)
					{
						var ending = line.IndexOf("</p></a>");
						if (ending >= 0)
						{
							line = line.Substring(0, ending).Trim();
							builder.Append(line);
							break;
						}
						builder.Append(line);
						line = reader.ReadLine();
						if (line is null)
						{
							break;
						}
						line = line.Trim();
						builder.Append(' ');
					}
					line = builder.ToString();
					writer.Write(verse);
					writer.Write(separator);
					writer.WriteLine(line);
					continue;
				}
				else
				{
					continue;
				}
			}
		}
	}

	private static bool GetStartsWith(StringReader reader, string text)
	{
		while (true)
		{
			var line = reader.ReadLine();
			if (line is null)
			{
				return false;
			}
			line = line.Trim();
			if (line.StartsWith(text))
			{
				return true;
			}
		}
	}

	private static bool GetStartsWith(StringReader reader, string text, out string value)
	{
		while (true)
		{
			var line = reader.ReadLine();
			if (line is null)
			{
				value = null;
				return false;
			}
			line = line.Trim();
			if (line.StartsWith(text))
			{
				value = line;
				return true;
			}
		}
	}

	private static string ExtractChapter(string line)
	{
		const string search = ">Chapter ";
		var index = line.IndexOf(search);
		if (index < 0)
		{
			return null;
		}
		var offset = index + search.Length;
		var ending = line.IndexOf('<', offset);
		if (ending < 0)
		{
			return null;
		}
		var length = ending - offset;
		var value = line.Substring(offset, length);
		return value;
	}

	private static string ExtractH4(string line)
	{
		var index = line.IndexOf('>');
		if (index < 0 )
		{
			return null;
		}
		var offset = index + 1;
		var ending = line.IndexOf('<', offset);
		if (ending < 0)
		{
			return null;
		}
		var length = ending - offset;
		var value = line.Substring(offset, length);
		return value;
	}
}

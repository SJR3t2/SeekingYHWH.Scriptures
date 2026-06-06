using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace SeekingYHWH.Scriptures.Search.OpenBible;

//https://openbible.com/
internal static class Program
{
	private const char writerSeparator = '\t';

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
	private static readonly HashSet<string> ot = new HashSet<string>();
	private static readonly HashSet<string> nt = new HashSet<string>();
	private static readonly BooksInfo[] bookss = new BooksInfo[]
	{
		new BooksInfo() { URL = "https://bereanbible.com/bsb.txt", Books = new BookInfo[]
		{
			new BookInfo() { Code = "OT-BSB", Name = "Old Testament - BSB", Pre = "BSB", Chapters = ot, },
			new BookInfo() { Code = "NT-BSB", Name = "New Testament - BSB", Pre = "BSB", Chapters = nt, },
		}, },
		new BooksInfo() { URL = "https://openbible.com/textfiles/jps.txt", Books = new BookInfo[]
		{
			new BookInfo() { Code = "OT-JPS", Name = "Old Testament - JPS", Pre = "JPS", Chapters = ot, },
		}, },
	};

	private static HttpClient client;
	private static string languagePath;

	private static readonly char[] readerSeparator = new char[] { '\t', };
	private static readonly char[] verserSeparotor = new char[] { ':', };

	private static List<string> ParseCommandLine(string[] args)
	{
		return null;
	}

	private static void PrintHelp(List<string> errors)
	{
		Console.WriteLine();
		Console.WriteLine("SeekingYHWH.Scriptures.Search.OpenBible.exe");
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
		Console.Title = "SeekingYHWH.Scriptures.Search.OpenBible";

		PrepareOT();
		PrepareNT();
		PrepareClient();
		PrepareLanguagePath();

		GC.Collect();
	}

	private static void PrepareOT()
	{
		PrepareChapters(ot, "Genesis", 50);
		PrepareChapters(ot, "Exodus", 40);
		PrepareChapters(ot, "Leviticus", 27);
		PrepareChapters(ot, "Numbers", 36);
		PrepareChapters(ot, "Deuteronomy", 34);
		PrepareChapters(ot, "Joshua", 24);
		PrepareChapters(ot, "Judges", 21);
		PrepareChapters(ot, "Ruth", 4);
		PrepareChapters(ot, "1 Samuel", 31);
		PrepareChapters(ot, "2 Samuel", 24);
		PrepareChapters(ot, "1 Kings", 22);
		PrepareChapters(ot, "2 Kings", 25);
		PrepareChapters(ot, "1 Chronicles", 29);
		PrepareChapters(ot, "2 Chronicles", 36);
		PrepareChapters(ot, "Ezra", 10);
		PrepareChapters(ot, "Nehemiah", 13);
		PrepareChapters(ot, "Job", 42);
		PrepareChapters(ot, "Psalm", 150);
		PrepareChapters(ot, "Proverbs", 31);
		PrepareChapters(ot, "Ecclesiastes", 12);
		PrepareChapters(ot, "Isaiah", 66);
		PrepareChapters(ot, "Jeremiah", 52);
		PrepareChapters(ot, "Lamentations", 5);
		PrepareChapters(ot, "Ezekiel", 48);
		PrepareChapters(ot, "Daniel", 12);
		PrepareChapters(ot, "Hosea", 14);
		PrepareChapters(ot, "Joel", 3);
		PrepareChapters(ot, "Amos", 9);
		PrepareChapters(ot, "Obadiah", 1);
		PrepareChapters(ot, "Jonah", 4);
		PrepareChapters(ot, "Micah", 7);
		PrepareChapters(ot, "Nahum", 3);
		PrepareChapters(ot, "Habakkuk", 3);
		PrepareChapters(ot, "Zephaniah", 3);
		PrepareChapters(ot, "Haggai", 2);
		PrepareChapters(ot, "Zechariah", 14);
		PrepareChapters(ot, "Malachi", 4);
	}

	private static void PrepareNT()
	{
		PrepareChapters(nt, "Matthew", 28);
		PrepareChapters(nt, "Mark", 16);
		PrepareChapters(nt, "Luke", 24);
		PrepareChapters(nt, "John", 21);
		PrepareChapters(nt, "Acts", 28);
		PrepareChapters(nt, "Romans", 16);
		PrepareChapters(nt, "1 Corinthians", 16);
		PrepareChapters(nt, "2 Corinthians", 13);
		PrepareChapters(nt, "Galatians", 6);
		PrepareChapters(nt, "Ephesians", 6);
		PrepareChapters(nt, "Philippians", 4);
		PrepareChapters(nt, "Colossians", 4);
		PrepareChapters(nt, "1 Thessalonians", 5);
		PrepareChapters(nt, "2 Thessalonians", 3);
		PrepareChapters(nt, "1 Timothy", 6);
		PrepareChapters(nt, "2 Timothy", 4);
		PrepareChapters(nt, "Titus", 3);
		PrepareChapters(nt, "Philemon", 1);
		PrepareChapters(nt, "Hebrews", 13);
		PrepareChapters(nt, "James", 5);
		PrepareChapters(nt, "1 Peter", 5);
		PrepareChapters(nt, "2 Peter", 3);
		PrepareChapters(nt, "1 John", 5);
		PrepareChapters(nt, "2 John", 1);
		PrepareChapters(nt, "3 John", 1);
		PrepareChapters(nt, "Jude", 1);
		PrepareChapters(nt, "Revelation", 22);
	}

	private static void PrepareChapters(HashSet<string> chapters, string pre, int last)
	{
		for (var i = 1; i <= last; ++i)
		{
			var chapter = pre + " " + i.ToString();
			chapters.Add(chapter);
		}
	}

	private static void PrepareClient()
	{
		var handler = new HttpClientHandler()
		{
			AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
		};
		client = new HttpClient(handler);
		var headers = client.DefaultRequestHeaders;
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
		var books = new List<BookInfo>();
		foreach (var info in bookss)
		{
			Console.WriteLine(info.URL);
			ProcessTabbed(info);
			books.AddRange(info.Books);
		}
		Books.Update(languagePath, books);
		return 0;
	}

	private static void ProcessTabbed(BooksInfo info)
	{
		var books = new List<Processing>();
		var chapters = new Dictionary<string, Processing>();
		var reader = default(StringReader);
		try
		{
			var html = client.GetStringAsync(info.URL).Result;
			reader = new StringReader(html);

			foreach (var book in info.Books)
			{
				Console.WriteLine(book.Code);
				var path = Path.Combine(languagePath, book.Code + ".tsv.br");
				var writerFile = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
				var writerStream = new BrotliStream(writerFile, CompressionLevel.SmallestSize);
				var writer = new StreamWriter(writerStream);
				var processing = new Processing(book, path, writerFile, writerStream, writer);
				books.Add(processing);
				foreach (var chapter in book.Chapters)
				{
					chapters.Add(chapter, processing);
				}
			}

			while (true)
			{
				var line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				var columns = line.Split(readerSeparator, StringSplitOptions.None);
				if (columns.Length != 2)
				{
					//Console.Error.WriteLine(line);
					continue;
				}
				var cv = columns[0].Trim();
				var text = columns[1].Trim();
				columns = cv.Split(verserSeparotor, StringSplitOptions.None);
				if (columns.Length != 2)
				{
					//Console.Error.WriteLine(line);
					continue;
				}
				var chapter = columns[0].Trim();
				var verse = columns[1].Trim();
				if (!chapters.TryGetValue(chapter, out var processing))
				{
					//Console.Error.WriteLine(line);
					continue;
				}
				var writer = processing.Writer;
				if (processing.Chapter is null)
				{
					writer.WriteLine(chapter);
					processing.Chapter = chapter;
				}
				else if (chapter != processing.Chapter)
				{
					writer.WriteLine();
					writer.WriteLine(chapter);
					processing.Chapter = chapter;
				}
				writer.Write(verse);
				writer.Write(writerSeparator);
				writer.WriteLine(text);
			}
		}
		finally
		{
			foreach (var processing in books)
			{
				processing.Dispose();
			}
			reader?.Dispose();
		}
		foreach (var processing in books)
		{
			byte[] hash;
			using (var readerFile = new FileStream(processing.Path, FileMode.Open, FileAccess.Read, FileShare.Read))
			using (var readerStream = new BrotliStream(readerFile, CompressionMode.Decompress))
			using (var hasher = SHA256.Create())
			{
				hash = hasher.ComputeHash(readerStream);
			}
			var hashPath = Path.Combine(languagePath, processing.Book.Code + ".tsv.hsh");
			using (var writerFile = new FileStream(hashPath, FileMode.Create, FileAccess.Write, FileShare.Read))
			{
				writerFile.Write(hash, 0, hash.Length);
			}
		}
	}
}

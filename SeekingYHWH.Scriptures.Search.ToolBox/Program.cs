using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace SeekingYHWH.Scriptures.Search.ToolBox;

//http://www.scripturetoolbox.com/
internal static class Program
{
	private const string schema = "http";
	private const string host = "www.scripturetoolbox.com";
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
	private static BookInfo[] books = new BookInfo[]
	{
		new BookInfo() { Code = "BoM-RCE", Name = "Book of Mormon - RCE", Pre = "RCE", Chapters = new ChapterInfo[]
		{
			new ChapterInfo("Book of Mormon Title Page", "html/rcebom/TitlePage/1.html", ParserBoM),
			new ChapterInfo("Testimony of Three Witnesses", "Testimony of Three Witnesses", ParserBoM3Witnesses),
			new ChapterInfo("Testimony of Eight Witnesses", "Testimony of Eight Witnesses", ParserBoM8Witnesses),
			new ChapterInfo("1 Nephi 1", "html/rcebom/1Nephi/1.html", ParserBoM),
			new ChapterInfo("1 Nephi 2", "html/rcebom/1Nephi/2.html", ParserBoM),
			new ChapterInfo("1 Nephi 3", "html/rcebom/1Nephi/3.html", ParserBoM),
			new ChapterInfo("1 Nephi 4", "html/rcebom/1Nephi/4.html", ParserBoM),
			new ChapterInfo("1 Nephi 5", "html/rcebom/1Nephi/5.html", ParserBoM),
			new ChapterInfo("1 Nephi 6", "html/rcebom/1Nephi/6.html", ParserBoM),
			new ChapterInfo("1 Nephi 7", "html/rcebom/1Nephi/7.html", ParserBoM),
			new ChapterInfo("2 Nephi 1", "html/rcebom/2Nephi/1.html", ParserBoM),
			new ChapterInfo("2 Nephi 2", "html/rcebom/2Nephi/2.html", ParserBoM),
			new ChapterInfo("2 Nephi 3", "html/rcebom/2Nephi/3.html", ParserBoM),
			new ChapterInfo("2 Nephi 4", "html/rcebom/2Nephi/4.html", ParserBoM),
			new ChapterInfo("2 Nephi 5", "html/rcebom/2Nephi/5.html", ParserBoM),
			new ChapterInfo("2 Nephi 6", "html/rcebom/2Nephi/6.html", ParserBoM),
			new ChapterInfo("2 Nephi 7", "html/rcebom/2Nephi/7.html", ParserBoM),
			new ChapterInfo("2 Nephi 8", "html/rcebom/2Nephi/8.html", ParserBoM),
			new ChapterInfo("2 Nephi 9", "html/rcebom/2Nephi/9.html", ParserBoM),
			new ChapterInfo("2 Nephi 10", "html/rcebom/2Nephi/10.html", ParserBoM),
			new ChapterInfo("2 Nephi 11", "html/rcebom/2Nephi/11.html", ParserBoM),
			new ChapterInfo("2 Nephi 12", "html/rcebom/2Nephi/12.html", ParserBoM),
			new ChapterInfo("2 Nephi 13", "html/rcebom/2Nephi/13.html", ParserBoM),
			new ChapterInfo("2 Nephi 14", "html/rcebom/2Nephi/14.html", ParserBoM),
			new ChapterInfo("2 Nephi 15", "html/rcebom/2Nephi/15.html", ParserBoM),
			new ChapterInfo("Jacob 1", "html/rcebom/Jacob/1.html", ParserBoM),
			new ChapterInfo("Jacob 2", "html/rcebom/Jacob/2.html", ParserBoM),
			new ChapterInfo("Jacob 3", "html/rcebom/Jacob/3.html", ParserBoM),
			new ChapterInfo("Jacob 4", "html/rcebom/Jacob/4.html", ParserBoM),
			new ChapterInfo("Jacob 5", "html/rcebom/Jacob/5.html", ParserBoM),
			new ChapterInfo("Enos 1", "html/rcebom/Enos/1.html", ParserBoM),
			new ChapterInfo("Jarom 1", "html/rcebom/Jarom/1.html", ParserBoM),
			new ChapterInfo("Omni 1", "html/rcebom/Omni/1.html", ParserBoM),
			new ChapterInfo("Words of Mormon 1", "html/rcebom/WordsofMormon/1.html", ParserBoM),
			new ChapterInfo("Mosiah 1", "html/rcebom/Mosiah/1.html", ParserBoM),
			new ChapterInfo("Mosiah 2", "html/rcebom/Mosiah/2.html", ParserBoM),
			new ChapterInfo("Mosiah 3", "html/rcebom/Mosiah/3.html", ParserBoM),
			new ChapterInfo("Mosiah 4", "html/rcebom/Mosiah/4.html", ParserBoM),
			new ChapterInfo("Mosiah 5", "html/rcebom/Mosiah/5.html", ParserBoM),
			new ChapterInfo("Mosiah 6", "html/rcebom/Mosiah/6.html", ParserBoM),//remove ending s in intro
			new ChapterInfo("Mosiah 7", "html/rcebom/Mosiah/7.html", ParserBoM),
			new ChapterInfo("Mosiah 8", "html/rcebom/Mosiah/8.html", ParserBoM),
			new ChapterInfo("Mosiah 9", "html/rcebom/Mosiah/9.html", ParserBoM),
			new ChapterInfo("Mosiah 10", "html/rcebom/Mosiah/10.html", ParserBoM),
			new ChapterInfo("Mosiah 11", "html/rcebom/Mosiah/11.html", ParserBoM),//add space in thepeople
			new ChapterInfo("Mosiah 12", "html/rcebom/Mosiah/12.html", ParserBoM),
			new ChapterInfo("Mosiah 13", "html/rcebom/Mosiah/13.html", ParserBoM),
			new ChapterInfo("Alma 1", "html/rcebom/Alma/1.html", ParserBoM),
			new ChapterInfo("Alma 2", "html/rcebom/Alma/2.html", ParserBoM),
			new ChapterInfo("Alma 3", "html/rcebom/Alma/3.html", ParserBoM),
			new ChapterInfo("Alma 4", "html/rcebom/Alma/4.html", ParserBoM),
			new ChapterInfo("Alma 5", "html/rcebom/Alma/5.html", ParserBoM),
			new ChapterInfo("Alma 6", "html/rcebom/Alma/6.html", ParserBoM),
			new ChapterInfo("Alma 7", "html/rcebom/Alma/7.html", ParserBoM),
			new ChapterInfo("Alma 8", "html/rcebom/Alma/8.html", ParserBoM),
			new ChapterInfo("Alma 9", "html/rcebom/Alma/9.html", ParserBoM),
			new ChapterInfo("Alma 10", "html/rcebom/Alma/10.html", ParserBoM),
			new ChapterInfo("Alma 11", "html/rcebom/Alma/11.html", ParserBoM),
			new ChapterInfo("Alma 12", "html/rcebom/Alma/12.html", ParserBoM),//add space in theirrights
			new ChapterInfo("Alma 13", "html/rcebom/Alma/13.html", ParserBoM),
			new ChapterInfo("Alma 14", "html/rcebom/Alma/14.html", ParserBoM),
			new ChapterInfo("Alma 15", "html/rcebom/Alma/15.html", ParserBoM),
			new ChapterInfo("Alma 16", "html/rcebom/Alma/16.html", ParserBoM),
			new ChapterInfo("Alma 17", "html/rcebom/Alma/17.html", ParserBoM),
			new ChapterInfo("Alma 18", "html/rcebom/Alma/18.html", ParserBoM),
			new ChapterInfo("Alma 19", "html/rcebom/Alma/19.html", ParserBoM),
			new ChapterInfo("Alma 20", "html/rcebom/Alma/20.html", ParserBoM),
			new ChapterInfo("Alma 21", "html/rcebom/Alma/21.html", ParserBoM),
			new ChapterInfo("Alma 22", "html/rcebom/Alma/22.html", ParserBoM),
			new ChapterInfo("Alma 23", "html/rcebom/Alma/23.html", ParserBoM),
			new ChapterInfo("Alma 24", "html/rcebom/Alma/24.html", ParserBoM),
			new ChapterInfo("Alma 25", "html/rcebom/Alma/25.html", ParserBoM),
			new ChapterInfo("Alma 26", "html/rcebom/Alma/26.html", ParserBoM),
			new ChapterInfo("Alma 27", "html/rcebom/Alma/27.html", ParserBoM),
			new ChapterInfo("Alma 28", "html/rcebom/Alma/28.html", ParserBoM),
			new ChapterInfo("Alma 29", "html/rcebom/Alma/29.html", ParserBoM),
			new ChapterInfo("Alma 30", "html/rcebom/Alma/30.html", ParserBoM),
			new ChapterInfo("Helaman 1", "html/rcebom/Helaman/1.html", ParserBoM),
			new ChapterInfo("Helaman 2", "html/rcebom/Helaman/2.html", ParserBoM),
			new ChapterInfo("Helaman 3", "html/rcebom/Helaman/3.html", ParserBoM),
			new ChapterInfo("Helaman 4", "html/rcebom/Helaman/4.html", ParserBoM),
			new ChapterInfo("Helaman 5", "html/rcebom/Helaman/5.html", ParserBoM),
			new ChapterInfo("3 Nephi 1", "html/rcebom/3Nephi/1.html", ParserBoM),
			new ChapterInfo("3 Nephi 2", "html/rcebom/3Nephi/2.html", ParserBoM),
			new ChapterInfo("3 Nephi 3", "html/rcebom/3Nephi/3.html", ParserBoM),
			new ChapterInfo("3 Nephi 4", "html/rcebom/3Nephi/4.html", ParserBoM),
			new ChapterInfo("3 Nephi 5", "html/rcebom/3Nephi/5.html", ParserBoM),
			new ChapterInfo("3 Nephi 6", "html/rcebom/3Nephi/6.html", ParserBoM),
			new ChapterInfo("3 Nephi 7", "html/rcebom/3Nephi/7.html", ParserBoM),
			new ChapterInfo("3 Nephi 8", "html/rcebom/3Nephi/8.html", ParserBoM),
			new ChapterInfo("3 Nephi 9", "html/rcebom/3Nephi/9.html", ParserBoM),
			new ChapterInfo("3 Nephi 10", "html/rcebom/3Nephi/10.html", ParserBoM),
			new ChapterInfo("3 Nephi 11", "html/rcebom/3Nephi/11.html", ParserBoM),
			new ChapterInfo("3 Nephi 12", "html/rcebom/3Nephi/12.html", ParserBoM),
			new ChapterInfo("3 Nephi 13", "html/rcebom/3Nephi/13.html", ParserBoM),
			new ChapterInfo("3 Nephi 14", "html/rcebom/3Nephi/14.html", ParserBoM),
			new ChapterInfo("4 Nephi 1", "html/rcebom/4Nephi/1.html", ParserBoM),
			new ChapterInfo("Mormon 1", "html/rcebom/Mormon/1.html", ParserBoM),
			new ChapterInfo("Mormon 2", "html/rcebom/Mormon/2.html", ParserBoM),
			new ChapterInfo("Mormon 3", "html/rcebom/Mormon/3.html", ParserBoM),
			new ChapterInfo("Mormon 4", "html/rcebom/Mormon/4.html", ParserBoM),
			new ChapterInfo("Ether 1", "html/rcebom/Ether/1.html", ParserBoM),
			new ChapterInfo("Ether 2", "html/rcebom/Ether/2.html", ParserBoM),
			new ChapterInfo("Ether 3", "html/rcebom/Ether/3.html", ParserBoM),
			new ChapterInfo("Ether 4", "html/rcebom/Ether/4.html", ParserBoM),
			new ChapterInfo("Ether 5", "html/rcebom/Ether/5.html", ParserBoM),
			new ChapterInfo("Ether 6", "html/rcebom/Ether/6.html", ParserBoM),
			new ChapterInfo("Moroni 1", "html/rcebom/Moroni/1.html", ParserBoM),
			new ChapterInfo("Moroni 2", "html/rcebom/Moroni/2.html", ParserBoM),
			new ChapterInfo("Moroni 3", "html/rcebom/Moroni/3.html", ParserBoM),
			new ChapterInfo("Moroni 4", "html/rcebom/Moroni/4.html", ParserBoM),
			new ChapterInfo("Moroni 5", "html/rcebom/Moroni/5.html", ParserBoM),
			new ChapterInfo("Moroni 6", "html/rcebom/Moroni/6.html", ParserBoM),
			new ChapterInfo("Moroni 7", "html/rcebom/Moroni/7.html", ParserBoM),
			new ChapterInfo("Moroni 8", "html/rcebom/Moroni/8.html", ParserBoM),
			new ChapterInfo("Moroni 9", "html/rcebom/Moroni/9.html", ParserBoM),
			new ChapterInfo("Moroni 10", "html/rcebom/Moroni/10.html", ParserBoM),
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
		Console.WriteLine("SeekingYHWH.Scriptures.Search.ToolBox.exe");
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
		Console.Title = "SeekingYHWH.Scriptures.Search.ToolBox";

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
			var chapters = book.Chapters;
			for (var i = 0; true;)
			{
				var chapter = chapters[i];

				Console.WriteLine(chapter.URL);

				chapter.Parser(writer, chapter);

				++i;
				if (i >= chapters.Length)
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

	private static void ParserBoM(StreamWriter writer, ChapterInfo info)
	{
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
			if (!GetStartsWith(reader, "<section role=\"main\">"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<div class=\"entry-content\">"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<article class=\"hentry\">"))
			{
				return;
			}
			if (!GetStartsWith(reader, "<div class=\"entry-content\">"))
			{
				return;
			}
			writer.WriteLine(info.Chapter);
			while (true)
			{
				var line = reader.ReadLine();
				if (line is null)
				{
					break;
				}
				line = line.Trim();
				if (line.StartsWith("</div>"))
				{
					break;
				}
				else if (line.StartsWith("<i>"))
				{
					ParseBoMIntro(writer, reader, line);
				}
				else if (line.StartsWith("<p"))
				{
					ParseBoMVerse(writer, reader, line);
				}
				else
				{
					continue;
				}
			}
		}
	}

	private static void ParserBoM3Witnesses(StreamWriter writer, ChapterInfo info)
	{
		writer.WriteLine(info.Chapter);
		writer.Write(separator);
		writer.WriteLine("Be it known unto all nations, kindreds, tongues, and people, unto whom this work shall come: That we, through the grace of God the Father, and our Lord Jesus Christ, have seen the plates which contain this record, which is a record of the people of Nephi, and also of the Lamanites, their brethren, and also of the people of Jared, who came from the tower of which hath been spoken. And we also know that they have been translated by the gift and power of God, for his voice hath declared it unto us; wherefore we know of a surety that the work is true. And we also testify that we have seen the engravings which are upon the plates; and they have been shown unto us by the power of God, and not of man. And we declare with words of soberness, that an angel of God came down from heaven, and he brought and laid before our eyes, that we beheld and saw the plates, and the engravings thereon; and we know that it is by the grace of God the Father, and our Lord Jesus Christ, that we beheld and bear record that these things are true. And it is marvelous in our eyes. Nevertheless, the voice of the Lord commanded us that we should bear record of it; wherefore, to be obedient unto the commandments of God, we bear testimony of these things. And we know that if we are faithful in Christ, we shall rid our garments of the blood of all men, and be found spotless before the judgment-seat of Christ, and shall dwell with him eternally in the heavens. And the honor be to the Father, and to the Son, and to the Holy Ghost, which is one God. Amen.");
		writer.Write(separator);
		writer.WriteLine("Oliver Cowdery, David Whitmer, Martin Harris");
	}

	private static void ParserBoM8Witnesses(StreamWriter writer, ChapterInfo info)
	{
		writer.WriteLine(info.Chapter);
		writer.Write(separator);
		writer.WriteLine("Be it known unto all nations, kindreds, tongues, and people, unto whom this work shall come: That Joseph Smith, Jun., the translator of this work, has shown unto us the plates of which hath been spoken, which have the appearance of gold; and as many of the leaves as the said Smith has translated we did handle with our hands; and we also saw the engravings thereon, all of which has the appearance of ancient work, and of curious workmanship. And this we bear record with words of soberness, that the said Smith has shown unto us, for we have seen and hefted, and know of a surety that the said Smith has got the plates of which we have spoken. And we give our names unto the world, to witness unto the world that which we have seen. And we lie not, God bearing witness of it.");
		writer.Write(separator);
		writer.WriteLine("Christian Whitmer, Jacob Whitmer, Peter Whitmer Jun, John Whitmer, Hiram Page, Joseph Smith Sen, Hyrum Smith, Samuel H. Smith");
	}

	private static void ParseBoMIntro(StreamWriter writer, StringReader reader, string line)
	{
		builder.Clear();
		int offset;
		while (true)
		{
			offset = line.IndexOf("<p");
			if (offset >= 0)
			{
				break;
			}
			line = reader.ReadLine();
			if (line is null)
			{
				return;
			}
			line = line.Trim();
		}
		offset = line.IndexOf('>', offset);
		if (offset < 0)
		{
			return;
		}
		++offset;
		if (offset < line.Length)
		{
			line = line.Substring(offset);
		}
		else
		{
			line = reader.ReadLine();
			if (line is null)
			{
				return;
			}
			line = line.Trim();
		}
		while (true)
		{
			offset = line.IndexOf("</p>");
			if (offset >= 0)
			{
				line = line.Substring(0, offset).Trim();
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

	private static void ParseBoMVerse(StreamWriter writer, StringReader reader, string line)
	{
		builder.Clear();
		const string verseOpen = "id=\"";
		var offset = line.IndexOf(verseOpen);
		if (offset < 0)
		{
			return;
		}
		offset += verseOpen.Length;
		var ending = line.IndexOf('"', offset);
		if (ending < 0)
		{
			return;
		}
		var verse = line.Substring(offset, ending - offset);
		line = line.Substring(ending + 1);
		while (true)
		{
			const string supClose = "</sup>";
			offset = line.IndexOf(supClose);
			if (offset > 0)
			{
				line = line.Substring(offset + supClose.Length).Trim();
				break;
			}
			line = reader.ReadLine();
			if (line is null)
			{
				return;
			}
			line = line.Trim();
		}
		while (true)
		{
			offset = line.IndexOf("</p>");
			if (offset >= 0)
			{
				line = line.Substring(0, offset).Trim();
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

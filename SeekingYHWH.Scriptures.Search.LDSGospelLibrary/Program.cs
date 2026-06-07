using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using SharpCompress.Compressors.Xz;

using SeekingYHWH.Scriptures.LDSGospelLibrary;

namespace SeekingYHWH.Scriptures.Search.LDSGospelLibrary;

internal static class Program
{
	private const string schema = "https";
	private const string host = "ips-cdn-edge.churchofjesuschrist.org";
	private const string languagesURL = "/content/production/v4/languages/languages.json";
	private const string catalogInfoURL = "/content/production/v4/languages/{0}/index.json";
	private const string catalogURL = "/content/production/v4/languages/{0}/catalogs/{1}.xz";
	private const string packageURL = "/content/production/v4/languages/{0}/item-packages/{1}/{2}.xz";

	private const string connectionStringFormat = "Data Source={0}; Read Only=True;";

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
	private static string statePath = @"D:\Projects\SeekingYHWH.Scriptures.Search.LDSGospelLibrary";
	private static bool xzDelete = true;
	private static bool sqlDelete = true;
	private static bool tsvDelete = true;
	private static bool chapters = true;

	private static readonly Dictionary<string, BookInfo> urisBooks = new Dictionary<string, BookInfo>()
	{
		{ @"/scriptures/ot", new BookInfo() { Name = " - LDS", Code = "OT-LDS", Pre = "LDS", } },
		{ @"/scriptures/nt", new BookInfo() { Name = " - LDS", Code = "NT-LDS", Pre = "LDS", } },
		{ @"/scriptures/bofm", new BookInfo() { Name = " - LDS", Code = "BoM-LDS", Pre = "LDS", } },
		{ @"/scriptures/dc-testament", new BookInfo() { Name = " - LDS", Code = "DnC-LDS", Pre = "LDS", } },
		{ @"/scriptures/pgp", new BookInfo() { Name = " - LDS", Code = "PGP-LDS", Pre = null, } },
		{ @"/scriptures/jst", new BookInfo() { Name = " - LDS", Code = "JST-LDS", Pre = null, } },
	};
	private static HttpClient client;
	private static readonly byte[] buffer = new byte[4096];
	private static readonly Dictionary<string, LanguageInfo> languagesInfos = new Dictionary<string, LanguageInfo>();

	private static List<string> ParseCommandLine(string[] args)
	{
		return null;
	}

	private static void PrintHelp(List<string> errors)
	{
		Console.WriteLine();
		Console.WriteLine("SeekingYHWH.Scriptures.Search.LDSGospelLibrary.exe");
		Console.WriteLine(" Required");
		Console.WriteLine(" Optional");
		Console.WriteLine();

		if (errors != null && errors.Count > 0)
		{
			foreach (var error in errors)
			{
				Console.WriteLine(error);
			}
			Console.WriteLine();
		}
	}

	private static void Prepare()
	{
		Console.Title = "SeekingYHWH.Scriptures.Search.LDSGospelLibrary";

		PrepareClient();

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

	private static int Run()
	{
		DownloadLanguages();
		ListLanguages();
		//Parallel.ForEach(languagesInfos.Values, ProcessLanguage);
		foreach (var language in languagesInfos.Values)
		{
			ProcessLanguage(language);
		}
		WriteLanguages();
		return 0;
	}

	private static void DownloadLanguages()
	{
		using (var reader = client.GetStreamAsync(languagesURL).Result)
		{
			LanguageInfosConverter.Parse(reader, buffer, AddLanguage);
		}
	}

	private static void AddLanguage(LanguageInfo value)
	{
		languagesInfos.Add(value.Code, value);
	}

	private static void ListLanguages()
	{
		Console.WriteLine("Languages: {0}", languagesInfos.Count);

		foreach (var info in languagesInfos.Values)
		{
			Console.WriteLine("{0}: {1}", info.Code, info.Name);
		}
	}

	private static void WriteLanguages()
	{
		var values = new List<LanguageInfo>();
		foreach (var value in languagesInfos.Values)
		{
			if (value.BooksCount <= 0)
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

	private static void ProcessLanguage(LanguageInfo languageInfo)
	{
		var languageCode = languageInfo.Code;

		var catalogInfoURL = string.Format(Program.catalogInfoURL, languageCode);
		CatalogInfo catalog;
		using (var reader = client.GetStreamAsync(catalogInfoURL).Result)
		{
			catalog = CatalogInfoConverter.Parse(reader, buffer);
		}

		Directory.CreateDirectory(languageCode);
		Directory.CreateDirectory(Path.Combine(statePath, languageCode));

		var versionPath = Path.Combine(statePath, languageCode, ".version.txt");

		if (File.Exists(versionPath))
		{
			FileStream? readerStream = null;
			StreamReader? reader = null;
			try
			{
				readerStream = new FileStream(versionPath, FileMode.Open, FileAccess.Read, FileShare.Read);
				reader = new StreamReader(readerStream);
				var line = reader.ReadLine();
				if (!string.IsNullOrWhiteSpace(line) && int.TryParse(line, out var version) &&
					version >= catalog.Version)
				{
					lock (Console.Out)
					{
						Console.WriteLine("{0}: Skipped", languageCode);
					}
					return;
				}
			}
			catch
			{
			}
			finally
			{
				reader?.Dispose();
				readerStream?.Dispose();
			}
		}

		lock (Console.Out)
		{
			Console.WriteLine("{0}: Version: {1}", languageCode, catalog.Version);
		}

		var xzPath = Path.Combine(languageCode, ".xz");
		var url = string.Format(Program.catalogURL, languageCode, catalog.Version);
		long xzLength;
		using (var reader = client.GetStreamAsync(url).Result)
		using (var writer = new FileStream(xzPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		{
			reader.CopyTo(writer);
			xzLength = writer.Length;
		}

		lock (Console.Out)
		{
			Console.WriteLine("{0}: .xz: {1:###,0}", languageCode, xzLength);
		}

		var sqlPath = Path.Combine(languageCode, ".sqlite");
		long sqlLength;
		using (var writer = new FileStream(sqlPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		using (var readerStream = new FileStream(xzPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (var reader = new XZStream(readerStream))
		{
			reader.CopyTo(writer);
			sqlLength = writer.Length;
		}

		if (xzDelete)
		{
			File.Delete(xzPath);
		}

		lock (Console.Out)
		{
			Console.WriteLine("{0}: .sqlite: {1:###,0}", languageCode, sqlLength);
		}

		var books = new List<BookInfo>();
		var connectionString = string.Format(connectionStringFormat, sqlPath);
		using (var connection = new SQLiteConnection(connectionString))
		{
			connection.Open();

			var sql = string.Format("SELECT id, uri, title, version FROM item WHERE uri LIKE '/scriptures/%' AND language_id = {0}", languageInfo.Id);
			using (var command = new SQLiteCommand(sql, connection))
			using (var reader = command.ExecuteReader())
			{
				var idOffset = reader.GetOrdinal("id");
				var uriOffset = reader.GetOrdinal("uri");
				var titleOffset = reader.GetOrdinal("title");
				var versionOffset = reader.GetOrdinal("version");

				while (reader.Read())
				{
					var uri = reader.GetString(uriOffset);
					if (!urisBooks.TryGetValue(uri, out var info))
					{
						continue;
					}
					var name = reader.GetString(titleOffset);
					if (!string.IsNullOrWhiteSpace(info.Name))
					{
						name += info.Name;
					}
					var value = new BookInfo();
					value.Id = reader.GetString(idOffset);
					value.URI = uri;
					value.Version = reader.GetInt32(versionOffset);
					value.LanguageInfo = languageInfo;
					value.Code = info.Code;
					value.Name = name;
					value.Pre = info.Pre;
					books.Add(value);
				}
			}
		}
		languageInfo.BooksCount = books.Count;

		if (sqlDelete)
		{
			File.Delete(sqlPath);
		}

		lock (Console.Out)
		{
			Console.WriteLine("{0}: Books: {1}", languageCode, books.Count);
		}

		if (books.Count <= 0)
		{
			using (var writerStream = new FileStream(versionPath, FileMode.Create, FileAccess.Write, FileShare.Read))
			using (var writer = new StreamWriter(writerStream))
			{
				writer.Write(catalog.Version);
			}

			return;
		}

		var scripturesLanguagePath = Path.Combine(scripturesPath, languageCode);
		Directory.CreateDirectory(scripturesLanguagePath);
		Books.Update(scripturesLanguagePath, books);

		//Parallel.ForEach(books, ProcessBook);
		foreach (var book in books)
		{
			ProcessBook(book);
		}

		using (var writerStream = new FileStream(versionPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		using (var writer = new StreamWriter(writerStream))
		{
			writer.Write(catalog.Version);
		}

		if (xzDelete && sqlDelete && tsvDelete)
		{
			Directory.Delete(languageCode, true);
		}
	}

	private static void ProcessBook(BookInfo book)
	{
		var languageInfo = book.LanguageInfo;
		var languageCode = languageInfo.Code;
		var bookCode = book.Code;

		var versionPath = Path.Combine(statePath, languageCode, bookCode + ".version.txt");

		if (File.Exists(versionPath))
		{
			FileStream? readerStream = null;
			StreamReader? reader = null;
			try
			{
				readerStream = new FileStream(versionPath, FileMode.Open, FileAccess.Read, FileShare.Read);
				reader = new StreamReader(readerStream);
				var line = reader.ReadLine();
				if (!string.IsNullOrWhiteSpace(line) && int.TryParse(line, out var version) &&
					version >= book.Version)
				{
					lock (Console.Out)
					{
						Console.WriteLine("{0}: {1}: Skipped", languageCode, bookCode);
					}
					return;
				}
			}
			catch
			{
			}
			finally
			{
				reader?.Dispose();
				readerStream?.Dispose();
			}
		}

		var xzPath = Path.Combine(languageCode, bookCode + ".xz");
		var sqlPath = Path.Combine(languageCode, book.Code + ".sqlite");
		var url = string.Format(packageURL, languageCode, book.Id, book.Version);
		long xzLength;
		using (var reader = client.GetStreamAsync(url).Result)
		using (var writer = new FileStream(xzPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		{
			reader.CopyTo(writer);
			xzLength = writer.Length;
		}

		lock (Console.Out)
		{
			Console.WriteLine("{0}: {1}: .xz: {2}", languageCode, bookCode, xzLength);
		}

		long sqlLength;
		using (var writer = new FileStream(sqlPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		using (var readerStream = new FileStream(xzPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (var reader = new XZStream(readerStream))
		{
			reader.CopyTo(writer);
			sqlLength = writer.Length;
		}

		if (xzDelete)
		{
			File.Delete(xzPath);
		}

		lock (Console.Out)
		{
			Console.WriteLine("{0}: {1}: .sqlite: {2:###,0}", languageCode, bookCode, sqlLength);
		}

		var navigations = new List<NavigationInfo>();
		var connectionString = string.Format(connectionStringFormat, sqlPath);
		using (var connection = new SQLiteConnection(connectionString))
		{
			connection.Open();

			var sql = "SELECT uri, title, content_html FROM nav_item INNER JOIN subitem_content ON nav_item.subitem_id = subitem_content.subitem_id ORDER BY position ASC";
			using (var command = new SQLiteCommand(sql, connection))
			using (var reader = command.ExecuteReader())
			{
				var uriOrdinal = reader.GetOrdinal("uri");
				var titleOrdinal = reader.GetOrdinal("title");
				var htmlOrdinal = reader.GetOrdinal("content_html");

				while (reader.Read())
				{
					var uri = reader.GetString(uriOrdinal);
					if (!SeekingYHWH.Scriptures.LDSGospelLibrary.Scriptures.IsScripture(uri))
					{
						continue;
					}
					var value = new NavigationInfo();
					var valueTitle = WebUtility.HtmlDecode(reader.GetString(titleOrdinal));
					if (chapters &&
						!char.IsDigit(valueTitle[valueTitle.Length -1]) &&
						char.IsDigit(uri[uri.Length - 1]))
					{
						var i = uri.LastIndexOf('/');
						var chapter = uri.Substring(i + 1);
						valueTitle += " " + chapter;
					}
					value.Title = valueTitle;
					value.HTML = WebUtility.HtmlDecode(reader.GetString(htmlOrdinal));
					navigations.Add(value);
				}
			}
		}

		if (sqlDelete)
		{
			File.Delete(sqlPath);
		}

		lock (Console.Out)
		{
			Console.WriteLine("{0}: {1}: Navigations: {2}", languageCode, bookCode, navigations.Count);
		}

		var extractor = new Extractor(Extractor.CreateMap());

		var tsvPath = Path.Combine(languageCode, bookCode + ".tsv");
		using (var writerStream = new FileStream(tsvPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		using (var writer = new StreamWriter(writerStream))
		using (var navigation = navigations.GetEnumerator())
		{
			if (navigation.MoveNext())
			{
				while (true)
				{
					Search.Extract(writer, navigation.Current, extractor);

					if (!navigation.MoveNext())
					{
						break;
					}

					writer.WriteLine();
				}
			}
		}

		byte[] hash;
		using (var hasher = SHA256.Create())
		using (var reader = new FileStream(tsvPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			hash = hasher.ComputeHash(reader);
		}

		var hashPath = Path.Combine(scripturesPath, languageCode, bookCode + ".tsv.hsh");
		using (var writer = new FileStream(hashPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		{
			writer.Write(hash, 0, hash.Length);
		}

		var brPath = Path.Combine(scripturesPath, languageCode, bookCode + ".tsv.br");
		using (var writerStream = new FileStream(brPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		using (var writer = new BrotliStream(writerStream, CompressionLevel.SmallestSize))
		using (var reader = new FileStream(tsvPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			reader.CopyTo(writer);
		}

		if (tsvDelete)
		{
			File.Delete(tsvPath);
		}

		using (var writerStream = new FileStream(versionPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		using (var writer = new StreamWriter(writerStream))
		{
			writer.Write(book.Version);
		}
	}
}
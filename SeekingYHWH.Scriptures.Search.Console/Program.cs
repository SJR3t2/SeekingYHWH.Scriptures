using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Innovoft.IO;

namespace SeekingYHWH.Scriptures;

internal static class Program
{
	private const byte separator = BytesSplitReader.Tab;

	private static int Main(string[] args)
	{
		return Run();
	}

	private static string scripturesPath = @"D:\Projects\SeekingYHWH.Scriptures.Search";
	private static Func<LanguageInfo> languageGet = GetLanguageENG;

	private static readonly Dictionary<string, LanguageInfo> languages = new Dictionary<string, LanguageInfo>();
	private static string languagePath;
	private static readonly List<BookInfo> books = new List<BookInfo>();

	private static int Run()
	{
		ReadLanguages();
		foreach (var language in languages.Values)
		{
			Console.Write(language.Code);
			Console.Write(": ");
			Console.Write(language.Name);
			Console.WriteLine();
		}
		var languageInfo = languageGet();
		if (languageInfo is null)
		{
			return 0;
		}
		languagePath = BookInfosPaths.GetFolder(scripturesPath, languageInfo);
		ReadBooks();
		while (true)
		{
			QueryProvider provider;
			while (true)
			{
				Console.Write("Query: ");
				var query = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(query))
				{
					return 0;
				}
				if (QueryParserLISP.TryParse(query, out provider, out var errors))
				{
					break;
				}
				foreach (var error in errors)
				{
					Console.Error.WriteLine(error);
				}
			}
			Console.WriteLine();
			var searcher = new Searcher();
			searcher.SearchByVerse();
			var verses = searcher.Search(languagePath, books, provider);
			foreach (var verse in verses)
			{
				Console.WriteLine(verse);
				Console.WriteLine();
			}
		}
	}

	private static void ReadLanguages()
	{
		using (var reader = LanguageInfosReader.OpenBR(LanguageInfosPaths.GetPathBr(scripturesPath)))
		{
			while (true)
			{
				if (!reader.TryRead(out var value))
				{
					break;
				}

				languages.Add(value.Code, value);
			}
		}
	}

	private static LanguageInfo GetLanguage()
	{
		foreach (var value in languages.Values)
		{
			Console.WriteLine("{0}: {1}", value.Code, value.Name);
		}
		while (true)
		{
			Console.Write("Code: ");
			var code = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(code))
			{
				return null;
			}
			if (languages.TryGetValue(code, out var value))
			{
				return value;
			}
		}
	}

	private static LanguageInfo GetLanguageENG()
	{
		languages.TryGetValue("eng", out var value);
		return value;
	}

	private static void ReadBooks()
	{
		using (var reader = BookInfosReader.OpenBr(BookInfosPaths.GetBrPath(languagePath)))
		{
			while (reader.TryRead(out var value))
			{
				books.Add(value);
			}
		}
	}
}
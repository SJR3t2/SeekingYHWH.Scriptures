using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace SeekingYHWH.Scriptures.Search.Books;

internal static class Program
{
	private static int Main(string[] args)
	{
		var errors = ParseCommandLine(args);
		if (errors != null)
		{
			PrintHelp(errors);
			return -1;
		}

		Prepare();
		return Execute();
	}

	private static string scripturesPath = @"D:\Projects\SeekingYHWH.Scriptures.Search";

	private static readonly Dictionary<string, LanguageInfo> languages = new Dictionary<string, LanguageInfo>();

	private static List<string> ParseCommandLine(string[] args)
	{
		return null;
	}

	private static void PrintHelp(List<string> errors)
	{
		Console.WriteLine();
		Console.WriteLine("SeekingYHWH.Scriptures.Search.Books.exe");
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
		Console.Title = "SeekingYHWH.Scriptures.Search.Books";

		GC.Collect();
	}

	private static int Execute()
	{
		LanguagesRead();

		while (true)
		{
		Language:
			foreach (var language in languages.Values)
			{
				Console.Write(language.Code);
				Console.Write(": ");
				Console.WriteLine(language.Name);
			}
			string languageCode;
			LanguageInfo languageInfo;
			Console.WriteLine();
			while (true)
			{
				Console.Write("LanguageCode: ");
				languageCode = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(languageCode))
				{
					return 0;
				}
				if (languages.TryGetValue(languageCode, out languageInfo))
				{
					break;
				}
			}
			var languagePath = Path.Combine(scripturesPath, languageCode);
			var brPath = BookInfosPaths.GetBrPath(languagePath);
			var tsvPath = BookInfosPaths.GetTSVPath(languagePath);

			Console.WriteLine();
			using (var reader = BookInfosReader.OpenBr(brPath))
			{
				while (reader.TryRead(out var value))
				{
					Console.Write(value.Code);
					Console.Write(": ");
					Console.Write(value.Name);
					Console.Write(": ");
					Console.WriteLine(value.Pre);
				}
			}

			Compression.Decompress(brPath, tsvPath);

			Console.WriteLine();
			Console.WriteLine("Open: {0}", tsvPath);

			Console.WriteLine();
			Console.WriteLine("delete");
			Console.WriteLine("keep");
			Console.WriteLine("use");
			Console.WriteLine();
			while (true)
			{
				Console.Write("Command: ");
				var input = Console.ReadLine();
				switch (input)
				{
				case "delete":
					File.Delete(tsvPath);
					goto Language;

				case "keep":
					goto Language;

				case "use":
					Compression.Compress(tsvPath, brPath);
					File.Delete(tsvPath);
					var hashPath = BookInfosPaths.GetHashPath(languagePath);
					Hash.ComputeBR(brPath, hashPath);
					goto Language;
				}
			}
		}
	}

	private static void LanguagesRead()
	{
		languages.Clear();
		var path = LanguageInfosPaths.GetPathBr(scripturesPath);
		LanguageInfosReader.ReadBR(path, languages);
	}
}
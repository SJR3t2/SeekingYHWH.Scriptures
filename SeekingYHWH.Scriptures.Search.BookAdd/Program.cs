using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace SeekingYHWH.Scriptures.Search.BookAdd;

internal static class Program
{
	private static int Main(string[] args)
	{
		return Run();
	}

	private static string scripturesPath = @"D:\Projects\SeekingYHWH.Scriptures.Search";
	private static LanguageInfo languageInfo = new LanguageInfo()
	{
		Code = "eng",
		Name = "English",
	};
	private static BookInfo bookInfo = new BookInfo()
	{
		Code = "LoF",
		Name = "Lectures on Faith",
		Pre = "",
	};
	private static string bookPath = @"C:\Users\SJR3t2\OneDrive\Scriptures\SeekingYHWH.Scriptures.Search\LoF.tsv";

	private static int Run()
	{
		scripturesPath = BookInfosPaths.GetFolder(scripturesPath, languageInfo);

		var hshPath = Path.Combine(scripturesPath, bookInfo.Code + ".tsv.hsh");
		Hash.ComputeTSV(bookPath, hshPath);

		var brPath = Path.Combine(scripturesPath, bookInfo.Code + ".tsv.br");
		using (var writerStream = new FileStream(brPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		using (var writer = new BrotliStream(writerStream, CompressionLevel.SmallestSize))
		using (var reader = new FileStream(bookPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			reader.CopyTo(writer);
		}

		Books.Update(scripturesPath, new[] { bookInfo, });
		return 0;
	}
}

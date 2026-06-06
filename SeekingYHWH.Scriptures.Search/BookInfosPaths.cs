using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeekingYHWH.Scriptures;

public static class BookInfosPaths
{
	public const string TSV = "Books.tsv";
	public const string BR = TSV + ".br";
	public const string HSH = TSV + ".hsh";

	public static string GetFolder(string path, LanguageInfo language)
	{
		return Path.Combine(path, language.Code);
	}

	public static string GetFolder(string path, string languageCode)
	{
		return Path.Combine(path, languageCode);
	}

	public static string GetTSVPath(string path)
	{
		return Path.Combine(path, TSV);
	}

	public static string GetPathTSV(string path, LanguageInfo language)
	{
		return Path.Combine(path, language.Code, TSV);
	}

	public static string GetBrPath(string path)
	{
		return Path.Combine(path, BR);
	}

	public static string GetBrPath(string path, LanguageInfo language)
	{
		return Path.Combine(path, language.Code, BR);
	}

	public static string GetHashPath(string path)
	{
		return Path.Combine(path, HSH);
	}

	public static string GetHashPath(string path, LanguageInfo language)
	{
		return Path.Combine(path, language.Code, HSH);
	}
}

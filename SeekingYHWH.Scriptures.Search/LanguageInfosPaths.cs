using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeekingYHWH.Scriptures;

public static class LanguageInfosPaths
{
	public const string TSV = "Languages.tsv";
	public const string BR = TSV + ".br";
	public const string HSH = TSV + ".hsh";

	public static string GetPath(string path)
	{
		return Path.Combine(path, TSV);
	}

	public static string GetPathBr(string path)
	{
		return Path.Combine(path, BR);
	}

	public static string GetHashPath(string path)
	{
		return Path.Combine(path, HSH);
	}
}

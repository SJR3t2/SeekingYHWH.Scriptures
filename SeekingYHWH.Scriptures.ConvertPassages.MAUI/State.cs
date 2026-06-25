using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures.ConvertPassages.MAUI;

internal static class State
{
	private static string optionsPath = Path.Combine(FileSystem.CacheDirectory, "Options.tsv");
	public static Options Options = new Options();

	public static void Prepare()
	{
		Options.Read(optionsPath);
	}
}

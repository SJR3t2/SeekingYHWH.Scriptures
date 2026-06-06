using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace SeekingYHWH.Scriptures;

public static class Stores
{
	private static string path;

	public static void Prepare(string path)
	{
		Stores.path = path;
	}

	public static string Path => path;
}

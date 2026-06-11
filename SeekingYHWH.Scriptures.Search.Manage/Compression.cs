using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace SeekingYHWH.Scriptures;

public static class Compression
{
	public static void Compress(string tsvPath, string brPath)
	{
		using (var writerStream = new FileStream(brPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		using (var writer = new BrotliStream(writerStream, CompressionLevel.SmallestSize))
		using (var reader = new FileStream(tsvPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			reader.CopyTo(writer);
		}
	}

	public static void Decompress(string brPath, string tsvPath)
	{
		using (var readerStream = new FileStream(brPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (var reader = new BrotliStream(readerStream, CompressionMode.Decompress))
		using (var writer = new FileStream(tsvPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		{
			reader.CopyTo(writer);
		}
	}
}

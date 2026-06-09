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
}

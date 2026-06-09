using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace SeekingYHWH.Scriptures;

public static class Book
{
	public static StreamWriter OpenWriterTSV(string path)
	{
		var writerStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
		var writer = new StreamWriter(writerStream);
		return writer;
	}

	public static StreamWriter OpenWriterBR(string path)
	{
		var writerFile = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
		var writerStream = new BrotliStream(writerFile, CompressionLevel.SmallestSize);
		var writer = new StreamWriter(writerStream);
		return writer;
	}
}

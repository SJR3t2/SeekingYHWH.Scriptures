using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace SeekingYHWH.Scriptures;

public sealed class BookInfosWriter : IDisposable
{
	private const string header = "Code\tName\tPre";
	private const char seperator = '\t';

	public static BookInfosWriter Open(string path)
	{
		var writerStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
		var writer = new BookInfosWriter(writerStream);
		return writer;
	}

	public static void WriteTSV(string path, IEnumerable<BookInfo> values)
	{
		using (var writer = Open(path))
		{
			writer.Write(values);
		}
	}

	public static BookInfosWriter OpenBr(string path)
	{
		var writerFile = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
		var writerStream = new BrotliStream(writerFile, CompressionLevel.SmallestSize);
		var writer = new BookInfosWriter(writerStream);
		return writer;
	}

	public static void WriteBR(string path, IEnumerable<BookInfo> values)
	{
		using (var writer = BookInfosWriter.OpenBr(path))
		{
			writer.Write(values);
		}
	}

	private Stream stream;
	private StreamWriter writer;

	public BookInfosWriter(Stream stream)
	{
		this.stream = stream;
		this.writer = new StreamWriter(stream);

		Header();
	}

	~BookInfosWriter()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void Dispose(bool disposing)
	{
		if (writer is not null)
		{
			writer.Dispose();
			writer = null;
		}
		if (stream is not null)
		{
			stream.Dispose();
			stream = null;
		}
	}

	private void Header()
	{
		writer.WriteLine(header);
	}

	public void Write(BookInfo value)
	{
		writer.Write(value.Code);
		writer.Write(seperator);
		writer.Write(value.Name);
		writer.Write(seperator);
		writer.WriteLine(value.Pre);
	}

	public void Write(IEnumerable<BookInfo> values)
	{
		foreach (var value in values)
		{
			Write(value);
		}
	}
}

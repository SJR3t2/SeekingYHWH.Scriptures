using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace SeekingYHWH.Scriptures;

public sealed class LanguageInfosWriter : IDisposable
{
	private const string header = "Code\tName";
	private const char seperator = '\t';

	public static LanguageInfosWriter OpenTSV(string path)
	{
		var writerStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
		var writer = new LanguageInfosWriter(writerStream);
		return writer;
	}

	public static LanguageInfosWriter OpenBR(string path)
	{
		var writerFile = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
		var writerStream = new BrotliStream(writerFile, CompressionLevel.SmallestSize);
		var writer = new LanguageInfosWriter(writerStream);
		return writer;
	}

	private Stream stream;
	private StreamWriter writer;

	public LanguageInfosWriter(Stream stream)
	{
		this.stream = stream;
		this.writer = new StreamWriter(stream);

		Header();
	}

	~LanguageInfosWriter()
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

	public void Write(LanguageInfo value)
	{
		writer.Write(value.Code);
		writer.Write(seperator);
		writer.WriteLine(value.Name);
	}

	public void Write(IEnumerable<LanguageInfo> values)
	{
		foreach (var value in values)
		{
			Write(value);
		}
	}
}

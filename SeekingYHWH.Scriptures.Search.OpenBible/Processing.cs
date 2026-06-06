using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace SeekingYHWH.Scriptures.Search.OpenBible;

internal sealed class Processing : IDisposable
{
	private readonly BookInfo book;
	private readonly string path;
	private FileStream? writerFile;
	private BrotliStream? writerStream;
	private StreamWriter? writer;

	public Processing(BookInfo book, string path, FileStream? writerFile, BrotliStream? writerStream, StreamWriter? writer)
	{
		this.book = book;
		this.path = path;
		this.writerFile = writerFile;
		this.writerStream = writerStream;
		this.writer = writer;
	}

	~Processing()
	{
		Dispose(disposing: false);
	}

	public BookInfo Book => book;
	public string Path => path;
	public StreamWriter? Writer => writer;

	public string Chapter { get; set; }

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
		if (writerStream is not null)
		{
			writerStream.Dispose();
			writerStream = null;
		}
		if (writerFile is not null)
		{
			writerFile.Dispose();
			writerFile = null;
		}
	}
}

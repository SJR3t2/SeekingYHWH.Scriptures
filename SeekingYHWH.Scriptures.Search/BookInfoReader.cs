using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

using Innovoft.IO;

namespace SeekingYHWH.Scriptures;

public sealed class BookInfosReader : IDisposable
{
	private const string headerCode = "Code";
	private const string headerName = "Name";
	private const string headerPre = "Pre";
	private const byte separator = BytesSplitReader.Tab;

	public static BookInfosReader Open(string path)
	{
		var readerStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
		var reader = new BookInfosReader(readerStream);
		return reader;
	}

	public static BookInfosReader OpenBr(string path)
	{
		var readerFile = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
		var readerStream = new BrotliStream(readerFile, CompressionMode.Decompress);
		var reader = new BookInfosReader(readerStream);
		return reader;
	}

	private Stream stream;
	private BytesSplitReader reader;

	private BytesColumn code;
	private BytesColumn name;
	private BytesColumn pre;
	private BytesColumn[] columns;

	public BookInfosReader(Stream stream)
	{
		this.stream = stream;
		this.reader = new BytesSplitReader(stream);

		Header();
	}

	~BookInfosReader()
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
		code = null;
		name = null;
		columns = null;
		if (reader is not null)
		{
			reader.Dispose();
			reader = null;
		}
		if (stream is not null)
		{
			stream.Dispose();
			stream = null;
		}
	}

	private void Header()
	{
		var headers = new BytesColumns();
		while (true)
		{
			headers.Clear();
			if (!reader.ReadColumnsEnding(separator, headers))
			{
				code = null;
				name = null;
				pre = null;
				columns = Array.Empty<BytesColumn>();
				return;
			}

			var codeOffset = 0;
			var nameOffset = 0;
			var preOffset = 0;
			for (var offset = 0; headers.TryGetColumn(offset, out var header); ++offset)
			{
				switch (header.ToString())
				{
				case headerCode:
					code = header;
					codeOffset = offset;
					break;

				case headerName:
					name = header;
					nameOffset = offset;
					break;

				case headerPre:
					pre = header;
					preOffset = offset;
					break;
				}
			}
			if (code is null || name is null || pre is null)
			{
				code = null;
				name = null;
				pre = null;
				continue;
			}
			var offsets = codeOffset;
			if (nameOffset > offsets)
			{
				offsets = nameOffset;
			}
			if (preOffset > offsets)
			{
				offsets = preOffset;
			}
			++offsets;
			columns = new BytesColumn[offsets];
			columns[codeOffset] = code;
			columns[nameOffset] = name;
			columns[preOffset] = pre;
			return;
		}
	}

	public BookInfo Read()
	{
		BytesColumn.Clear(columns);
		if (!reader.ReadColumnsEnding(separator, columns))
		{
			return null;
		}
		var value = new BookInfo()
		{
			Code = code.ToString(),
			Name = name.ToString(),
			Pre = pre.ToString(),
		};
		return value;
	}

	public bool TryRead(out BookInfo value)
	{ 
		BytesColumn.Clear(columns);
		if (!reader.ReadColumnsEnding(separator, columns))
		{
			value = null;
			return false;
		}
		value = new BookInfo()
		{
			Code = code.ToString(),
			Name = name.ToString(),
			Pre = pre.ToString(),
		};
		return true;
	}
}

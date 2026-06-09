using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace SeekingYHWH.Scriptures;

public static class Books
{
	public static void Update(string path, IEnumerable<BookInfo> books)
	{
		var brPath = BookInfosPaths.GetBrPath(path);

		//Read
		var values = new List<BookInfo>();
		var offsets = new Dictionary<string, int>();
		if (File.Exists(brPath))
		{
			using (var reader = BookInfosReader.OpenBr(brPath))
			{
				while (reader.TryRead(out var value))
				{
					offsets.Add(value.Code, values.Count);
					values.Add(value);
				}
			}
		}

		//Update
		var updated = false;
		foreach (var value in books)
		{
			var code = value.Code;
			if (offsets.TryGetValue(code, out var offset))
			{
				var old = values[offset];
				if (value.Name == old.Name && value.Pre == old.Pre)
				{
					continue;
				}
				values[offset] = value;
			}
			else
			{
				offset = values.Count;
				values.Add(value);
				offsets.Add(code, offset);
				updated = true;
			}
		}
		if (!updated)
		{
			return;
		}

		BookInfosWriter.WriteBR(brPath, values);

		var hashPath = LanguageInfosPaths.GetHashPath(path);
		Hash.ComputeBR(brPath, hashPath);
	}

	public static void Update(string path, BookInfo book)
	{
		Update(path, new[] { book });
	}
}

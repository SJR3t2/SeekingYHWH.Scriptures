using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace SeekingYHWH.Scriptures;

public static partial class Languages
{
	public static void Update(string path, IEnumerable<LanguageInfo> languages)
	{
		var brPath = LanguageInfosPaths.GetPathBr(path);

		//Read
		var values = new List<LanguageInfo>();
		var offsets = new Dictionary<string, int>();
		if (File.Exists(brPath))
		{
			using (var reader = LanguageInfosReader.OpenBr(brPath))
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
		foreach (var value in languages)
		{
			var code = value.Code;
			if (offsets.TryGetValue(code, out var offset))
			{
				var old = values[offset];
				if (value.Name == old.Name)
				{
					continue;
				}
				values[offset] = value;
				updated = true;
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

		//Write
		using (var writer = LanguageInfosWriter.OpenBr(brPath))
		{
			writer.Write(values);
		}

		//Hash
		byte[] hash;
		using (var readerFile = new FileStream(brPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (var readerStream = new BrotliStream(readerFile, CompressionMode.Decompress))
		using (var hasher = SHA256.Create())
		{
			hash = hasher.ComputeHash(readerStream);
		}
		var hashPath = LanguageInfosPaths.GetHashPath(path);
		using (var writerFile = new FileStream(hashPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		{
			writerFile.Write(hash, 0, hash.Length);
		}
	}
}

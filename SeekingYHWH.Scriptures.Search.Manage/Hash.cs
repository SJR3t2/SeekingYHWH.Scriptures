using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace SeekingYHWH.Scriptures;

public static class Hash
{
	public static void ComputeTSV(string tsvPath, string hashPath)
	{
		byte[] hash;
		using (var reader = new FileStream(tsvPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (var hasher = SHA256.Create())
		{
			hash = hasher.ComputeHash(reader);
		}
		using (var writer = new FileStream(hashPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		{
			writer.Write(hash, 0, hash.Length);
		}
	}

	public static void ComputeBR(string brPath, string hashPath)
	{
		byte[] hash;
		using (var readerFile = new FileStream(brPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		using (var reader = new BrotliStream(readerFile, CompressionMode.Decompress))
		using (var hasher = SHA256.Create())
		{
			hash = hasher.ComputeHash(reader);
		}
		using (var writer = new FileStream(hashPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		{
			writer.Write(hash, 0, hash.Length);
		}
	}
}

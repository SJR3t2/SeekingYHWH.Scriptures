using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SeekingYHWH.Scriptures;

public static class Hash
{
	public static void Compute(string tsvPath, string hashPath)
	{
		byte[] hash;
		using (var hasher = SHA256.Create())
		using (var reader = new FileStream(tsvPath, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			hash = hasher.ComputeHash(reader);
		}

		using (var writer = new FileStream(hashPath, FileMode.Create, FileAccess.Write, FileShare.Read))
		{
			writer.Write(hash, 0, hash.Length);
		}
	}
}

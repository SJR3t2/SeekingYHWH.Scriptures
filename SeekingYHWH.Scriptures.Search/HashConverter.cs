using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

public sealed class HashConverter
{
	public static bool Equals(byte[] x, byte[] y)
	{
		if (x.Length != y.Length)
		{
			return false;
		}
		for (var i = x.Length - 1; i >= 0; --i)
		{
			if (x[i] != y[i])
			{
				return false;
			}
		}
		return true;
	}
}

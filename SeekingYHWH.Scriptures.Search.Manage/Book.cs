using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeekingYHWH.Scriptures;

public static class Book
{
	public static StreamWriter OpenTSV(string path)
	{
		var writerStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
		var writer = new StreamWriter(writerStream);
		return writer;
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures.Search.OpenBible;

internal sealed class BookInfo : SeekingYHWH.Scriptures.BookInfo
{
	public HashSet<string> Chapters { get; set; }
}

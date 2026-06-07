using System;
using System.Collections.Generic;
using System.Text;

using SeekingYHWH.Scriptures;

namespace SeekingYHWH.Scriptures.Search.BibleAPI;

internal sealed class CollectionInfo : SeekingYHWH.Scriptures.BookInfo
{
	public string Id { get; set; }
	public string[] Books { get; set; }
}

using System;
using System.Collections.Generic;
using System.Text;

using SeekingYHWH.Scriptures;

namespace SeekingYHWH.Scriptures.Search.BibleAPI;

internal sealed class LanguageInfo : SeekingYHWH.Scriptures.LanguageInfo
{
	public CollectionInfo[] Collections { get; set; }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures.Search.LDSGospelLibrary
{
	internal sealed class BookInfo : SeekingYHWH.Scriptures.BookInfo
	{
		public string Id { get; set; }
		public string URI { get; set; }
		public int Version { get; set; }
		public LanguageInfo LanguageInfo { get; set; }
	}
}

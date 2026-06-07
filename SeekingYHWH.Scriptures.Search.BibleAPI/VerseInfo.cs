using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures.Search.BibleAPI;

internal sealed class VerseInfo
{
	public string? Book { get; set; }
	public string? Chapter { get; set; }
	public string? Verse { get; set; }
	public string? Text { get; set; }
}

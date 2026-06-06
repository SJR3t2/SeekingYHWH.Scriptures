using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeekingYHWH.Scriptures.Search.ToolBox;

internal sealed class ChapterInfo
{
	private readonly string chapter;
	private readonly string url;
	private readonly Action<StreamWriter, ChapterInfo> parser;

	public ChapterInfo(string chapter, string url, Action<StreamWriter, ChapterInfo> parser)
	{
		this.chapter = chapter;
		this.url = url;
		this.parser = parser;
	}

	public string Chapter => chapter;
	public string URL => url;
	public Action<StreamWriter, ChapterInfo> Parser => parser;
}

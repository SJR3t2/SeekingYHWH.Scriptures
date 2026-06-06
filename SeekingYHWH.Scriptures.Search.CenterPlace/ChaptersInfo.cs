using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeekingYHWH.Scriptures.Search.CenterPlace;

internal sealed class ChaptersInfo
{
	private readonly string book;
	private readonly string url;
	private readonly Action<StreamWriter, ChaptersInfo> parser;

	public ChaptersInfo(string book, string url, Action<StreamWriter, ChaptersInfo> parser)
	{
		this.book = book;
		this.url = url;
		this.parser = parser;
	}

	public string Book => book;
	public string URL => url;
	public Action<StreamWriter, ChaptersInfo> Parser => parser;
}

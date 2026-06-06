using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

internal sealed class VerseInfo
{
	private readonly int openChapter;
	private readonly int openVerse;
	private readonly int closeChapter;
	private readonly int closeVerse;

	public VerseInfo(int openChapter, int openVerse, int closeChapter, int closeVerse)
	{
		this.openChapter = openChapter;
		this.openVerse = openVerse;
		this.closeChapter = closeChapter;
		this.closeVerse = closeVerse;
	}

	public int OpenChapter => openChapter;
	public int OpenVerse => openVerse;
	public int CloseChapter => closeChapter;
	public int CloseVerse => closeVerse;

	public override string ToString()
	{
		var value = openChapter.ToString() + " " + openVerse.ToString() + " " + closeChapter.ToString() + " " + closeVerse.ToString();
		return value;
	}
}

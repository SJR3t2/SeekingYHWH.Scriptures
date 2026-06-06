using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

public sealed class VerseInfo
{
	public static bool TryGetChapter(VerseInfo?[]?[] chapters,int chapter, int verse, out VerseInfo? value)
	{
		if (chapter < chapters.Length)
		{
			var verses = chapters[chapter];
			if (verse < verses.Length)
			{
				value = verses[verse];
				return true;
			}
		}
		value = null;
		return false;
	}

	public static bool TryGetChapter(VerseInfo?[]?[] chapters, int chapter, out VerseInfo?[]? verses)
	{
		if (chapter < chapters.Length)
		{
			verses = chapters[chapter];
			return true;
		}
		else
		{
			verses = null;
			return false;
		}
	}

	public static bool TryGetVerse(VerseInfo?[] verses, int verse, out VerseInfo? info)
	{
		if (verse < verses.Length)
		{
			info = verses[verse];
			return true;
		}
		else
		{
			info = null;
			return false;
		}
	}

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

	public VerseInfo(int openChapter, int openVerse)
	{
		this.openChapter = openChapter;
		this.openVerse = openVerse;
		this.closeChapter = 0;
		this.closeVerse = 0;
	}

	public int OpenChapter => openChapter;
	public int OpenVerse => openVerse;
	public int CloseChapter => closeChapter;
	public int CloseVerse => closeVerse;

	public bool TryGetClose(out int closeChapter, out int closeVerse)
	{
		if (this.closeChapter > 0)
		{
			closeChapter = this.closeChapter;
			closeVerse = this.closeVerse;
			return true;
		}
		else
		{
			closeChapter = 0;
			closeVerse = 0;
			return false;
		}
	}

	public bool TryGetCloseVerse(out int closeVerse)
	{
		if (this.closeVerse > 0)
		{
			closeVerse = this.closeVerse;
			return true;
		}
		else
		{
			closeVerse = 0;
			return false;
		}
	}

	public void GetLast(out int closeChapter, out int closeVerse)
	{
		if (this.closeChapter > 0)
		{
			closeChapter = this.closeChapter;
			closeVerse = this.closeVerse;
		}
		else
		{
			closeChapter = this.openChapter;
			closeVerse = this.openVerse;
		}
	}

	public int GetLastChapter()
	{
		if (closeChapter > 0)
		{
			return closeChapter;
		}
		else
		{
			return openChapter;
		}
	}

	public int GetLastVerse()
	{
		if (closeVerse > 0)
		{
			return closeVerse;
		}
		else
		{
			return openVerse;
		}
	}

	public override string ToString()
	{
		var builder = new StringBuilder();
		builder.Append(openChapter);
		builder.Append(':');
		builder.Append(openVerse);
		if (closeVerse > 0)
		{
			builder.Append('-');
			if (closeChapter > openChapter)
			{
				builder.Append(closeChapter);
				builder.Append(':');
			}
			builder.Append(closeVerse);
		}
		var value = builder.ToString();
		return value;
	}
}

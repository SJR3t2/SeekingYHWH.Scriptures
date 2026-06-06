using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SeekingYHWH.Scriptures;

public abstract class VersesConverter : BookConverter
{
	protected readonly VerseInfo?[]?[] chapters;

	protected int prevChapter;

	protected VersesConverter(VerseInfo?[]?[] chapters)
		: base()
	{
		this.chapters = chapters;
		this.singleChapter = chapters.Length == 1 + 1;
	}

	public override void Begin(PassagesConverter converter)
	{
		prevChapter = 0;
	}

	protected bool TryGetChapter(int chapter, out VerseInfo?[]? value)
	{
		if (chapter < chapters.Length)
		{
			value = chapters[chapter];
			return true;
		}
		value = null;
		return false;
	}

	protected bool TryGetVerse(int chapter, int verse, out VerseInfo? value)
	{
		if (chapter < chapters.Length)
		{
			var verses = chapters[chapter];
			if (verse < verses!.Length)
			{
				value = verses[verse];
				return true;
			}
		}
		value = null;
		return false;
	}

	protected void Chapter(StringBuilder builder, VerseInfo?[] chapterInfos)
	{
		var chapterInfo = chapterInfos[0];
		var openInfo = chapterInfos[1];
		var openChapter = openInfo.OpenChapter;
		var closeInfo = chapterInfos[chapterInfos.Length - 1];
		var closeChapter = closeInfo.GetLastChapter();
		prevChapter = closeChapter;
		builder.Append(openChapter);
		if (chapterInfo != null && chapterInfo.OpenVerse > 0 && chapterInfo.CloseVerse > 0)
		{
			if (closeChapter != openChapter)
			{
				builder.Append('-');
				builder.Append(closeChapter);
			}
			return;
		}
		builder.Append(':');
		var openVerse = openInfo.OpenVerse;
		builder.Append(openVerse);
		var closeVerse = closeInfo.GetLastVerse();
		builder.Append('-');
		if (closeChapter == openChapter)
		{
			if (closeVerse > openVerse)
			{
				builder.Append(closeVerse);
			}
			return;
		}
		builder.Append(closeChapter);
		builder.Append(':');
		builder.Append(closeVerse);
	}

	protected void Chapters(StringBuilder builder, VerseInfo?[] opens, VerseInfo?[] closes)
	{
		var openChapterInfo = opens[0];
		var openInfo = opens[1];
		var closeChapterInfo = closes[0];
		var closeInfo = closes[closes.Length - 1];
		var openChapter = openInfo.OpenChapter;
		var closeChapter = closeInfo.GetLastChapter();
		prevChapter = closeChapter;
		builder.Append(openChapter);
		if (openChapterInfo != null && openChapterInfo.OpenVerse > 0 && closeChapterInfo != null && closeChapterInfo.CloseVerse > 0)
		{
			if (closeChapter != openChapter)
			{
				builder.Append('-');
				builder.Append(closeChapter);
			}
			return;
		}
		builder.Append(':');
		var openVerse = openInfo.OpenVerse;
		builder.Append(openVerse);
		var closeVerse = closeInfo.GetLastVerse();
		builder.Append('-');
		if (closeChapter == openChapter)
		{
			if (closeVerse > openVerse)
			{
				builder.Append(closeVerse);
			}
			return;
		}
		builder.Append(closeChapter);
		builder.Append(':');
		builder.Append(closeVerse);
	}

	protected void ChapterVerse(StringBuilder builder, VerseInfo info)
	{
		var openChapter = info.OpenChapter;
		var openVerse = info.OpenVerse;
		info.GetLast(out var closeChapter, out var closeVerse);
		if (openChapter != closeChapter || openChapter != prevChapter)
		{
			builder.Append(openChapter);
			builder.Append(':');
		}
		prevChapter = closeChapter;
		builder.Append(openVerse);
		if (closeChapter == openChapter && closeVerse == openVerse)
		{
			return;
		}
		builder.Append('-');
		if (closeChapter != openChapter)
		{
			builder.Append(closeChapter);
			builder.Append(':');
		}
		builder.Append(closeVerse);
	}

	protected void ChapterVerses(StringBuilder builder, VerseInfo open, VerseInfo close)
	{
		var openChapter = open.OpenChapter;
		var openVerse = open.OpenVerse;
		close.GetLast(out var closeChapter, out var closeVerse);
		if (openChapter != closeChapter || openChapter != prevChapter)
		{
			builder.Append(openChapter);
			builder.Append(':');
		}
		prevChapter = closeChapter;
		builder.Append(openVerse);
		if (openChapter == closeChapter && openVerse == closeVerse)
		{
			return;
		}
		builder.Append('-');
		if (openChapter != closeChapter)
		{
			builder.Append(closeChapter);
			builder.Append(':');
		}
		builder.Append(closeVerse);
	}

	protected void Verse(StringBuilder builder, VerseInfo info)
	{
		var openChapter = info.OpenChapter;
		var openVerse = info.OpenVerse;
		info.GetLast(out var closeChapter, out var closeVerse);
		if (openChapter != closeChapter || openChapter != prevChapter)
		{
			builder.Append(openChapter);
			builder.Append(':');
		}
		prevChapter = closeChapter;
		builder.Append(openVerse);
		if (closeChapter == openChapter && closeVerse == openVerse)
		{
			return;
		}
		builder.Append('-');
		if (closeChapter != openChapter)
		{
			builder.Append(closeChapter);
			builder.Append(':');
		}
		builder.Append(closeVerse);
	}

	protected void Verses(StringBuilder builder, VerseInfo open, VerseInfo close)
	{
		var openChapter = open.OpenChapter;
		var openVerse = open.OpenVerse;
		close.GetLast(out var closeChapter, out var closeVerse);
		if (openChapter != closeChapter || openChapter != prevChapter)
		{
			builder.Append(openChapter);
			builder.Append(':');
		}
		prevChapter = closeChapter;
		builder.Append(openVerse);
		if (closeChapter == openChapter && closeVerse == openVerse)
		{
			return;
		}
		builder.Append('-');
		if (closeChapter != openChapter)
		{
			builder.Append(closeChapter);
			builder.Append(':');
		}
		builder.Append(closeVerse);
	}

	protected void ChaptersVerses(StringBuilder builder, VerseInfo open, VerseInfo close)
	{
		var openChapter = open.OpenChapter;
		var openVerse = open.OpenVerse;
		close.GetLast(out var closeChapter, out var closeVerse);
		if (openChapter != closeChapter || openChapter != prevChapter)
		{
			builder.Append(openChapter);
			builder.Append(':');
		}
		prevChapter = closeChapter;
		builder.Append(openVerse);
		if (closeChapter == openChapter && closeVerse == openVerse)
		{
			return;
		}
		builder.Append('-');
		if (closeChapter != openChapter)
		{
			builder.Append(closeChapter);
			builder.Append(':');
		}
		builder.Append(closeVerse);
	}
}

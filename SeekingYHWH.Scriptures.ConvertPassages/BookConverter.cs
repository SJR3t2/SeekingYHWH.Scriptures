using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

public abstract class BookConverter
{
	protected string rename;
	protected bool singleChapter;

	protected BookConverter()
	{
	}

	public string Rename { get => rename; set => rename = value; }

	public bool SingleChapter => singleChapter;

	public abstract void Initialize(PassagesConverter converter);

	public abstract void Begin(PassagesConverter converter);

	public abstract void Chapter(PassagesConverter converter);

	public abstract void Chapters(PassagesConverter converter);

	public abstract void ChapterVerse(PassagesConverter converter);

	public abstract void ChapterVerses(PassagesConverter converter);

	public abstract void Verse(PassagesConverter converter);

	public abstract void Verses(PassagesConverter converter);

	public abstract void ChaptersVerses(PassagesConverter converter);

	public abstract void Additional(PassagesConverter converter);

	public abstract void Error(PassagesConverter converter, StringBuilder value);

	public abstract void Error(PassagesConverter converter, char value);

	public abstract void End(PassagesConverter converter);

	protected static void Chapter(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.OpenChapterBuilder);
	}

	protected static void Chapters(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.OpenChapterBuilder);
		builder.Append('-');
		builder.Append(converter.CloseChapterBuilder);
	}

	protected static void ChaptersOpen(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.OpenChapterBuilder);
		builder.Append('-');
	}

	protected static void ChaptersClose(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.CloseChapterBuilder);
	}

	protected static void ChapterVerse(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.OpenChapterBuilder);
		builder.Append(':');
		builder.Append(converter.OpenVerseBuilder);
	}

	protected static void ChapterVerses(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.OpenChapterBuilder);
		builder.Append(':');
		builder.Append(converter.OpenVerseBuilder);
		builder.Append('-');
		builder.Append(converter.CloseVerseBuilder);
	}

	protected static void ChapterVersesOpen(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.OpenChapterBuilder);
		builder.Append(':');
		builder.Append(converter.OpenVerseBuilder);
		builder.Append('-');
	}

	protected static void ChapterVersesClose(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.CloseVerseBuilder);
	}

	protected static void Verse(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.OpenVerseBuilder);
	}

	protected static void Verses(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.OpenVerseBuilder);
		builder.Append('-');
		builder.Append(converter.CloseVerseValue);
	}

	protected static void VersesOpen(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.OpenVerseBuilder);
		builder.Append('-');
	}

	protected static void VersesClose(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.CloseVerseValue);
	}

	protected static void ChaptersVerses(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.OpenChapterBuilder);
		builder.Append(':');
		builder.Append(converter.OpenVerseBuilder);
		builder.Append('-');
		builder.Append(converter.CloseChapterBuilder);
		builder.Append(':');
		builder.Append(converter.CloseVerseBuilder);
	}

	protected static void ChaptersVersesOpen(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.OpenChapterBuilder);
		builder.Append(':');
		builder.Append(converter.OpenVerseBuilder);
		builder.Append('-');
	}

	protected static void ChaptersVersesClose(StringBuilder builder, PassagesConverter converter)
	{
		builder.Append(converter.CloseChapterBuilder);
		builder.Append(':');
		builder.Append(converter.CloseVerseBuilder);
	}
}

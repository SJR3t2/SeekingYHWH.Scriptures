using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

public sealed class SourceOtherVersesConverter : VersesConverter
{
	public static void Set(Dictionary<string, BookConverter> books, Dictionary<string, VerseInfo?[]?[]> booksChapters, string? pre, string? center, string? post)
	{
		foreach (var pair in booksChapters)
		{
			var book = pair.Key;
			var chapters = pair.Value;
			var value = new SourceOtherVersesConverter(chapters, pre, center, post);
			books[book] = value;
		}
	}

	public static void Set(PassagesConverter converter, Dictionary<string, VerseInfo?[]?[]> booksChapters, string? pre, string? center, string? post)
	{
		var books = converter.Books;
		foreach (var pair in booksChapters)
		{
			var book = pair.Key;
			var chapters = pair.Value;
			var value = new SourceOtherVersesConverter(chapters, pre, center, post);
			books[book] = value;
		}
	}

	public static void SetInitialize(PassagesConverter converter, Dictionary<string, BookConverter> books, Dictionary<string, VerseInfo?[]?[]> booksChapters, string? pre, string? center, string? post)
	{
		foreach (var pair in booksChapters)
		{
			var book = pair.Key;
			var chapters = pair.Value;
			var value = new SourceOtherVersesConverter(chapters, pre, center, post);
			books[book] = value;
			converter.Initialize(value);
		}
	}

	private readonly string? pre;
	private readonly string? center;
	private readonly string? post;

	public SourceOtherVersesConverter(VerseInfo?[]?[] chapters, string? pre, string? center, string? post)
		: base(chapters)
	{
		this.pre = pre;
		this.center = center;
		this.post = post;
	}

	public override void Initialize(PassagesConverter converter)
	{
	}

	public override void Begin(PassagesConverter converter)
	{
		base.Begin(converter);

		converter.Builder.Append(pre);
	}

	public override void Chapter(PassagesConverter converter)
	{
		Chapter(converter.Builder, converter);
		if (!TryGetChapter(converter.OpenChapterValue, out var chapterInfos))
		{
			converter.SetErrored();
			return;
		}
		Chapter(converter.TempBuilder, chapterInfos);
	}

	public override void Chapters(PassagesConverter converter)
	{
		if (!TryGetChapter(converter.OpenChapterValue, out var open))
		{
			converter.SetErrored();
			return;
		}
		var builder = converter.Builder;
		ChaptersOpen(builder, converter);
		if (!TryGetChapter(converter.CloseChapterValue, out var close))
		{
			converter.SetErrored();
			return;
		}
		ChaptersClose(builder, converter);
		Chapters(converter.TempBuilder, open, close);
	}

	public override void ChapterVerse(PassagesConverter converter)
	{
		if (!TryGetVerse(converter.OpenChapterValue, converter.OpenVerseValue, out var otherInfo))
		{
			converter.SetErrored();
			return;
		}
		ChapterVerse(converter.Builder, converter);
		ChapterVerse(converter.TempBuilder, otherInfo);
	}

	public override void ChapterVerses(PassagesConverter converter)
	{
		if (!TryGetVerse(converter.OpenChapterValue, converter.OpenVerseValue, out var openInfo))
		{
			converter.SetErrored();
			return;
		}
		var builder = converter.Builder;
		ChapterVersesOpen(builder, converter);
		if (!TryGetVerse(converter.OpenChapterValue, converter.CloseVerseValue, out var closeInfo))
		{
			converter.SetErrored();
			return;
		}
		ChapterVersesClose(builder, converter);
		ChapterVerses(converter.TempBuilder, openInfo, closeInfo);
	}

	public override void Verse(PassagesConverter converter)
	{
		Verse(converter.Builder, converter);
		if (!TryGetVerse(converter.OpenChapterValue, converter.OpenVerseValue, out var otherInfo))
		{
			converter.SetErrored();
			return;
		}
		Verse(converter.TempBuilder, otherInfo);
	}

	public override void Verses(PassagesConverter converter)
	{
		if (!TryGetVerse(converter.OpenChapterValue, converter.OpenVerseValue, out var openInfo))
		{
			converter.SetErrored();
			return;
		}
		var builder = converter.Builder;
		VersesOpen(builder, converter);
		if (!TryGetVerse(converter.OpenChapterValue, converter.CloseVerseValue, out var closeInfo))
		{
			converter.SetErrored();
			return;
		}
		VersesClose(builder, converter);
		Verses(converter.TempBuilder, openInfo, closeInfo);
	}

	public override void ChaptersVerses(PassagesConverter converter)
	{
		if (!TryGetVerse(converter.OpenChapterValue, converter.OpenVerseValue, out var openInfo))
		{
			converter.SetErrored();
			return;
		}
		var builder = converter.Builder;
		ChaptersVersesOpen(builder, converter);
		if (!TryGetVerse(converter.CloseChapterValue, converter.CloseVerseValue, out var closeInfo))
		{
			converter.SetErrored();
			return;
		}
		ChaptersVersesClose(builder, converter);
		ChaptersVerses(converter.TempBuilder, openInfo, closeInfo);
	}

	public override void Additional(PassagesConverter converter)
	{
		converter.Builder.Append(',');
		converter.TempBuilder.Append(',');
	}

	public override void Error(PassagesConverter converter, StringBuilder value)
	{
		converter.Builder.Append(value);
	}

	public override void Error(PassagesConverter converter, char value)
	{
		converter.Builder.Append(value);
	}

	public override void End(PassagesConverter converter)
	{
		var builder = converter.Builder;
		builder.Append(center);
		builder.Append(converter.TempBuilder);
		builder.Append(post);
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

public sealed class NewVersesConverter : VersesConverter
{
	public static void Set(Dictionary<string, BookConverter> books, Dictionary<string, VerseInfo?[]?[]> booksChapters, string? pre, string? post)
	{
		foreach (var pair in booksChapters)
		{
			var book = pair.Key;
			var chapters = pair.Value;
			var value = new NewVersesConverter(chapters, pre, post);
			books[book] = value;
		}
	}

	public static void Set(PassagesConverter converter, Dictionary<string, VerseInfo?[]?[]> booksChapters, string? pre, string? post)
	{
		var books = converter.Books;
		foreach (var pair in booksChapters)
		{
			var book = pair.Key;
			var chapters = pair.Value;
			var value = new NewVersesConverter(chapters, pre, post);
			books[book] = value;
		}
	}

	public static void SetInitialize(PassagesConverter converter, Dictionary<string, BookConverter> books, Dictionary<string, VerseInfo?[]?[]> booksChapters, string? pre, string? post)
	{
		foreach (var pair in booksChapters)
		{
			var book = pair.Key;
			var chapters = pair.Value;
			var value = new NewVersesConverter(chapters, pre, post);
			books[book] = value;
			converter.Initialize(value);
		}
	}

	private readonly string? pre;
	private readonly string? post;

	public NewVersesConverter(VerseInfo?[]?[] chapters, string? pre, string? post)
		: base(chapters)
	{
		this.pre = pre;
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
		if (!TryGetChapter(converter.OpenChapterValue, out var chapterInfos))
		{
			converter.SetErrored();
			return;
		}
		Chapter(converter.Builder, chapterInfos);
	}

	public override void Chapters(PassagesConverter converter)
	{
		if (!TryGetChapter(converter.OpenChapterValue, out var open) ||
			!TryGetChapter(converter.CloseChapterValue, out var close))
		{
			converter.SetErrored();
			return;
		}
		Chapters(converter.Builder, open, close);
	}

	public override void ChapterVerse(PassagesConverter converter)
	{
		if (!TryGetVerse(converter.OpenChapterValue, converter.OpenVerseValue, out var info))
		{
			converter.SetErrored();
			return;
		}
		ChapterVerse(converter.Builder, info);
	}

	public override void ChapterVerses(PassagesConverter converter)
	{
		if (!TryGetVerse(converter.OpenChapterValue, converter.OpenVerseValue, out var openInfo) ||
			!TryGetVerse(converter.OpenChapterValue, converter.CloseVerseValue, out var closeInfo))
		{
			converter.SetErrored();
			return;
		}
		ChapterVerses(converter.Builder, openInfo, closeInfo);
	}

	public override void Verse(PassagesConverter converter)
	{
		if (!TryGetVerse(converter.OpenChapterValue, converter.OpenVerseValue, out var otherInfo))
		{
			converter.SetErrored();
			return;
		}
		Verse(converter.Builder, otherInfo);
	}

	public override void Verses(PassagesConverter converter)
	{
		if (!TryGetVerse(converter.OpenChapterValue, converter.OpenVerseValue, out var openInfo) ||
			!TryGetVerse(converter.OpenChapterValue, converter.CloseVerseValue, out var closeInfo))
		{
			converter.SetErrored();
			return;
		}
		Verses(converter.Builder, openInfo, closeInfo);
	}

	public override void ChaptersVerses(PassagesConverter converter)
	{
		if (!TryGetVerse(converter.OpenChapterValue, converter.OpenVerseValue, out var openInfo) ||
			!TryGetVerse(converter.CloseChapterValue, converter.CloseVerseValue, out var closeInfo))
		{
			converter.SetErrored();
			return;
		}
		ChaptersVerses(converter.Builder, openInfo, closeInfo);
	}

	public override void Additional(PassagesConverter converter)
	{
		converter.Builder.Append(',');
	}

	public override void Error(PassagesConverter converter, StringBuilder value)
	{
		//Nothing on purpose
	}

	public override void Error(PassagesConverter converter, char value)
	{
		//Nothing on purpose
	}

	public override void End(PassagesConverter converter)
	{
		converter.Builder.Append(post);
	}
}

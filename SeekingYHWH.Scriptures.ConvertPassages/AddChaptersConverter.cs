using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SeekingYHWH.Scriptures;

public sealed class AddChaptersConverter : BookConverter
{
	private readonly string? sourcePre;
	private readonly string? sourcePost;
	private readonly string? othersPre;
	private readonly string?[] othersHeaders;
	private readonly Chapters?[]?[] othersChapters;
	private readonly string? othersPost;

	private readonly bool[] othersContains;
	private readonly bool[] othersError;
	private readonly SortedSet<int>[] othersInclude;
	private readonly bool[] othersIncludeError;

	public AddChaptersConverter(string? sourcePre, string? sourcePost, string? othersPre, string?[] othersHeaders, Chapters?[]?[] othersChapters, string? othersPost)
		: base()
	{
		this.sourcePre = sourcePre;
		this.sourcePost = sourcePost;
		this.othersPre = othersPre;
		this.othersHeaders = othersHeaders;
		this.othersChapters = othersChapters;
		this.othersPost = othersPost;

		var count = othersHeaders.Length;
		this.othersContains = new bool[count];
		this.othersError = new bool[count];
		this.othersInclude = new SortedSet<int>[count];
		for (var i = this.othersInclude.Length - 1; i >= 0; --i)
		{
			if (this.othersHeaders[i] == null)
			{
				continue;
			}

			this.othersInclude[i] = new SortedSet<int>();
		}
		this.othersIncludeError = new bool[count];
	}

	public override void Initialize(PassagesConverter converter)
	{
		for (var i = othersHeaders.Length - 1; i >= 0; --i)
		{
			if (othersHeaders[i] == null)
			{
				continue;
			}

			converter.InitializeBuilder(i);
		}
	}

	public override void Begin(PassagesConverter converter)
	{
		converter.Builder.Append(sourcePre);
		var builders = converter.Builders;
		for (var i = othersHeaders.Length - 1; i >= 0; --i)
		{
			othersContains[i] = false;
			othersError[i] = false;
			var otherHeader = othersHeaders[i];
			if (otherHeader == null)
			{
				continue;
			}
			var builder = builders[i];
			builder.Append(othersPre);
			builder.Append(otherHeader);
			builder.Append(' ');
		}
	}

	public override void Chapter(PassagesConverter converter)
	{
		if (!TryGetChapter(converter.OpenChapterValue, out var othersChapter))
		{
			converter.SetErrored();
			return;
		}
		Chapter(converter.Builder, converter);
		OthersChapter(converter, othersChapter);
	}

	public override void Chapters(PassagesConverter converter)
	{
		OthersChaptersClear();

		var builder = converter.Builder;
		var closeChapter = converter.CloseChapterValue;
		var chapter = converter.OpenChapterValue;
		var open = 0;
		while (true)
		{
			if (!TryGetChapter(chapter, out var othersChapter))
			{
				converter.SetErrored();

				if (open > 0)
				{
					var prev = chapter - 1;
					if (prev > open)
					{
						builder.Append('-');
						builder.Append(prev);
					}
					builder.Append('&');
					open = -1;
				}
				else if (open == 0)
				{
					builder.Append('&');
					open = -1;
				}
			}
			else
			{
				if (open <= 0)
				{
					builder.Append(chapter);
					open = chapter;
				}
				OthersChaptersAdd(othersChapter);
			}

			//Next
			++chapter;
			if (chapter > closeChapter)
			{
				if (open > 0)
				{
					var prev = chapter - 1;
					if (prev > open)
					{
						builder.Append('-');
						builder.Append(prev);
					}
				}
				OthersChaptersWrite(converter);
				return;
			}
		}
	}

	public override void ChapterVerse(PassagesConverter converter)
	{
		if (!TryGetChapter(converter.OpenChapterValue, out var othersChapter))
		{
			converter.SetErrored();
			return;
		}
		ChapterVerse(converter.Builder, converter);
		OthersChapter(converter, othersChapter);
	}

	public override void ChapterVerses(PassagesConverter converter)
	{
		if (!TryGetChapter(converter.OpenChapterValue, out var othersChapter))
		{
			converter.SetErrored();
			return;
		}
		ChapterVerses(converter.Builder, converter);
		OthersChapter(converter, othersChapter);
	}

	public override void Verse(PassagesConverter converter)
	{
		if (!TryGetChapter(converter.OpenChapterValue, out var othersChapter))
		{
			converter.SetErrored();
			return;
		}
		Verse(converter.Builder, converter);
		OthersChapter(converter, othersChapter);
	}

	public override void Verses(PassagesConverter converter)
	{
		if (!TryGetChapter(converter.OpenChapterValue, out var othersChapter))
		{
			converter.SetErrored();
			return;
		}
		Verses(converter.Builder, converter);
		OthersChapter(converter, othersChapter);
	}

	public override void ChaptersVerses(PassagesConverter converter)
	{
		OthersChaptersClear();

		var builder = converter.Builder;
		var openChapter = converter.OpenChapterValue;
		var closeChapter = converter.CloseChapterValue;
		int open;//|

		if (TryGetChapter(openChapter, out var othersChapter))
		{
			builder.Append(converter.OpenChapterBuilder);
			builder.Append(':');
			builder.Append(converter.OpenVerseBuilder);
			OthersChaptersAdd(othersChapter);
			open = openChapter;
		}
		else
		{
			converter.SetErrored();
			builder.Append('&');
			open = -1;
		}

		for (var chapter = openChapter + 1; chapter < closeChapter; ++chapter)
		{
			if (!TryGetChapter(chapter, out othersChapter))
			{
				converter.SetErrored();

				if (open > 0)
				{
					var prev = chapter - 1;
					if (prev > open)
					{
						builder.Append('-');
						builder.Append(prev);
					}
					builder.Append('&');
					open = -1;
				}
				else if (open == 0)
				{
					builder.Append('&');
					open = -1;
				}
			}
			else
			{
				if (open <= 0)
				{
					builder.Append(chapter);
					open = chapter;
				}
				OthersChaptersAdd(othersChapter);
			}
		}

		if (TryGetChapter(closeChapter, out othersChapter))
		{
			if (open > 0 && open != openChapter)
			{
				builder.Append(':');
				builder.Append('1');
			}
			builder.Append('-');
			builder.Append(converter.CloseChapterBuilder);
			builder.Append(':');
			builder.Append(converter.CloseVerseBuilder);
		}
		else
		{
			converter.SetErrored();
			if (open > 0)
			{
				builder.Append('&');
			}
		}

		OthersChaptersWrite(converter);
	}

	public override void Error(PassagesConverter converter, StringBuilder value)
	{
		converter.Builder.Append(value);
	}

	public override void Error(PassagesConverter converter, char value)
	{
		converter.Builder.Append(value);
	}

	public override void Additional(PassagesConverter converter)
	{
		converter.Builder.Append(',');
		var builders = converter.Builders;
		for (var i = othersHeaders.Length - 1; i >= 0; --i)
		{
			var builder = builders[i];
			builder.Append(',');
		}
	}

	public override void End(PassagesConverter converter)
	{
		var builder = converter.Builder;
		builder.Append(sourcePost);
		var builders = converter.Builders;
		for (var i = 0; i < othersHeaders.Length; ++i)
		{
			if (!othersContains[i])
			{
				continue;
			}
			if (othersError[i])
			{
				converter.SetErrored();
			}
			builder.Append(builders[i]);
			builder.Append(othersPost);
		}
	}

	private bool TryGetChapter(int chapter, out Chapters?[]? value)
	{
		if (chapter < othersChapters.Length)
		{
			var v = value = othersChapters[chapter];
			return v != null;
		}
		value = null;
		return false;
	}

	private void OthersChapter(PassagesConverter converter, Chapters?[]? othersChapter)
	{
		var builders = converter.Builders;
		for (var i = othersHeaders.Length - 1; i >= 0; --i)
		{
			var otherHeader = othersHeaders[i];
			if (otherHeader == null)
			{
				continue;
			}
			var otherChapter = othersChapter[i];
			if (otherChapter == null)
			{
				othersError[i] = true;
				continue;
			}
			othersContains[i] = true;
			var otherBuilder = builders[i];
			otherChapter.Append(otherBuilder);
		}
	}

	private void OthersChaptersClear()
	{
		for (var i = othersInclude.Length - 1; i >= 0; --i)
		{
			othersInclude[i]?.Clear();
			othersIncludeError[i] = false;
		}
	}

	private void OthersChaptersAdd(Chapters?[]? othersChapter)
	{
		for (var i = othersHeaders.Length - 1; i >= 0; --i)
		{
			var otherHeader = othersHeaders[i];
			if (otherHeader == null)
			{
				continue;
			}
			var otherChapter = othersChapter[i];
			if (otherChapter == null)
			{
				othersError[i] = true;
				othersIncludeError[i] = true;
				continue;
			}
			otherChapter.Add(othersInclude[i]);
		}
	}

	private void OthersChaptersWrite(PassagesConverter converter)
	{
		for (var i = othersHeaders.Length - 1; i >= 0; --i)
		{
			var otherInclude = othersInclude[i];
			if (otherInclude == null || otherInclude.Count <= 0)
			{
				continue;
			}
			var otherBuilder = converter.Builders[i];
			using (var enumerator = otherInclude.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					continue;
				}
				othersContains[i] = true;
				var otherOpen = enumerator.Current;
				var otherLast = otherOpen;
				otherBuilder.Append(otherOpen);
				while (enumerator.MoveNext())
				{
					var current = enumerator.Current;
					if (current == otherLast + 1)
					{
						otherLast = current;
					}
					else
					{
						if (otherOpen != otherLast)
						{
							otherBuilder.Append('-');
							otherBuilder.Append(otherLast);
						}
						otherBuilder.Append('&');
						otherBuilder.Append(current);
						otherOpen = otherLast = current;
					}
				}
				if (otherOpen != otherLast)
				{
					otherBuilder.Append('-');
					otherBuilder.Append(otherLast);
				}
			}
			if (othersIncludeError[i])
			{
				otherBuilder.Append('&');
			}
		}
	}
}

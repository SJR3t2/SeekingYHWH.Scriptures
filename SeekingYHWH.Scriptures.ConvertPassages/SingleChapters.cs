using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

public sealed class SingleChapters : Chapters
{
	private readonly int chapter;

	public SingleChapters(int chapter)
		: base()
	{
		this.chapter = chapter;
	}

	public int Chapter => chapter;

	public override void Append(StringBuilder builder)
	{
		builder.Append(chapter);
	}

	public override void Add(SortedSet<int> values)
	{
		values.Add(chapter);
	}

	public override string ToString()
	{
		var value = chapter.ToString();
		return value;
	}
}

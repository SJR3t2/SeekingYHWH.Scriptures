using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

public sealed class TwoChapters : Chapters
{
	private readonly int one;
	private readonly int two;

	public TwoChapters(int one, int two)
		: base()
	{
		this.one = one;
		this.two = two;
	}

	public int One => one;
	public int Two => two;

	public override void Append(StringBuilder builder)
	{
		builder.Append(one);
		builder.Append('+');
		builder.Append(two);
	}

	public override void Add(SortedSet<int> values)
	{
		values.Add(one);
		values.Add(two);
	}

	public override string ToString()
	{
		var value = one.ToString() + "+" + two.ToString();
		return value;
	}
}

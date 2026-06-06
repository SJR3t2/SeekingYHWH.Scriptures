using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

public sealed class RangeChapters : Chapters
{
	private readonly int open;
	private readonly int close;

	public RangeChapters(int open, int close)
		: base()
	{
		this.open = open;
		this.close = close;
	}

	public int Open => open;
	public int Close => close;

	public override void Append(StringBuilder builder)
	{
		builder.Append(open);
		builder.Append('-');
		builder.Append(close);
	}

	public override void Add(SortedSet<int> values)
	{
		var value = open;
		while (true)
		{
			values.Add(value);

			++value;
			if (value > close)
			{
				break;
			}	
		}
	}

	public override string ToString()
	{
		var value = open.ToString() + "-" + close.ToString();
		return value;
	}
}

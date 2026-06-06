using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

public abstract class Chapters
{
	internal Chapters()
	{
	}

	public abstract void Append(StringBuilder builder);

	public abstract void Add(SortedSet<int> values);
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

partial class Searcher
{
	private sealed class Matchs
	{
		public static int OffsetAscendingComparison(Matchs x, Matchs y)
		{
			if (x.book == y.book)
			{
				if (x.offset == y.offset)
				{
					return 0;
				}
				if (x.offset > y.offset)
				{
					return +1;
				}
				else
				{
					return -1;
				}
			}
			if (x.book > y.book)
			{
				return +1;
			}
			else
			{
				return -1;
			}
		}

		private readonly int book;
		private readonly long offset;
		private readonly IEnumerable<string> values;

		public Matchs(int book, long offset, IEnumerable<string> values)
		{
			this.book = book;
			this.offset = offset;
			this.values = values;
		}

		public int Book => book;
		public long Offset => offset;
		public IEnumerable<string> Values => values;
	}
}

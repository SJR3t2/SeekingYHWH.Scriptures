using System;
using System.Collections.Generic;
using System.Text;

namespace LDSGospelSearch
{
	public sealed class SearchMatch
	{
		#region Class Methods
		public static int OffsetAscendingCompare(SearchMatch x, SearchMatch y)
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
		#endregion //Class Methods

		#region Fields
		private readonly long offset;
		private readonly LinkedList<string> values = new LinkedList<string>();
		#endregion //Fields

		#region Constructors
		public SearchMatch(long offset)
		{
			this.offset = offset;
		}
		#endregion //Constructors

		#region Properties
		public long Offset => offset;
		public LinkedList<string> Values => values;
		#endregion //Properties
	}
}

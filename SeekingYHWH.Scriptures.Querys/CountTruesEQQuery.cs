using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountTruesEQQuery : CountQuery
	{
		#region Constructors
		public CountTruesEQQuery(int count, Query[] predicates)
			: base(count, predicates)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			var value = CountTrues();
			return value == count;
		}
		#endregion //Methods
	}
}

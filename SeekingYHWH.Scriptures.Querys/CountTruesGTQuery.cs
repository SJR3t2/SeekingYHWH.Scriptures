using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountTruesGTQuery : CountQuery
	{
		#region Constructors
		public CountTruesGTQuery(int count, Query[] predicates)
			: base(count, predicates)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			var value = CountTrues();
			return value > count;
		}
		#endregion //Methods
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountTruesLTQuery : CountQuery
	{
		#region Constructors
		public CountTruesLTQuery(int count, Query[] predicates)
			: base(count, predicates)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			var value = CountTrues();
			return value < count;
		}
		#endregion //Methods
	}
}

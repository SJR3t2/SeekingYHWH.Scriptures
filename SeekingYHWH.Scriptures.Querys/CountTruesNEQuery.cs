using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountTruesNEQuery : CountQuery
	{
		#region Constructors
		public CountTruesNEQuery(int count, Query[] predicates)
			: base(count, predicates)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			var value = CountTrues();
			return value != count;
		}
		#endregion //Methods
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountFalsesLEQuery : CountQuery
	{
		#region Constructors
		public CountFalsesLEQuery(int count, Query[] predicates)
			: base(count, predicates)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			var value = CountFalses();
			return value <= count;
		}
		#endregion //Methods
	}
}

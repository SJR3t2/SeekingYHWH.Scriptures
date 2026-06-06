using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountFalsesEQQuery : CountQuery
	{
		#region Constructors
		public CountFalsesEQQuery(int count, Query[] predicates)
			: base(count, predicates)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			var value = CountFalses();
			return value == count;
		}
		#endregion //Methods
	}
}

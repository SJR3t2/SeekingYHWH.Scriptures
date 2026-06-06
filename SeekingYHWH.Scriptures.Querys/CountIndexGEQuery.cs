using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountIndexGEQuery : CountIndexQuery
	{
		#region Constructors
		public CountIndexGEQuery(int count, string text, StringComparison comparison)
			: base(count, text, comparison)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			return value >= count;
		}
		#endregion //Methods
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountRegexLTQuery : CountRegexQuery
	{
		#region Constructors
		public CountRegexLTQuery(int count, Regex regex)
			: base(count, regex)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			return value < count;
		}
		#endregion //Methods
	}
}

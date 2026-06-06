using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountRegexGEQueryProvider : CountRegexQueryProvider
	{
		#region Constructors
		public CountRegexGEQueryProvider(int count, string pattern, RegexOptions options)
			: base(count, pattern, options)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var regex = new Regex(pattern, options);
			var query = new CountRegexGEQuery(count, regex);
			return query;
		}
		#endregion //Methods
	}
}

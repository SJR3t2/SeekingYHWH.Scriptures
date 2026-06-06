using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SeekingYHWH.Scriptures
{
	public abstract class CountRegexQueryProvider : QueryProvider
	{
		#region Fields
		protected readonly int count;
		protected readonly string pattern;
		protected readonly RegexOptions options;
		#endregion //Fields

		#region Constructors
		protected CountRegexQueryProvider(int count, string pattern, RegexOptions options)
			: base()
		{
			this.count = count;
			this.pattern = pattern;
			this.options = options;
		}
		#endregion //Constructors

		#region Properties
		public int Count => count;
		public string Pattern => pattern;
		public RegexOptions Options => options;
		#endregion //Properties
	}
}

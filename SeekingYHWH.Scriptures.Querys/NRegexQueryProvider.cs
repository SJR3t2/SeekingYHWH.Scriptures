using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SeekingYHWH.Scriptures
{
	public sealed class NRegexQueryProvider : QueryProvider
	{
		#region Fields
		private readonly string pattern;
		private readonly RegexOptions options;
		#endregion //Fields

		#region Constructors
		public NRegexQueryProvider(string pattern, RegexOptions options)
			: base()
		{
			this.pattern = pattern;
			this.options = options;
		}
		#endregion //Constructors

		#region Properties
		public string Pattern => pattern;
		public RegexOptions Options => options;
		#endregion //Properties

		#region Methods
		public override Query Create()
		{
			var regex = new Regex(pattern, options);
			var predicate = new NRegexQuery(regex);
			return predicate;
		}
		#endregion //Methods
	}
}

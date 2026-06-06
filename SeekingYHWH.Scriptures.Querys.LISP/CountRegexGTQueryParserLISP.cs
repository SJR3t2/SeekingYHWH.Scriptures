using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountRegexGTQueryParserLISP : CountRegexQueryParserLISP
	{
		#region Constants
		public const string Query = "CountRegexGT";
		#endregion //Constants

		#region Class Methods
		public static CountRegexGTQueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new CountRegexGTQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountRegexGTQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(out QueryProvider provider)
		{
			if (!TryParse(out var count, out var pattern, out var options))
			{
				provider = default;
				return false;
			}
			provider = new CountRegexGTQueryProvider(count, pattern, options); ;
			return true;
		}
		#endregion //Methods
	}
}

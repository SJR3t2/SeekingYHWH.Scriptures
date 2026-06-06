using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountRegexLEQueryParserLISP : CountRegexQueryParserLISP
	{
		#region Constants
		public const string Query = "CountRegexLE";
		#endregion //Constants

		#region Class Methods
		public static CountRegexLEQueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new CountRegexLEQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountRegexLEQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new CountRegexLEQueryProvider(count, pattern, options); ;
			return true;
		}
		#endregion //Methods
	}
}

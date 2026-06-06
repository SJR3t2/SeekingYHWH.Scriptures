using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountRegexNEQueryParserLISP : CountRegexQueryParserLISP
	{
		#region Constants
		public const string Query = "CountRegexNE";
		#endregion //Constants

		#region Class Methods
		public static CountRegexNEQueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new CountRegexNEQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountRegexNEQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new CountRegexNEQueryProvider(count, pattern, options); ;
			return true;
		}
		#endregion //Methods
	}
}

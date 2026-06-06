using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountRegexGEQueryParserLISP : CountRegexQueryParserLISP
	{
		#region Constants
		public const string Query = "CountRegexGE";
		#endregion //Constants

		#region Class Methods
		public static CountRegexGEQueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new CountRegexGEQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountRegexGEQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new CountRegexGEQueryProvider(count, pattern, options); ;
			return true;
		}
		#endregion //Methods
	}
}

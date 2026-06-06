using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountTruesEQQueryParserLISP : CountQueryParserLISP
	{
		#region Constants
		public const string Query = "CountTruesEQ";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new CountTruesEQQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountTruesEQQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(out QueryProvider provider)
		{
			if (!TryParseCountProviders(out var count, out var providers))
			{
				provider = null;
				return false;
			}
			if (count < 0)
			{
				parser.AddError("Count needs to be >= 0");
				provider = null;
				return false;
			}
			provider = new CountTruesEQQueryProvider(count, providers);
			return true;
		}
		#endregion //Methods
	}
}

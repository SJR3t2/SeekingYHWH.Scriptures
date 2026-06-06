using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountTruesLTQueryParserLISP : CountQueryParserLISP
	{
		#region Constants
		public const string Query = "CountTruesLT";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new CountTruesLTQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountTruesLTQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new CountTruesLTQueryProvider(count, providers);
			return true;
		}
		#endregion //Methods
	}
}

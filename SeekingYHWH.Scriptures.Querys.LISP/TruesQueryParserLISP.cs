using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class TruesQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "Trues";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new TruesQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public TruesQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(out QueryProvider provider)
		{
			if (!TryParseProviders(out var providers))
			{
				provider = null;
				return false;
			}
			provider = new TruesQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

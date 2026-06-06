using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NTruesQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "NTrues";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new NTruesQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NTruesQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new NTruesQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

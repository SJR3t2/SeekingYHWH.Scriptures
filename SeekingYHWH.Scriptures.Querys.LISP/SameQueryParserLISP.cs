using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class SameQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "Same";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new SameQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public SameQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new SameQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

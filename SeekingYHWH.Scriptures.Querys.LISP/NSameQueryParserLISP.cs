using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NSameQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "NSame";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new NSameQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NSameQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new NSameQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

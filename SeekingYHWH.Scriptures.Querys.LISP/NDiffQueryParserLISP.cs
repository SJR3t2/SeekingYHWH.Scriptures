using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NDiffQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "NDiff";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new NDiffQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NDiffQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new NDiffQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

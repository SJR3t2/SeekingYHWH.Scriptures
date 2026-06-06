using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NEqualsQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "NEquals";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new NEqualsQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NEqualsQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new NEqualsQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

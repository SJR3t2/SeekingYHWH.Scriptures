using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class EqualsQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "Equals";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new EqualsQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public EqualsQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new EqualsQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

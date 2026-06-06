using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class AndQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "And";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new AndQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public AndQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new AndQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

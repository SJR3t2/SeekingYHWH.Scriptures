using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class OrQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "Or";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new OrQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public OrQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new OrQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

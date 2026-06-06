using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NOrQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "NOr";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new NOrQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NOrQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new NOrQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

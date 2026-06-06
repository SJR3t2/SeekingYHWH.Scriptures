using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NAndQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "NAnd";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new NAndQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NAndQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new NAndQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class FalsesQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "Falses";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new FalsesQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public FalsesQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new FalsesQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

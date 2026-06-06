using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NFalsesQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "NFalses";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new NFalsesQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NFalsesQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new NFalsesQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

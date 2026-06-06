using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NotQueryParserLISP : SingleQueryParserLISP
	{
		#region Constants
		public const string Query = "Not";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new NotQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NotQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(out QueryProvider provider)
		{
			if (!TryParseProvider(out var providerProvider))
			{
				provider = null;
				return false;
			}
			provider = new NotQueryProvider(providerProvider);
			return true;
		}
		#endregion //Methods
	}
}

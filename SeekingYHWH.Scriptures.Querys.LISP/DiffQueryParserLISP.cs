using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class DiffQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constants
		public const string Query = "Diff";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new DiffQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public DiffQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new DiffQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

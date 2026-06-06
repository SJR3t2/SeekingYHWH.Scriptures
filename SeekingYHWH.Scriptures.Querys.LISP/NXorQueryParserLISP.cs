using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NXorQueryParserLISP : DoubleQueryParserLISP
	{
		#region Constants
		public const string Query = "NXor";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new NXorQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NXorQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(out QueryProvider provider)
		{
			if (!TryParseProviders(out var x, out var y))
			{
				provider = null;
				return false;
			}
			provider = new NXorQueryProvider(x, y);
			return true;
		}
		#endregion //Methods
	}
}

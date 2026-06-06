using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class XorQueryParserLISP : DoubleQueryParserLISP
	{
		#region Constants
		public const string Query = "Xor";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new XorQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public XorQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new XorQueryProvider(x, y);
			return true;
		}
		#endregion //Methods
	}
}

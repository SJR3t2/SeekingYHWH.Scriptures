using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountIndexLTQueryParserLISP : CountIndexQueryParserLISP
	{
		#region Constants
		public const string Query = "CountIndexLT";
		#endregion //Constants

		#region Class Methods
		public static CountIndexLTQueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new CountIndexLTQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountIndexLTQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(out QueryProvider provider)
		{
			if (!TryParse(out var count, out var text, out var comparison))
			{
				provider = default;
				return false;
			}
			provider = new CountIndexLTQueryProvider(count, text, comparison);
			return true;
		}
		#endregion //Methods
	}
}

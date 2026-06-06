using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountIndexGTQueryParserLISP : CountIndexQueryParserLISP
	{
		#region Constants
		public const string Query = "CountIndexGT";
		#endregion //Constants

		#region Class Methods
		public static CountIndexGTQueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new CountIndexGTQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountIndexGTQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new CountIndexGTQueryProvider(count, text, comparison);
			return true;
		}
		#endregion //Methods
	}
}

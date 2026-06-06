using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountIndexGEQueryParserLISP : CountIndexQueryParserLISP
	{
		#region Constants
		public const string Query = "CountIndexGE";
		#endregion //Constants

		#region Class Methods
		public static CountIndexGEQueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new CountIndexGEQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountIndexGEQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new CountIndexGEQueryProvider(count, text, comparison);
			return true;
		}
		#endregion //Methods
	}
}

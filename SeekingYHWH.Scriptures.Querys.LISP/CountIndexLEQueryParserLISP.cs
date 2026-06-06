using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountIndexLEQueryParserLISP : CountIndexQueryParserLISP
	{
		#region Constants
		public const string Query = "CountIndexLEQ";
		#endregion //Constants

		#region Class Methods
		public static CountIndexLEQueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new CountIndexLEQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountIndexLEQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new CountIndexLEQueryProvider(count, text, comparison);
			return true;
		}
		#endregion //Methods
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountIndexEQQueryParserLISP : CountIndexQueryParserLISP
	{
		#region Constants
		public const string Query = "CountIndexEQ";
		#endregion //Constants

		#region Class Methods
		public static CountIndexEQQueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new CountIndexEQQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountIndexEQQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new CountIndexEQQueryProvider(count, text, comparison);
			return true;
		}
		#endregion //Methods
	}
}

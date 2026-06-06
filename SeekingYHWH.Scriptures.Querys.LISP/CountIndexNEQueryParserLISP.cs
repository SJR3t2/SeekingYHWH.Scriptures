using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountIndexNEQueryParserLISP : CountIndexQueryParserLISP
	{
		#region Constants
		public const string Query = "CountIndexNE";
		#endregion //Constants

		#region Class Methods
		public static CountIndexNEQueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new CountIndexNEQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountIndexNEQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new CountIndexNEQueryProvider(count, text, comparison);
			return true;
		}
		#endregion //Methods
	}
}

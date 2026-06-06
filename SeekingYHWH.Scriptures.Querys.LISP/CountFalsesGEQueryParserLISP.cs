using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountFalsesGEQueryParserLISP : CountQueryParserLISP
	{
		#region Constants
		public const string Query = "CountFalsesGE";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new CountFalsesGEQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountFalsesGEQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(out QueryProvider provider)
		{
			if (!TryParseCountProviders(out var count, out var providers))
			{
				provider = null;
				return false;
			}
			if (count < 0)
			{
				parser.AddError("Count needs to be >= 0");
				provider = null;
				return false;
			}
			provider = new CountFalsesGEQueryProvider(count, providers);
			return true;
		}
		#endregion //Methods
	}
}

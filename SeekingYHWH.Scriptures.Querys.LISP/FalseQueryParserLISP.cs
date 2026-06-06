using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class FalseQueryParserLISP : ConstantQueryParserLISP
	{
		#region Constants
		public const string Query = "False";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new FalseQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public FalseQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(out QueryProvider provider)
		{
			if (!TryParseEmpty())
			{
				parser.AddError("Must be empty");
				provider = null;
				return false;
			}
			provider = new FalseQueryProvider();
			return true;
		}
		#endregion //Methods
	}
}

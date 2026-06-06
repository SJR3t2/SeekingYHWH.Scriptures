using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class TrueQueryParserLISP : ConstantQueryParserLISP
	{
		#region Constants
		public const string Query = "True";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new TrueQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public TrueQueryParserLISP(QueryParserLISPParser parser)
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
			provider = new TrueQueryProvider();
			return true;
		}
		#endregion //Methods
	}
}

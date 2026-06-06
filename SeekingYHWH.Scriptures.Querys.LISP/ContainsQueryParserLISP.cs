using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class ContainsQueryParserLISP : QueryParserLISP
	{
		#region Constants
		public const string Query = "Contains";
		#endregion //Constants

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new ContainsQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public ContainsQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(out QueryProvider provider)
		{
			if (!parser.TryParseString(out var contains))
			{
				parser.AddError("Missing Contains");
				provider = null;
				return false;
			}
			if (!parser.NextToken(out var token))
			{
				provider = new ContainsQueryProvider(contains);
				return true;
			}
			if (token != ')')
			{
				parser.AddError("Invalid token: " + token.ToString());
				provider = null;
				return false;
			}
			else
			{
				parser.NextToken();
				provider = new ContainsQueryProvider(contains);
				return true;
			}
		}
		#endregion //Methods
	}
}

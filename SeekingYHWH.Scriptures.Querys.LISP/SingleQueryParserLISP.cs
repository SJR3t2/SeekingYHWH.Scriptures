using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class SingleQueryParserLISP : QueryParserLISP
	{
		#region Constructors
		protected SingleQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		protected bool TryParseProvider(out QueryProvider provider)
		{
			if (!parser.TryParse(out provider))
			{
				parser.AddError("Missing Predicate");
				return false;
			}
			if (!parser.NextToken(out var token))
			{
				return true;
			}
			if (token == ')')
			{
				parser.NextToken();
				return true;
			}
			else
			{
				parser.AddError("Invalid token: " + token.ToString());
				return false;
			}
		}
		#endregion //Methods
	}
}

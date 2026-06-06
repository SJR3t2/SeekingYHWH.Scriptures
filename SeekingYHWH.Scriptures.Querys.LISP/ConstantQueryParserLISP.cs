using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class ConstantQueryParserLISP : QueryParserLISP
	{
		#region Constructors
		protected ConstantQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		protected bool TryParseEmpty()
		{
			if (!parser.NextToken(out var token))
			{
				return true;
			}
			if (token == ')')
			{
				parser.NextToken();
				return true;
			}
			return false;
		}
		#endregion //Methods
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class DoubleQueryParserLISP : QueryParserLISP
	{
		#region Constructors
		protected DoubleQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		protected bool TryParseProviders(out QueryProvider x, out QueryProvider y)
		{
			if (!parser.TryParse(out x))
			{
				parser.AddError("Missing X");
				x = null;
				y = null;
				return false;
			}
			if (!parser.NextToken(out var token))
			{
				parser.AddError("Missing ,");
				x = null;
				y = null;
				return false;
			}
			parser.NextToken();
			if (!parser.TryParse(out y))
			{
				parser.AddError("Missing Y");
				x = null;
				y = null;
				return false;
			}
			if (parser.NextToken(out token))
			{
				return true;
			}
			if (token != ')')
			{
				parser.AddError("Missing ): " + token.ToString());
				x = null;
				y = null;
				return false;
			}
			else
			{
				parser.NextToken();
				return true;
			}
		}
		#endregion //Methods
	}
}

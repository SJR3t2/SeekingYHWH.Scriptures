using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class MultipleQueryParserLISP : QueryParserLISP
	{
		#region Constructors
		protected MultipleQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		protected bool TryParseProviders(out QueryProvider[] providers)
		{
			if (!parser.TryParse(out var provider))
			{
				parser.AddError("Need atleast one Predicate");
				providers = null;
				return false;
			}
			if (!parser.NextToken(out var token))
			{
				providers = new QueryProvider[1] { provider };
				return true;
			}
			if (token == ')')
			{
				parser.NextToken();
				providers = new QueryProvider[1] { provider };
				return true;
			}
			if (token != ',')
			{
				parser.AddError("Invalid token: " + token.ToString());
				providers = null;
				return false;
			}
			parser.NextToken();
			var values = new List<QueryProvider>();
			values.Add(provider);
			while (true)
			{
				if (!parser.TryParse(out provider))
				{
					parser.AddError("Invalid Predicate");
					providers = null;
					return false;
				}
				values.Add(provider);
				if (!parser.NextToken(out token))
				{
					break;
				}
				if (token == ')')
				{
					parser.NextToken();
					break;
				}
				if (token != ',')
				{
					parser.AddError("Invalid token: " + token.ToString());
					providers = null;
					return false;
				}
				parser.NextToken();
			}
			providers = values.ToArray();
			return true;
		}
		#endregion //Methods
	}
}

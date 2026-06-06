using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public abstract class CountQueryParserLISP : MultipleQueryParserLISP
	{
		#region Constructors
		protected CountQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		protected bool TryParseCountProviders(out int count, out QueryProvider[] providers)
		{
			var success = true;
			if (!TryParseCount(out count))
			{
				success = false;
			}
			if (!parser.NextToken(out var token))
			{
				parser.AddError("Requires Predicates");
				count = default;
				providers = null;
				return false;
			}
			if (token != ',')
			{
				parser.AddError("Invalid Token: " + token.ToString());
				count = default;
				providers = null;
				return false;
			}
			parser.NextToken();
			if (!TryParseProviders(out providers))
			{
				success = false;
			}
			return success;
		}

		protected bool TryParseCount(out int count)
		{
			return parser.TryParseInt32(out count);
		}
		#endregion //Methods
	}
}

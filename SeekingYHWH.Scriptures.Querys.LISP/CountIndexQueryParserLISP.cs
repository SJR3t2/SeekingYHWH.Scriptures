using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class CountIndexQueryParserLISP : QueryParserLISP
	{
		#region Class Fields
		private static readonly Dictionary<string, StringComparison> comparisions = new Dictionary<string, StringComparison>(StringComparer.InvariantCultureIgnoreCase)
		{
			{ "CurrentCulture", StringComparison.CurrentCulture },
			{ "CurrentCultureIgnoreCase", StringComparison.CurrentCultureIgnoreCase },
			{ "InvariantCulture", StringComparison.InvariantCulture },
			{ "InvariantCultureIgnoreCase", StringComparison.InvariantCultureIgnoreCase },
			{ "Ordinal", StringComparison.Ordinal },
			{ "OrdinalIgnoreCase", StringComparison.OrdinalIgnoreCase },
		};
		#endregion //Class Fields

		#region Constructors
		protected CountIndexQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		protected bool TryParse(out int count, out string text, out StringComparison comparison)
		{
			if (!TryParseCount(out count))
			{
				parser.AddError("Requires Count");
				text = default;
				comparison = default;
				return false;
			}
			if (!parser.NextToken(out var token))
			{
				parser.AddError("Requires Text");
				text = default;
				comparison = default;
				return false;
			}
			if (token != ',')
			{
				parser.AddError("Invalid Token: " + token.ToString());
				text = default;
				comparison = default;
				return false;
			}
			parser.NextToken();
			if (!parser.TryParseString(out text))
			{
				parser.AddError("Missing Text");
				comparison = default;
				return false;
			}

			if (!parser.NextToken(out token))
			{
				comparison = StringComparison.CurrentCultureIgnoreCase;
				return true;
			}
			if (token == ')')
			{
				parser.NextToken();
				comparison = StringComparison.CurrentCultureIgnoreCase;
				return true;
			}
			if (token != ',')
			{
				parser.AddError("Invalid token: " + token.ToString());
				comparison = default;
				return false;
			}
			parser.NextToken();
			if (!parser.TryParseEnumSingle(comparisions, StringComparison.CurrentCultureIgnoreCase, out comparison))
			{
				parser.AddError("Invalid String Comparison");
				return false;
			}
			if (!parser.NextToken(out token))
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

		protected bool TryParseCount(out int count)
		{
			return parser.TryParseInt32(out count);
		}
		#endregion //Methods
	}
}

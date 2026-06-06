using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SeekingYHWH.Scriptures
{
	public abstract class CountRegexQueryParserLISP : QueryParserLISP
	{
		#region Class Fields
		protected static readonly Dictionary<string, RegexOptions> optionss = new Dictionary<string, RegexOptions>(StringComparer.InvariantCultureIgnoreCase)
		{
			{ "IgnoreCase", RegexOptions.IgnoreCase },
			{ "None", RegexOptions.None },
		};
		#endregion //Class Fields

		#region Constructors
		protected CountRegexQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		protected bool TryParse(out int count, out string pattern, out RegexOptions options)
		{
			if (!TryParseCount(out count))
			{
				parser.AddError("Requires Count");
				pattern = default;
				options = default;
				return false;
			}
			if (!parser.NextToken(out var token))
			{
				parser.AddError("Requires Pattern");
				pattern = default;
				options = default;
				return false;
			}
			if (token != ',')
			{
				parser.AddError("Invalid Token: " + token.ToString());
				pattern = default;
				options = default;
				return false;
			}
			parser.NextToken();
			if (!parser.TryParseString(out pattern))
			{
				parser.AddError("Missing Pattern");
				options = default;
				return false;
			}

			if (!parser.NextToken(out token))
			{
				options = RegexOptions.IgnoreCase;
				if (!RegexValid(pattern, RegexOptions.IgnoreCase))
				{
					parser.AddError("Invalid Pattern");
					return false;
				}
				return true;
			}
			if (token == ')')
			{
				options = RegexOptions.IgnoreCase;
				parser.NextToken();
				if (!RegexValid(pattern, RegexOptions.IgnoreCase))
				{
					parser.AddError("Invalid Pattern");
					return false;
				}
				return true;
			}
			if (token != ',')
			{
				parser.AddError("Invalid token: " + token.ToString());
				options = default;
				return false;
			}
			parser.NextToken();
			if (!parser.TryParseEnumSingle(optionss, RegexOptions.IgnoreCase, out options))
			{
				parser.AddError("Invalid Regex Option");
				return false;
			}
			if (!parser.NextToken(out token))
			{
				if (!RegexValid(pattern, options))
				{
					parser.AddError("Invalid Pattern");
					return false;
				}
				return true;
			}
			if (token == ')')
			{
				if (!RegexValid(pattern, options))
				{
					parser.AddError("Invalid Pattern");
					return false;
				}
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

		protected static bool RegexValid(string pattern, RegexOptions options)
		{
			try
			{
				new Regex(pattern, options);
				return true;
			}
			catch
			{
				return false;
			}
		}
		#endregion //Methods
	}
}

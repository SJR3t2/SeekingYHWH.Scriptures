using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SeekingYHWH.Scriptures
{
	public sealed class NRegexQueryParserLISP : QueryParserLISP
	{
		#region Constants
		public const string Query = "NRegex";
		#endregion //Constants

		#region Class Fields
		private static readonly Dictionary<string, RegexOptions> optionss = new Dictionary<string, RegexOptions>()
		{
			{ "IgnoreCase", RegexOptions.IgnoreCase },
			{ "None", RegexOptions.None },
		};
		#endregion //Class Fields

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new NRegexQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NRegexQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(out QueryProvider provider)
		{
			if (!parser.TryParseString(out var pattern))
			{
				parser.AddError("Missing Pattern");
				provider = null;
				return false;
			}

			if (!parser.NextToken(out var token))
			{
				if (!RegexValid(pattern, RegexOptions.IgnoreCase))
				{
					parser.AddError("Invalid Pattern");
					provider = null;
					return false;
				}
				provider = new NRegexQueryProvider(pattern, RegexOptions.IgnoreCase);
				return true;
			}
			if (token == ')')
			{
				parser.NextToken();
				if (!RegexValid(pattern, RegexOptions.IgnoreCase))
				{
					parser.AddError("Invalid Pattern");
					provider = null;
					return false;
				}
				provider = new NRegexQueryProvider(pattern, RegexOptions.IgnoreCase);
				return true;
			}
			if (token != ',')
			{
				parser.AddError("Invalid token: " + token.ToString());
				provider = null;
				return false;
			}
			parser.NextToken();
			if (!parser.TryParseEnumSingle(optionss, RegexOptions.IgnoreCase, out var options))
			{
				parser.AddError("Invalid Regex Option");
				provider = null;
				return false;
			}
			if (!parser.NextToken(out token))
			{
				if (!RegexValid(pattern, options))
				{
					parser.AddError("Invalid Pattern");
					provider = null;
					return false;
				}
				provider = new NRegexQueryProvider(pattern, options);
				return true;
			}
			if (token == ')')
			{
				if (!RegexValid(pattern, options))
				{
					parser.AddError("Invalid Pattern");
					provider = null;
					return false;
				}
				parser.NextToken();
				provider = new NRegexQueryProvider(pattern, options);
				return true;
			}
			else
			{
				parser.AddError("Invalid token: " + token.ToString());
				provider = null;
				return false;
			}
		}

		private static bool RegexValid(string pattern, RegexOptions options)
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

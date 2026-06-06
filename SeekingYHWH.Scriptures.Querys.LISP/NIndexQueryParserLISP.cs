using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NIndexQueryParserLISP : QueryParserLISP
	{
		#region Constants
		public const string Query = "NIndex";
		#endregion //Constants

		#region Class Fields
		private static readonly Dictionary<string, StringComparison> comparisions = new Dictionary<string, StringComparison>()
		{
			{ "CurrentCulture", StringComparison.CurrentCulture },
			{ "CurrentCultureIgnoreCase", StringComparison.CurrentCultureIgnoreCase },
			{ "InvariantCulture", StringComparison.InvariantCulture },
			{ "InvariantCultureIgnoreCase", StringComparison.InvariantCultureIgnoreCase },
			{ "Ordinal", StringComparison.Ordinal },
			{ "OrdinalIgnoreCase", StringComparison.OrdinalIgnoreCase },
		};
		#endregion //Class Fields

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new NIndexQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NIndexQueryParserLISP(QueryParserLISPParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(out QueryProvider provider)
		{
			if (!parser.TryParseString(out var text))
			{
				parser.AddError("Missing Text");
				provider = null;
				return false;
			}

			if (!parser.NextToken(out var token))
			{
				provider = new NIndexQueryProvider(text, StringComparison.CurrentCultureIgnoreCase);
				return true;
			}
			if (token == ')')
			{
				parser.NextToken();
				provider = new NIndexQueryProvider(text, StringComparison.CurrentCultureIgnoreCase);
				return true;
			}
			if (token != ',')
			{
				parser.AddError("Invalid token: " + token.ToString());
				provider = null;
				return false;
			}
			parser.NextToken();
			if (!parser.TryParseEnumSingle(comparisions, StringComparison.CurrentCultureIgnoreCase, out var comparision))
			{
				parser.AddError("Invalid String Comparison");
				provider = null;
				return false;
			}
			if (!parser.NextToken(out token))
			{
				provider = new NIndexQueryProvider(text, comparision);
				return true;
			}
			if (token == ')')
			{
				parser.NextToken();
				provider = new NIndexQueryProvider(text, comparision);
				return true;
			}
			else
			{
				parser.AddError("Invalid token: " + token.ToString());
				provider = null;
				return false;
			}
		}
		#endregion //Methods
	}
}

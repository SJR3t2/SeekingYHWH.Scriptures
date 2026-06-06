using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class IndexQueryParserLISP : QueryParserLISP
	{
		#region Constants
		public const string Query = "Index";
		#endregion //Constants

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

		#region Class Methods
		public static QueryParserLISP Create(QueryParserLISPParser parser)
		{
			return new IndexQueryParserLISP(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public IndexQueryParserLISP(QueryParserLISPParser parser)
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
				provider = new IndexQueryProvider(text, StringComparison.CurrentCultureIgnoreCase);
				return true;
			}
			if (token == ')')
			{
				parser.NextToken();
				provider = new IndexQueryProvider(text, StringComparison.CurrentCultureIgnoreCase);
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
				provider = new IndexQueryProvider(text, comparision);
				return true;
			}
			if (token == ')')
			{
				parser.NextToken();
				provider = new IndexQueryProvider(text, comparision);
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

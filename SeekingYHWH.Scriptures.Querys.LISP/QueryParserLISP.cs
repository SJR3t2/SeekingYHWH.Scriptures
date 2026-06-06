using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class QueryParserLISP
	{
		#region Class Fields
		private static readonly Dictionary<string, Converter<QueryParserLISPParser, QueryParserLISP>> parsers = new Dictionary<string, Converter<QueryParserLISPParser, QueryParserLISP>>(StringComparer.InvariantCultureIgnoreCase)
		{
			{ AndQueryParserLISP.Query, AndQueryParserLISP.Create },
			{ OrQueryParserLISP.Query, OrQueryParserLISP.Create },
			{ XorQueryParserLISP.Query, XorQueryParserLISP.Create },
			{ NotQueryParserLISP.Query, NotQueryParserLISP.Create },
			{ NAndQueryParserLISP.Query, NAndQueryParserLISP.Create },
			{ NOrQueryParserLISP.Query, NOrQueryParserLISP.Create },
			{ NXorQueryParserLISP.Query, NXorQueryParserLISP.Create },
			{ EqualsQueryParserLISP.Query, EqualsQueryParserLISP.Create },
			{ SameQueryParserLISP.Query, SameQueryParserLISP.Create },
			{ DiffQueryParserLISP.Query, DiffQueryParserLISP.Create },
			{ TruesQueryParserLISP.Query, TruesQueryParserLISP.Create },
			{ FalsesQueryParserLISP.Query, FalsesQueryParserLISP.Create },
			{ NEqualsQueryParserLISP.Query, NEqualsQueryParserLISP.Create },
			{ NSameQueryParserLISP.Query, NSameQueryParserLISP.Create },
			{ NDiffQueryParserLISP.Query, NDiffQueryParserLISP.Create },
			{ NTruesQueryParserLISP.Query, NTruesQueryParserLISP.Create },
			{ NFalsesQueryParserLISP.Query, NFalsesQueryParserLISP.Create },
			{ CountTruesLTQueryParserLISP.Query, CountTruesLTQueryParserLISP.Create },
			{ CountTruesLEQueryParserLISP.Query, CountTruesLEQueryParserLISP.Create },
			{ CountTruesEQQueryParserLISP.Query, CountTruesEQQueryParserLISP.Create },
			{ CountTruesNEQueryParserLISP.Query, CountTruesNEQueryParserLISP.Create },
			{ CountTruesGEQueryParserLISP.Query, CountTruesGEQueryParserLISP.Create },
			{ CountTruesGTQueryParserLISP.Query, CountTruesGTQueryParserLISP.Create },
			{ CountFalsesLTQueryParserLISP.Query, CountFalsesLTQueryParserLISP.Create },
			{ CountFalsesLEQueryParserLISP.Query, CountFalsesLEQueryParserLISP.Create },
			{ CountFalsesEQQueryParserLISP.Query, CountFalsesEQQueryParserLISP.Create },
			{ CountFalsesNEQueryParserLISP.Query, CountFalsesNEQueryParserLISP.Create },
			{ CountFalsesGEQueryParserLISP.Query, CountFalsesGEQueryParserLISP.Create },
			{ CountFalsesGTQueryParserLISP.Query, CountFalsesGTQueryParserLISP.Create },
			{ CountRegexEQQueryParserLISP.Query, CountRegexEQQueryParserLISP.Create },
			{ CountRegexGEQueryParserLISP.Query, CountRegexGEQueryParserLISP.Create },
			{ CountRegexGTQueryParserLISP.Query, CountRegexGTQueryParserLISP.Create },
			{ CountRegexLEQueryParserLISP.Query, CountRegexLEQueryParserLISP.Create },
			{ CountRegexLTQueryParserLISP.Query, CountRegexLTQueryParserLISP.Create },
			{ CountRegexNEQueryParserLISP.Query, CountRegexNEQueryParserLISP.Create },
			{ CountIndexEQQueryParserLISP.Query, CountIndexEQQueryParserLISP.Create },
			{ CountIndexGEQueryParserLISP.Query, CountIndexGEQueryParserLISP.Create },
			{ CountIndexGTQueryParserLISP.Query, CountIndexGTQueryParserLISP.Create },
			{ CountIndexLEQueryParserLISP.Query, CountIndexLEQueryParserLISP.Create },
			{ CountIndexLTQueryParserLISP.Query, CountIndexLTQueryParserLISP.Create },
			{ CountIndexNEQueryParserLISP.Query, CountIndexNEQueryParserLISP.Create },
			{ RegexQueryParserLISP.Query, RegexQueryParserLISP.Create },
			{ IndexQueryParserLISP.Query, IndexQueryParserLISP.Create },
			{ ContainsQueryParserLISP.Query, ContainsQueryParserLISP.Create },
			{ NRegexQueryParserLISP.Query, NRegexQueryParserLISP.Create },
			{ NIndexQueryParserLISP.Query, NIndexQueryParserLISP.Create },
			{ NContainsQueryParserLISP.Query, NContainsQueryParserLISP.Create },
			{ TrueQueryParserLISP.Query, TrueQueryParserLISP.Create },
			{ FalseQueryParserLISP.Query, FalseQueryParserLISP.Create },
		};
		#endregion //Class Fields

		#region Class Methods
		public static bool TryParse(string parse, out QueryProvider provider, out List<string> errors)
		{
			var parser = new QueryParserLISPParser(parsers, parse);
			if (parser.TryParse(out provider))
			{
				errors = null;
				return true;
			}
			else
			{
				errors = parser.Errors;
				return false;
			}
		}
		#endregion //Class Methods

		#region Fields
		protected readonly QueryParserLISPParser parser;
		#endregion //Fields

		#region Constructors
		protected QueryParserLISP(QueryParserLISPParser parser)
		{
			this.parser = parser;
		}
		#endregion //Constructors

		#region Methods
		public abstract bool TryParse(out QueryProvider provider);
		#endregion //Methods
	}
}

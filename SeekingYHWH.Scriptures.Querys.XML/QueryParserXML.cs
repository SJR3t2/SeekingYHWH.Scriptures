using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public abstract class QueryParserXML
	{
		#region Class Fields
		private static readonly Dictionary<string, Converter<QueryParserXMLParser, QueryParserXML>> parsers = new Dictionary<string, Converter<QueryParserXMLParser, QueryParserXML>>(StringComparer.InvariantCultureIgnoreCase)
		{
			{ AndQueryParserXML.Query, AndQueryParserXML.Create },
			{ OrQueryParserXML.Query, OrQueryParserXML.Create },
			{ XorQueryParserXML.Query, XorQueryParserXML.Create },
			{ NotQueryParserXML.Query, NotQueryParserXML.Create },
			{ NAndQueryParserXML.Query, NAndQueryParserXML.Create },
			{ NOrQueryParserXML.Query, NOrQueryParserXML.Create },
			{ NXorQueryParserXML.Query, NXorQueryParserXML.Create },
			{ EqualsQueryParserXML.Query, EqualsQueryParserXML.Create },
			{ SameQueryParserXML.Query, SameQueryParserXML.Create },
			{ DiffQueryParserXML.Query, DiffQueryParserXML.Create },
			{ TruesQueryParserXML.Query, TruesQueryParserXML.Create },
			{ FalsesQueryParserXML.Query, FalsesQueryParserXML.Create },
			{ NEqualsQueryParserXML.Query, NEqualsQueryParserXML.Create },
			{ NSameQueryParserXML.Query, NSameQueryParserXML.Create },
			{ NDiffQueryParserXML.Query, NDiffQueryParserXML.Create },
			{ NTruesQueryParserXML.Query, NTruesQueryParserXML.Create },
			{ NFalsesQueryParserXML.Query, NFalsesQueryParserXML.Create },
			{ CountTruesLTQueryParserXML.Query, CountTruesLTQueryParserXML.Create },
			{ CountTruesLEQueryParserXML.Query, CountTruesLEQueryParserXML.Create },
			{ CountTruesEQQueryParserXML.Query, CountTruesEQQueryParserXML.Create },
			{ CountTruesNEQueryParserXML.Query, CountTruesNEQueryParserXML.Create },
			{ CountTruesGEQueryParserXML.Query, CountTruesGEQueryParserXML.Create },
			{ CountTruesGTQueryParserXML.Query, CountTruesGTQueryParserXML.Create },
			{ CountFalsesLTQueryParserXML.Query, CountFalsesLTQueryParserXML.Create },
			{ CountFalsesLEQueryParserXML.Query, CountFalsesLEQueryParserXML.Create },
			{ CountFalsesEQQueryParserXML.Query, CountFalsesEQQueryParserXML.Create },
			{ CountFalsesNEQueryParserXML.Query, CountFalsesNEQueryParserXML.Create },
			{ CountFalsesGEQueryParserXML.Query, CountFalsesGEQueryParserXML.Create },
			{ CountFalsesGTQueryParserXML.Query, CountFalsesGTQueryParserXML.Create },
			{ CountRegexEQQueryParserXML.Query, CountRegexEQQueryParserXML.Create },
			{ CountRegexGEQueryParserXML.Query, CountRegexGEQueryParserXML.Create },
			{ CountRegexGTQueryParserXML.Query, CountRegexGTQueryParserXML.Create },
			{ CountRegexLEQueryParserXML.Query, CountRegexLEQueryParserXML.Create },
			{ CountRegexLTQueryParserXML.Query, CountRegexLTQueryParserXML.Create },
			{ CountRegexNEQueryParserXML.Query, CountRegexNEQueryParserXML.Create },
			{ RegexQueryParserXML.Query, RegexQueryParserXML.Create },
			{ IndexQueryParserXML.Query, IndexQueryParserXML.Create },
			{ ContainsQueryParserXML.Query, ContainsQueryParserXML.Create },
			{ NRegexQueryParserXML.Query, NRegexQueryParserXML.Create },
			{ NIndexQueryParserXML.Query, NIndexQueryParserXML.Create },
			{ NContainsQueryParserXML.Query, NContainsQueryParserXML.Create },
			{ TrueQueryParserXML.Query, TrueQueryParserXML.Create },
			{ FalseQueryParserXML.Query, FalseQueryParserXML.Create },
		};
		#endregion //Class Fields

		#region Class Methods
		public static bool TryParsePath(string path, out QueryProvider provider, out List<string> errors)
		{
			var doc = new XmlDocument();
			doc.Load(path);
			var config = doc.DocumentElement;
			return TryParse(config, out provider, out errors);
		}

		public static bool TryParse(XmlNode config, out QueryProvider provider, out List<string> errors)
		{
			var parser = new QueryParserXMLParser(parsers);
			if (parser.TryParse(config, out provider))
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
		protected readonly QueryParserXMLParser parser;
		#endregion //Fields

		#region Constructors
		protected QueryParserXML(QueryParserXMLParser parser)
		{
			this.parser = parser;
		}
		#endregion //Constructors

		#region Methods
		public abstract bool TryParse(XmlNode config, out QueryProvider provider);
		#endregion //Methods
	}
}

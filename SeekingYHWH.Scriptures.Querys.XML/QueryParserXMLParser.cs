using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class QueryParserXMLParser : QueryParserParser
	{
		#region Fields
		private readonly Dictionary<string, Converter<QueryParserXMLParser, QueryParserXML>> parsers;
		private readonly List<string> errors = new List<string>();
		#endregion //Fields

		#region Constructors
		public QueryParserXMLParser(Dictionary<string, Converter<QueryParserXMLParser, QueryParserXML>> parsers)
			: base()
		{
			this.parsers = parsers;
		}
		#endregion //Constructors

		#region Methods
		public bool TryParse(XmlNode config, out QueryProvider provider)
		{
			var typeConfig = config.Attributes["Type"];
			if (typeConfig == null)
			{
				errors.Add("Missing Type Attribute");
				provider = null;
				return false;
			}
			var type = typeConfig.InnerText;
			if (!parsers.TryGetValue(type, out var creator))
			{
				errors.Add("Invalid Type");
				provider = null;
				return false;
			}
			var parser = creator(this);
			return parser.TryParse(config, out provider);
		}
		#endregion //Methods
	}
}

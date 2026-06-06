using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountRegexNEQueryParserXML : CountRegexQueryParserXML
	{
		#region Constants
		public const string Query = "CountRegexNE";
		#endregion //Constants

		#region Class Methods
		public static CountRegexNEQueryParserXML Create(QueryParserXMLParser parser)
		{
			return new CountRegexNEQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountRegexNEQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(XmlNode config, out QueryProvider provider)
		{
			if (!TryParse(config, out var count, out var pattern, out var options))
			{
				provider = default;
				return false;
			}
			provider = new CountRegexNEQueryProvider(count, pattern, options);
			return true;
		}
		#endregion //Methods
	}
}

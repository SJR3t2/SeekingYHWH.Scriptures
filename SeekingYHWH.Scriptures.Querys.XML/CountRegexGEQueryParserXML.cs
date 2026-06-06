using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountRegexGEQueryParserXML : CountRegexQueryParserXML
	{
		#region Constants
		public const string Query = "CountRegexGE";
		#endregion //Constants

		#region Class Methods
		public static CountRegexGEQueryParserXML Create(QueryParserXMLParser parser)
		{
			return new CountRegexGEQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountRegexGEQueryParserXML(QueryParserXMLParser parser)
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
			provider = new CountRegexGEQueryProvider(count, pattern, options);
			return true;
		}
		#endregion //Methods
	}
}

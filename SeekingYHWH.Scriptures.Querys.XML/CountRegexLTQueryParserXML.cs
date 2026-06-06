using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountRegexLTQueryParserXML : CountRegexQueryParserXML
	{
		#region Constants
		public const string Query = "CountRegexLT";
		#endregion //Constants

		#region Class Methods
		public static CountRegexLTQueryParserXML Create(QueryParserXMLParser parser)
		{
			return new CountRegexLTQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountRegexLTQueryParserXML(QueryParserXMLParser parser)
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
			provider = new CountRegexLTQueryProvider(count, pattern, options);
			return true;
		}
		#endregion //Methods
	}
}

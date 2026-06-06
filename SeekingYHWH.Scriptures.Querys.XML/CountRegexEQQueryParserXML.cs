using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountRegexEQQueryParserXML : CountRegexQueryParserXML
	{
		#region Constants
		public const string Query = "CountRegexEQ";
		#endregion //Constants

		#region Class Methods
		public static CountRegexEQQueryParserXML Create(QueryParserXMLParser parser)
		{
			return new CountRegexEQQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountRegexEQQueryParserXML(QueryParserXMLParser parser)
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
			provider = new CountRegexEQQueryProvider(count, pattern, options);
			return true;
		}
		#endregion //Methods
	}
}

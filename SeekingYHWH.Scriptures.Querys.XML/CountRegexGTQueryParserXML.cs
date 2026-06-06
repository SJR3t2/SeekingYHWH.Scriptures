using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountRegexGTQueryParserXML : CountRegexQueryParserXML
	{
		#region Constants
		public const string Query = "CountRegexGT";
		#endregion //Constants

		#region Class Methods
		public static CountRegexGTQueryParserXML Create(QueryParserXMLParser parser)
		{
			return new CountRegexGTQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountRegexGTQueryParserXML(QueryParserXMLParser parser)
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
			provider = new CountRegexGTQueryProvider(count, pattern, options);
			return true;
		}
		#endregion //Methods
	}
}

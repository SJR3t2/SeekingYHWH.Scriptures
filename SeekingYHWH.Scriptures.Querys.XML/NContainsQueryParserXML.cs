using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class NContainsQueryParserXML : QueryParserXML
	{
		#region Constants
		public const string Query = "NContains";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new NContainsQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NContainsQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(XmlNode config, out QueryProvider provider)
		{
			var textConfig = config.SelectSingleNode("Text");
			if (textConfig == null)
			{
				parser.AddError("Missing Text");
				provider = null;
				return false;
			}
			var text = textConfig.InnerText;
			if (string.IsNullOrWhiteSpace(text))
			{
				parser.AddError("Invalid text");
				provider = null;
				return false;
			}
			provider = new NContainsQueryProvider(text);
			return true;
		}
		#endregion //Methods
	}
}

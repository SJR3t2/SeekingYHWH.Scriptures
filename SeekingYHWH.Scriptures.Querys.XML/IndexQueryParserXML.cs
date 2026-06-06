using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class IndexQueryParserXML : QueryParserXML
	{
		#region Constants
		public const string Query = "Index";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new IndexQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public IndexQueryParserXML(QueryParserXMLParser parser)
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
			var comparisonConfig = config.SelectSingleNode("Comparison");
			StringComparison comparison;
			if (comparisonConfig != null)
			{
				if (!Enum.TryParse(comparisonConfig.InnerText, out comparison))
				{
					parser.AddError("Invalid Comparison: " + comparisonConfig.InnerText);
					provider = null;
					return false;
				}
			}
			else
			{
				comparison = StringComparison.CurrentCultureIgnoreCase;
			}
			provider = new IndexQueryProvider(text, comparison);
			return true;
		}
		#endregion //Methods
	}
}

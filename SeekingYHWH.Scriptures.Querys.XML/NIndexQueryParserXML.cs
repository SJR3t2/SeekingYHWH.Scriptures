using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class NIndexQueryParserXML : QueryParserXML
	{
		#region Constants
		public const string Query = "NIndex";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new NIndexQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NIndexQueryParserXML(QueryParserXMLParser parser)
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
			provider = new NIndexQueryProvider(text, comparison);
			return true;
		}
		#endregion //Methods
	}
}

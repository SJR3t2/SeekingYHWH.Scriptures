using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public abstract class CountQueryParserXML : MultipleQueryParserXML
	{
		#region Constructors
		protected CountQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		protected bool TryParseCountProviders(XmlNode config, out int count, out QueryProvider[] providers)
		{
			var success = true;
			if (!TryParseCount(config, out count))
			{
				success = false;
			}
			if (!TryParseProviders(config, out providers))
			{
				success = false;
			}
			return success;
		}

		protected bool TryParseCount(XmlNode config, out int count)
		{
			var countConfig = config.SelectSingleNode("Count");
			if (countConfig == null)
			{
				parser.AddError("Missing Count");
				count = default;
				return false;
			}
			var countText = countConfig.InnerText;
			if (!int.TryParse(countText, out count))
			{
				parser.AddError("Invalid Count");
				return false;
			}
			return true;
		}
		#endregion //Methods
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public abstract class SingleQueryParserXML : QueryParserXML
	{
		#region Constructors
		protected SingleQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		protected bool TryParseProvider(XmlNode config, out QueryProvider provider)
		{
			config = config.SelectSingleNode("Query");
			if (config == null)
			{
				parser.AddError("Missing Query");
				provider = null;
				return false;
			}
			return parser.TryParse(config, out provider);
		}
		#endregion //Methods
	}
}

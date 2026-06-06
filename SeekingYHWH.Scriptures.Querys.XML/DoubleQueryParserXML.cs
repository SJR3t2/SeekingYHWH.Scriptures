using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public abstract class DoubleQueryParserXML : QueryParserXML
	{
		#region Constructors
		protected DoubleQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		protected bool TryParseProviders(XmlNode config, out QueryProvider x, out QueryProvider y)
		{
			var configs = config.SelectNodes("Query");
			if (configs.Count != 2)
			{
				parser.AddError("Must have only 2 Queries");
				x = null;
				y = null;
				return false;
			}

			var success = true;
			if (!parser.TryParse(configs[0], out x))
			{
				parser.AddError("Invalid Query X");
				success = false;
			}
			if (!parser.TryParse(configs[1], out y))
			{
				parser.AddError("Invalid Query Y");
				success = false;
			}
			return success;
		}
		#endregion //Methods
	}
}

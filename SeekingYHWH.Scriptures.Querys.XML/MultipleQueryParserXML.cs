using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public abstract class MultipleQueryParserXML : QueryParserXML
	{
		#region Constructors
		protected MultipleQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		protected bool TryParseProviders(XmlNode config, out QueryProvider[] querys)
		{
			var values = new List<QueryProvider>();
			foreach (XmlNode node in config.SelectNodes("Query"))
			{
				if (parser.TryParse(node, out var provider))
				{
					values.Add(provider);
				}
				else
				{
					querys = null;
					return false;
				}
			}
			if (values.Count <= 0)
			{
				parser.AddError("Need atleast one Query");
				querys = null;
				return false;
			}
			querys = values.ToArray();
			return true;
		}
		#endregion //Methods
	}
}

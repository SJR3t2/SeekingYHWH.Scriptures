using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public abstract class ConstantQueryParserXML : QueryParserXML
	{
		#region Constructors
		protected ConstantQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		protected bool TryParseEmpty(XmlNode config)
		{
			return true;
		}
		#endregion //Methods
	}
}

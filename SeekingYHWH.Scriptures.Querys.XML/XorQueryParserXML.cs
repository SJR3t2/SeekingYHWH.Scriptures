using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class XorQueryParserXML : DoubleQueryParserXML
	{
		#region Constants
		public const string Query = "Xor";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new XorQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public XorQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(XmlNode config, out QueryProvider provider)
		{
			if (!TryParseProviders(config, out var x, out var y))
			{
				provider = null;
				return false;
			}
			provider = new XorQueryProvider(x, y);
			return true;
		}
		#endregion //Methods
	}
}

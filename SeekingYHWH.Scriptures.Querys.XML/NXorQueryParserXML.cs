using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class NXorQueryParserXML : DoubleQueryParserXML
	{
		#region Constants
		public const string Query = "NXor";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new NXorQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NXorQueryParserXML(QueryParserXMLParser parser)
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
			provider = new NXorQueryProvider(x, y);
			return true;
		}
		#endregion //Methods
	}
}

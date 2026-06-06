using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class SameQueryParserXML : MultipleQueryParserXML
	{
		#region Constants
		public const string Query = "Same";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new SameQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public SameQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(XmlNode config, out QueryProvider provider)
		{
			if (!TryParseProviders(config, out var providers))
			{
				provider = null;
				return false;
			}
			provider = new SameQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

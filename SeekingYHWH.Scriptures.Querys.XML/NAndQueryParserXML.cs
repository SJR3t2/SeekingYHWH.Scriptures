using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class NAndQueryParserXML : MultipleQueryParserXML
	{
		#region Constants
		public const string Query = "NAnd";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new NAndQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NAndQueryParserXML(QueryParserXMLParser parser)
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
			provider = new NAndQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

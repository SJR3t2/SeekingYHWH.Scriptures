using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class NOrQueryParserXML : MultipleQueryParserXML
	{
		#region Constants
		public const string Query = "NOr";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new NOrQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NOrQueryParserXML(QueryParserXMLParser parser)
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
			provider = new NOrQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

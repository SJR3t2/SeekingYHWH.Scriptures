using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class OrQueryParserXML : MultipleQueryParserXML
	{
		#region Constants
		public const string Query = "Or";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new OrQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public OrQueryParserXML(QueryParserXMLParser parser)
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
			provider = new OrQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

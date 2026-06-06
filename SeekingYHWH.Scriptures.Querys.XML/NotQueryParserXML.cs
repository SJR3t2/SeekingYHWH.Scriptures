using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class NotQueryParserXML : SingleQueryParserXML
	{
		#region Constants
		public const string Query = "Not";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new NotQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NotQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(XmlNode config, out QueryProvider provider)
		{
			if (!TryParseProvider(config, out var providerProvider))
			{
				provider = null;
				return false;
			}
			provider = new NotQueryProvider(providerProvider);
			return true;
		}
		#endregion //Methods
	}
}

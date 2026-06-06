using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class EqualsQueryParserXML : MultipleQueryParserXML
	{
		#region Constants
		public const string Query = "Equals";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new EqualsQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public EqualsQueryParserXML(QueryParserXMLParser parser)
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
			provider = new EqualsQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

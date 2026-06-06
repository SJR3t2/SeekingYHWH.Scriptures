using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class AndQueryParserXML : MultipleQueryParserXML
	{
		#region Constants
		public const string Query = "And";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new AndQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public AndQueryParserXML(QueryParserXMLParser parser)
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
			provider = new AndQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

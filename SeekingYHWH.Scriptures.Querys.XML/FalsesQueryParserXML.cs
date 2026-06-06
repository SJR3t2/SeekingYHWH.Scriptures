using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class FalsesQueryParserXML : MultipleQueryParserXML
	{
		#region Constants
		public const string Query = "Falses";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new FalsesQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public FalsesQueryParserXML(QueryParserXMLParser parser)
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
			provider = new FalsesQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

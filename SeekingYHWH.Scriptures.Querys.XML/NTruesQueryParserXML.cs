using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class NTruesQueryParserXML : MultipleQueryParserXML
	{
		#region Constants
		public const string Query = "NTrues";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new NTruesQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public NTruesQueryParserXML(QueryParserXMLParser parser)
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
			provider = new NTruesQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

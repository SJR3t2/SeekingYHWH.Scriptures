using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountTruesGTQueryParserXML : CountQueryParserXML
	{
		#region Constants
		public const string Query = "CountTruesGT";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new CountTruesGTQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountTruesGTQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(XmlNode config, out QueryProvider provider)
		{
			if (!TryParseCountProviders(config, out var count, out var providers))
			{
				provider = null;
				return false;
			}
			if (count < 0)
			{
				parser.AddError("Count needs to be >= 0");
				provider = null;
				return false;
			}
			provider = new CountTruesGTQueryProvider(count, providers);
			return true;
		}
		#endregion //Methods
	}
}

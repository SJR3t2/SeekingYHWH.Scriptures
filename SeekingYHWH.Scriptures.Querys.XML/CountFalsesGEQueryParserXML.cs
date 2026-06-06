using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountFalsesGEQueryParserXML : CountQueryParserXML
	{
		#region Constants
		public const string Query = "CountFalsesGE";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new CountFalsesGEQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public CountFalsesGEQueryParserXML(QueryParserXMLParser parser)
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
			provider = new CountFalsesGEQueryProvider(count, providers);
			return true;
		}
		#endregion //Methods
	}
}

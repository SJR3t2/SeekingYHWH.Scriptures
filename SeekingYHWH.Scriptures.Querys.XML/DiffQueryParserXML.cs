using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class DiffQueryParserXML : MultipleQueryParserXML
	{
		#region Constants
		public const string Query = "Diff";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new DiffQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public DiffQueryParserXML(QueryParserXMLParser parser)
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
			provider = new DiffQueryProvider(providers);
			return true;
		}
		#endregion //Methods
	}
}

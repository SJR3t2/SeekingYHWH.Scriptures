using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class TrueQueryParserXML : ConstantQueryParserXML
	{
		#region Constants
		public const string Query = "True";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new TrueQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public TrueQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(XmlNode config, out QueryProvider provider)
		{
			if (!TryParseEmpty(config))
			{
				parser.AddError("Must be empty");
				provider = null;
				return false;
			}
			provider = new TrueQueryProvider();
			return true;
		}
		#endregion //Methods
	}
}

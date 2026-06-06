using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public sealed class RegexQueryParserXML : QueryParserXML
	{
		#region Constants
		public const string Query = "Regex";
		#endregion //Constants

		#region Class Methods
		public static QueryParserXML Create(QueryParserXMLParser parser)
		{
			return new RegexQueryParserXML(parser);
		}
		#endregion //Class Methods

		#region Constructors
		public RegexQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool TryParse(XmlNode config, out QueryProvider provider)
		{
			var patternConfig = config.SelectSingleNode("Pattern");
			if (patternConfig == null)
			{
				parser.AddError("Missing Pattern");
				provider = null;
				return false;
			}
			var pattern = patternConfig.InnerText;
			if (string.IsNullOrWhiteSpace(pattern))
			{
				parser.AddError("Invalid Pattern");
				provider = null;
				return false;
			}
			var optionsConfig = config.SelectSingleNode("Options");
			RegexOptions options;
			if (optionsConfig != null && !string.IsNullOrWhiteSpace(optionsConfig.InnerText))
			{
				if (!Enum.TryParse(optionsConfig.InnerText, out options))
				{
					parser.AddError("Invalid Options: " +  optionsConfig.InnerText);
					provider = null;
					return false;
				}
			}
			else
			{
				options = RegexOptions.IgnoreCase;
			}
			if (!RegexValid(pattern, options))
			{
				parser.AddError("Invalid Pattern");
				provider = null;
				return false;
			}
			provider = new RegexQueryProvider(pattern, options);
			return true;
		}

		private static bool RegexValid(string pattern, RegexOptions options)
		{
			try
			{
				new Regex(pattern, options);
				return true;
			}
			catch
			{
				return false;
			}
		}
		#endregion //Methods
	}
}

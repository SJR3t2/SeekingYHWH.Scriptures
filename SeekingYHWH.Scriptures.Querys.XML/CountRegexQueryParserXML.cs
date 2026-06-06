using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace SeekingYHWH.Scriptures
{
	public abstract class CountRegexQueryParserXML : QueryParserXML
	{
		#region Constructors
		protected CountRegexQueryParserXML(QueryParserXMLParser parser)
			: base(parser)
		{
		}
		#endregion //Constructors

		#region Methods
		protected bool TryParse(XmlNode config, out int count, out string pattern, out RegexOptions options)
		{
			var countConfig = config.SelectSingleNode("Count");
			if (countConfig == null)
			{
				parser.AddError("Missing Count");
				count = default;
				pattern = default;
				options = default;
				return false;
			}
			var countText = countConfig.InnerText;
			if (!int.TryParse(countText, out count))
			{
				parser.AddError("Invalid Count");
				pattern = default;
				options = default;
				return false;
			}
			var patternConfig = config.SelectSingleNode("Pattern");
			if (patternConfig == null)
			{
				parser.AddError("Missing Pattern");
				pattern = default;
				options = default;
				return false;
			}
			pattern = patternConfig.InnerText;
			if (string.IsNullOrWhiteSpace(pattern))
			{
				parser.AddError("Invalid Pattern");
				pattern = default;
				options = default;
				return false;
			}
			var optionsConfig = config.SelectSingleNode("Options");
			if (optionsConfig != null && !string.IsNullOrWhiteSpace(optionsConfig.InnerText))
			{
				if (!Enum.TryParse(optionsConfig.InnerText, out options))
				{
					parser.AddError("Invalid Options: " + optionsConfig.InnerText);
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
				return false;
			}
			return true;
		}

		protected static bool RegexValid(string pattern, RegexOptions options)
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using SeekingYHWH.Scriptures.LDSGospelLibrary;

namespace SeekingYHWH.Scriptures.Search.LDSGospelLibrary
{
	internal static class Search
	{
		#region Constants
		private const string verseNumber = "<span class=\"verse-number\">";
		private const string intro = "<p class=\"intro\"";
		private const string bomIntro = "<p class=\"subtitle\" data-aid=\"128354249\"";
		private const string closing = "<p class=\"closing\"";
		private const string summary = "<p class=\"study-summary\"";
		private const string bodyOpen = "<body>";
		private const string bodyClose = "</body>";
		private const string headerOpen = "<header>";
		private const string headerClose = "</header>";
		private const string paragraphOpen = "<p";
		private const string paragraphClose = "</p>";
		private const char period = '.';
		#endregion //Constants

		#region Fields
		private static readonly Dictionary<string, string> renames = new Dictionary<string, string>()
		{
			{ "Doctrine and Covenants", "D&C" },
			{ "Joseph Smith—Matthew", "JSM" },
			{ "Joseph Smith—History", "JSH" },
			{ ",", "" },
		};

		private static readonly Dictionary<string, string> capitalizes = new Dictionary<string, string>()
		{
		};
		#endregion Fields

		#region Methods
		public static void Extract(StreamWriter writer, NavigationInfo value, Extractor extractor)
		{
			var html = value.HTML;
			var bodyO = html.IndexOf(bodyOpen);
			if (bodyO < 0)
			{
				return;
			}
			var bodyC = html.IndexOf(bodyClose, bodyO);
			if (bodyC < 0)
			{
				return;
			}
			var headerC = html.IndexOf(headerClose, bodyO);
			if (headerC < 0 || headerC >= bodyC)
			{
				return;
			}
			extractor.Clear();
			extractor.Append(Rename(value.Title));
			var title = extractor.ToString();
			writer.WriteLine(title);
			for (var s = bodyO + bodyOpen.Length; true;)
			{
				s = html.IndexOf(paragraphOpen, s);
				if (s < 0 || s >= bodyC)
				{
					break;
				}
				var l = html.IndexOf(paragraphClose, s);
				if (l < 0 || l >= bodyC)
				{
					break;
				}
				var length = (l - s) + paragraphClose.Length;
				var header = s < headerC;
				var line = html.Substring(s, length);
				s = l + paragraphClose.Length;
				if (header)
				{
					if (!line.Contains(intro) && !line.Contains(bomIntro))
					{
						continue;
					}
				}
				else
				{
					if (line.Contains(closing) || line.Contains(summary))
					{
						continue;
					}
				}

				extractor.Clear();
				extractor.Extract(line);
				var extracted = extractor.ToString();
				var letters = false;
				foreach (var letter in extracted)
				{
					if (char.IsLetter(letter))
					{
						letters = true;
						break;
					}
				}
				if (!letters)
				{
					continue;
				}
				string titleAppend;
				if (header)
				{
					titleAppend = string.Empty;
				}
				else if (line.IndexOf(verseNumber) >= 0)
				{
					titleAppend = extractor.Verse.ToString().Trim();
				}
				else
				{
					titleAppend = string.Empty;
				}
				var text = titleAppend + "\t" + Capitalize(extracted);

				writer.WriteLine(text);
			}
		}

		private static string Rename(string value)
		{
			foreach (var pair in renames)
			{
				value = value.Replace(pair.Key, pair.Value);
			}
			return value;
		}

		private static string Capitalize(string value)
		{
			foreach (var pair in capitalizes)
			{
				value = value.Replace(pair.Key, pair.Value);
			}
			return value;
		}
		#endregion //Methods
	}
}

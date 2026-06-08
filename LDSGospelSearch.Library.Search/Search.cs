using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LDSGospelSearch
{
	public static class Search
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

		#region Methods
		public static SearchState Sentence(NavigationInfo value, ParallelLoopState parallel, long offset, SearchState state)
		{
			var states = state.States;
			var extractor = state.Extractor;
			var query = state.Query;
			var html = value.HTML;
			var bodyO = html.IndexOf(bodyOpen);
			if (bodyO < 0)
			{
				return state;
			}
			var bodyC = html.IndexOf(bodyClose, bodyO);
			if (bodyC < 0)
			{
				return state;
			}
			var headerC = html.IndexOf(headerClose, bodyO);
			if (headerC < 0 || headerC >= bodyC)
			{
				return state;
			}
			SearchMatch match = null;
			string title = null;
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
					if (!line.Contains(intro))
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
				var extractedLength = extracted.Length;
				var ss = 0;
				string verse = null;
				while (true)
				{
					while (char.IsWhiteSpace(extracted[ss]))
					{
						++ss;
					}
					var se = extracted.IndexOf(period, ss);
					string sentence;
					int sn;
					if (se >= 0)
					{
						sentence = extracted.Substring(ss, (se - ss) + 1);
						sn = se + 1;
					}
					else
					{
						sentence = extracted.Substring(ss);
						sn = extractedLength;
					}
					query.Reset();
					query.Find(sentence);
					if (query.Evaluate())
					{
						string titleAppend;
						if (header)
						{
							titleAppend = ":I ";
						}
						else if (line.IndexOf(verseNumber) >= 0)
						{
							if (verse == null)
							{
								verse = extractor.Verse.ToString();
							}
							if (!char.IsDigit(value.Title[value.Title.Length - 1]))
							{
								titleAppend = " " + verse;
							}
							else
							{
								titleAppend = ":" + verse;
							}
						}
						else
						{
							titleAppend = Environment.NewLine;
						}
						if (match == null)
						{
							match = new SearchMatch(offset);
							extractor.Clear();
							extractor.Append(states.Rename(value.Title));
							title = extractor.ToString();
						}
						var pre = ss > 0 ? "... " : "";
						var pst = sn < extractedLength ? " ..." : "";
						var text = title + titleAppend + pre + states.Capitalize(sentence) + pst;
						match.Values.AddLast(text);
					}
					if (se < 0)
					{
						break;
					}
					if (sn >= extractedLength)
					{
						break;
					}
					ss = sn;
				}
			}
			if (match != null)
			{
				states.MatchsAdd(match);
			}
			return state;
		}

		public static SearchState Verse(NavigationInfo value, ParallelLoopState parallel, long offset, SearchState state)
		{
			var states = state.States;
			var extractor = state.Extractor;
			var query = state.Query;
			var html = value.HTML;
			var bodyO = html.IndexOf(bodyOpen);
			if (bodyO < 0)
			{
				return state;
			}
			var bodyC = html.IndexOf(bodyClose, bodyO);
			if (bodyC < 0)
			{
				return state;
			}
			var headerC = html.IndexOf(headerClose, bodyO);
			if (headerC < 0 || headerC >= bodyC)
			{
				return state;
			}
			SearchMatch match = null;
			string title = null;
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
				query.Reset();
				query.Find(extracted);
				if (query.Evaluate())
				{
					string titleAppend;
					if (header)
					{
						titleAppend = ":I ";
					}
					else if (line.IndexOf(verseNumber) >= 0)
					{
						if (!char.IsDigit(value.Title[value.Title.Length - 1]))
						{
							titleAppend = " " + extractor.Verse.ToString();
						}
						else
						{
							titleAppend = ":" + extractor.Verse.ToString();
						}
					}
					else
					{
						titleAppend = Environment.NewLine;
					}
					if (match == null)
					{
						match = new SearchMatch(offset);
						extractor.Clear();
						extractor.Append(states.Rename(value.Title));
						title = extractor.ToString();
					}
					var text = title + titleAppend + states.Capitalize(extracted);
					match.Values.AddLast(text);
				}
			}
			if (match != null)
			{
				states.MatchsAdd(match);
			}
			return state;
		}

		public static SearchState Chapter(NavigationInfo value, ParallelLoopState parallel, long offset, SearchState state)
		{
			var states = state.States;
			var extractor = state.Extractor;
			var query = state.Query;
			var html = value.HTML;
			var bodyO = html.IndexOf(bodyOpen);
			if (bodyO < 0)
			{
				return state;
			}
			var bodyC = html.IndexOf(bodyClose, bodyO);
			if (bodyC < 0)
			{
				return state;
			}
			var headerC = html.IndexOf(headerClose, bodyO);
			if (headerC < 0 || headerC >= bodyC)
			{
				return state;
			}
			query.Reset();
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
					if (!line.Contains(intro))
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
				query.Find(extracted);
			}
			if (query.Evaluate())
			{
				extractor.Clear();
				extractor.Append(states.Rename(value.Title));
				var text = extractor.ToString();
				var match = new SearchMatch(offset);
				match.Values.AddLast(text);
				states.MatchsAdd(match);
			}
			return state;
		}
		#endregion //Methods
	}
}

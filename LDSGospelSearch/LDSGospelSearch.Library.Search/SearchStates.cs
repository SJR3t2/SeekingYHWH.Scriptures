using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;

using SeekingYHWH.Scriptures.LDSGospelLibrary;
using SeekingYHWH.Scriptures;

namespace LDSGospelSearch
{
	public sealed class SearchStates
	{
		#region Fields
		private Dictionary<char, string> map;
		private Dictionary<string, string> renames = new Dictionary<string, string>();
		private Dictionary<string, string> capitalizes = new Dictionary<string, string>();
		private QueryProvider provider;
		private readonly Queue<SearchState> states = new Queue<SearchState>();
		private SpinLock statesLock = new SpinLock(false);
		private List<SearchMatch> matchs;
		private SpinLock matchsLock = new SpinLock(false);
		#endregion //Fields

		#region Constructors
		public SearchStates()
		{
		}

		public SearchStates(Dictionary<char, string> map)
		{
			this.map = map;
		}

		public SearchStates(Dictionary<char, string> map, List<SearchMatch> matchs)
		{
			this.map = map;
			this.matchs = matchs;
		}
		#endregion //Constructors

		#region Properties
		public Dictionary<char, string> Map { get => map; set => map = value; }
		public Dictionary<string, string> Renames { get => renames; set => renames = value; }
		public Dictionary<string, string> Capitalizes { get => capitalizes; set => capitalizes = value; }
		public QueryProvider Provider { get => provider; set => provider = value; }
		public List<SearchMatch> Matchs { get => matchs; set => matchs = value; }
		#endregion //Properties

		#region Methods
		public SearchState Init()
		{
			SearchState state;
			var locked = false;
			try
			{
				statesLock.TryEnter(ref locked);

				if (states.Count > 0)
				{
					state = states.Dequeue();
				}
				else
				{
					state = null;
				}
			}
			finally
			{
				if (locked)
				{
					statesLock.Exit();
				}
			}
			if (state == null)
			{
				var extractor = new Extractor(map);
				state = new SearchState(this, extractor);
			}
			state.Query = provider.Create();
			return state;
		}

		public void Finally(SearchState state)
		{
			state.Query = null;
			var locked = false;
			try
			{
				statesLock.TryEnter(ref locked);

				states.Enqueue(state);
			}
			finally
			{
				if (locked)
				{
					statesLock.Exit();
				}
			}
		}

		public void MatchsClear()
		{
			matchs.Clear();
		}

		public string Rename(string value)
		{
			foreach (var pair in renames)
			{
				value = value.Replace(pair.Key, pair.Value);
			}
			return value;
		}

		public string Capitalize(string value)
		{
			foreach (var pair in capitalizes)
			{
				value = value.Replace(pair.Key, pair.Value);
			}
			return value;
		}

		public void MatchsAdd(SearchMatch value)
		{
			var locked = false;
			try
			{
				matchsLock.TryEnter(ref locked);

				matchs.Add(value);
			}
			finally
			{
				if (locked)
				{
					matchsLock.Exit();
				}
			}
		}

		public void MatchsSort(Comparison<SearchMatch> comparison)
		{
			matchs.Sort(comparison);
		}

		public void MatchsWriteSeparate(TextWriter writer)
		{
			var separate = false;
			foreach (var match in matchs)
			{
				foreach (var value in match.Values)
				{
					if (separate)
					{
						writer.WriteLine();
					}
					else
					{
						separate = true;
					}
					writer.WriteLine(value);
				}
			}
		}

		public void MatchWrite(TextWriter writer)
		{
			foreach (var match in matchs)
			{
				foreach (var value in match.Values)
				{
					writer.WriteLine(value);
				}
			}
		}

		#region Config
		public void ConfigRenames(XmlNode config)
		{
			if (config == null)
			{
				return;
			}

			foreach (XmlNode node in config.ChildNodes)
			{
				if (node.NodeType != XmlNodeType.Element)
				{
					continue;
				}

				XmlAttribute original;
				XmlAttribute replace;
				switch (node.Name)
				{
				case "Add":
					original = node.Attributes["Original"];
					replace = node.Attributes["Replace"];
					if (original == null || replace == null)
					{
						continue;
					}
					if (string.IsNullOrWhiteSpace(original.InnerText))
					{
						continue;
					}
					renames[original.InnerText] = replace.InnerText;
					break;

				case "Clear":
					renames.Clear();
					break;

				case "Remove":
					original = node.Attributes["Original"];
					if (original == null)
					{
						continue;
					}
					if (string.IsNullOrWhiteSpace(original.InnerText))
					{
						continue;
					}
					renames.Remove(original.InnerText);
					break;
				}
			}
		}

		public void ConfigCapitalizes(XmlNode config)
		{
			if (config == null)
			{
				return;
			}

			foreach (XmlNode node in config.ChildNodes)
			{
				if (node.NodeType != XmlNodeType.Element)
				{
					continue;
				}

				switch (node.Name)
				{
				case "Add":
					var text = node.InnerText;
					var upper = text.ToUpper();

					capitalizes[text] = upper;
					break;

				case "Clear":
					capitalizes.Clear();
					break;

				case "Remove":
					capitalizes.Remove(node.InnerText);
					break;
				}
			}
		}
		#endregion //Config
		#endregion //Methods
	}
}

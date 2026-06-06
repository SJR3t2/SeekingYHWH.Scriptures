using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures.LDSGospelLibrary
{
	public sealed class Extractor
	{
		#region Types
		private enum Add
		{
			Ignore,
			Content,
			Verse,
			Name,
			Attributes,
		}
		#endregion //Types

		#region Class Methods
		public static Dictionary<char, string> CreateMap()
		{
			var map = new Dictionary<char, string>()
			{
				{ '\u00A0', " " },
				{ '\u2014', "-" },
				{ '\u2019', "'" },
				{ '\u201C', "\"" },
				{ '\u2026', "..." },
				{ '\u00B6', "" },
			};
			return map;
		}
		#endregion //Class Methods

		#region Fields
		private readonly Dictionary<char, string> map;
		private readonly StringBuilder builder = new StringBuilder();
		private bool whitespace;
		private readonly StringBuilder verse = new StringBuilder();
		private readonly StringBuilder namer = new StringBuilder();
		private readonly StringBuilder attributer = new StringBuilder();
		#endregion //Fields

		#region Constructors
		public Extractor(Dictionary<char, string> map)
		{
			this.map = map;
		}
		#endregion //Constructors

		#region Properties
		public StringBuilder Builder => builder;
		public StringBuilder Verse => verse;
		#endregion //Properties

		#region Methods
		public void Clear()
		{
			builder.Clear();
			whitespace = true;
			verse.Clear();
		}

		public void Append(string text)
		{
			foreach (var c in text)
			{
				Append(c);
			}
		}

		public void Extract(string text)
		{
			var add = Add.Content;
			var closing = false;
			foreach (var l in text)
			{
				switch (l)
				{
				case '\t':
					continue;

				case '<':
					add = Add.Name;
					closing = false;
					namer.Clear();
					continue;

				case '/':
					add = Add.Ignore;
					closing = true;
					continue;

				case '>':
					if (!closing)
					{
						var name = namer.ToString();
						switch (name)
						{
						case "sup":
							add = Add.Ignore;
							break;

						case "span":
							var attribute = attributer.ToString();
							switch (attribute)
							{
							case "class=\"verse-number\"":
								add = Add.Verse;
								break;

							default:
								add = Add.Content;
								break;
							}
							break;

						default:
							add = Add.Content;
							break;
						}
					}
					else
					{
						add = Add.Content;
					}
					break;

				default:
					switch (add)
					{
					case Add.Content:
						Append(l);
						break;

					case Add.Verse:
						verse.Append(l);
						break;

					case Add.Name:
						if (char.IsWhiteSpace(l))
						{
							add = Add.Attributes;
							attributer.Clear();
							break;
						}
						namer.Append(l);
						break;

					case Add.Attributes:
						attributer.Append(l);
						break;
					}
					break;
				}
			}
		}

		public void Append(char c)
		{
			if (map.TryGetValue(c, out var replace))
			{
				builder.Append(replace);
			}
			else
			{
				if (char.IsWhiteSpace(c))
				{
					if (!whitespace)
					{
						builder.Append(' ');
						whitespace = true;
					}
				}
				else
				{
					builder.Append(c);
					whitespace = false;
				}
			}
		}

		public override string ToString()
		{
			return builder.ToString();
		}
		#endregion //Methods
	}
}

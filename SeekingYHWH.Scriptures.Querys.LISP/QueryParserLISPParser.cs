using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class QueryParserLISPParser : QueryParserParser
	{
		#region Constants
		public const char EscapeLetter = '~';
		#endregion //Constants

		#region Fields
		private readonly Dictionary<string, Converter<QueryParserLISPParser, QueryParserLISP>> parsers;
		private readonly string text;
		private int offset;
		private readonly StringBuilder builder = new StringBuilder();
		#endregion //Fields

		#region Constructors
		public QueryParserLISPParser(Dictionary<string, Converter<QueryParserLISPParser, QueryParserLISP>> parsers, string text)
			: base()
		{
			this.parsers = parsers;
			this.text = text;
			this.offset = 0;
		}
		#endregion //Constructors

		#region Methods
		public bool TryParse(out QueryProvider provider)
		{
			char letter;

			//Trim
			while (true)
			{
				if (offset >= text.Length)
				{
					errors.Add("Empty");
					provider = null;
					return false;
				}
				letter = text[offset];
				if (char.IsLetter(letter))
				{
					break;
				}
				if (char.IsWhiteSpace(letter))
				{
					++offset;
					continue;
				}
				else
				{
					errors.Add("Invalid letter: " + letter.ToString());
					provider = null;
					return false;
				}
			}
			//Build
			builder.Length = 0;
			builder.Append(letter);
			++offset;
			while (true)
			{
				if (offset >= text.Length)
				{
					errors.Add("Missing (");
					provider = null;
					return false;
				}
				letter = text[offset];
				if (letter == '(')
				{
					return TryParseProvider(out provider);
				}
				if (char.IsLetterOrDigit(letter))
				{
					builder.Append(letter);
					++offset;
					continue;
				}
				if (char.IsWhiteSpace(letter))
				{
					while (true)
					{
						++offset;
						if (offset >= text.Length)
						{
							errors.Add("Missing (");
							provider = null;
							return false;
						}
						letter = text[offset];
						if (letter == '(')
						{
							return TryParseProvider(out provider);
						}
						if (char.IsWhiteSpace(letter))
						{
							continue;
						}
						else
						{
							errors.Add("Invalid letter: " + letter.ToString());
							provider = null;
							return false;
						}
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool TryParseProvider(out QueryProvider provider)
		{
			var built = builder.ToString();
			++offset;
			if (parsers.TryGetValue(built, out var creator))
			{
				var parser = creator(this);
				return parser.TryParse(out provider);
			}
			else
			{
				errors.Add("Invalid Predicate: " + built);
				provider = null;
				return false;
			}
		}

		public bool NextToken(out char token)
		{
			while (true)
			{
				if (offset >= text.Length)
				{
					token = default;
					return false;
				}
				var letter = text[offset];
				if (char.IsWhiteSpace(letter))
				{
					++offset;
					continue;
				}
				token = letter;
				return true;
			}
		}

		public void NextToken()
		{
			++offset;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryParseString(out string value)
		{
			while (true)
			{
				if (offset >= text.Length)
				{
					errors.Add("Missing String");
					value = null;
					return false;
				}
				var letter = text[offset];
				if (letter == '"')
				{
					++offset;
					return TryParseStringDouble(out value);
				}
				if (letter == '\'')
				{
					++offset;
					return TryParseStringSingle(out value);
				}
				if (char.IsWhiteSpace(letter))
				{
					++offset;
					continue;
				}
				else
				{
					return TryParseStringText(out value);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool TryParseStringDouble(out string value)
		{
			builder.Length = 0;
			var escaped = false;
			while (true)
			{
				if (offset >= text.Length)
				{
					errors.Add("Missing \"");
					value = null;
					return false;
				}
				var letter = text[offset];
				if (escaped)
				{
					builder.Append(letter);
					escaped = false;
					++offset;
					continue;
				}
				else if (letter == '"')
				{
					value = builder.ToString();
					++offset;
					return true;
				}
				else if (letter == EscapeLetter)
				{
					escaped = true;
					++offset;
					continue;
				}
				else
				{
					builder.Append(letter);
					++offset;
					continue;
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool TryParseStringSingle(out string value)
		{
			builder.Length = 0;
			var escaped = false;
			while (true)
			{
				if (offset >= text.Length)
				{
					errors.Add("Missing \"");
					value = null;
					return false;
				}
				var letter = text[offset];
				if (escaped)
				{
					builder.Append(letter);
					escaped = false;
					++offset;
					continue;
				}
				else if (letter == '\'')
				{
					value = builder.ToString();
					++offset;
					return true;
				}
				else if (letter == EscapeLetter)
				{
					escaped = true;
					++offset;
					continue;
				}
				else
				{
					builder.Append(letter);
					++offset;
					continue;
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool TryParseStringText(out string value)
		{
			builder.Length = 0;
			var escaped = false;
			while (true)
			{
				if (offset >= text.Length)
				{
					if (escaped)
					{
						errors.Add("Escaped");
						value = null;
						return false;
					}
					else
					{
						value = builder.ToString();
						return true;
					}
				}
				var letter = text[offset];
				if (escaped)
				{
					builder.Append(letter);
					escaped = false;
					++offset;
					continue;
				}
				else if (letter == ',' || letter == ')' || char.IsWhiteSpace(letter))
				{
					value = builder.ToString();
					return true;
				}
				else if (letter == EscapeLetter)
				{
					escaped = true;
					++offset;
					continue;
				}
				else
				{
					builder.Append(letter);
					++offset;
					continue;
				}
			}
		}
		
		public bool TryParseEnumSingle<T>(Dictionary<string, T> values, T value, out T parsed)
		{
			//Trim
			while (true)
			{
				if (offset >= text.Length)
				{
					parsed = value;
					return true;
				}
				var letter = text[offset];
				if (char.IsWhiteSpace(letter))
				{
					++offset;
					continue;
				}
				if (letter == ',' || letter == ')')
				{
					parsed = value;
					return true;
				}
				break;
			}
			//Parse
			builder.Length = 0;
			while (true)
			{
				if (offset >= text.Length)
				{
					if (builder.Length == 0)
					{
						parsed = value;
						return true;
					}
					var built = builder.ToString();
					if (values.TryGetValue(built, out  parsed))
					{
						return true;
					}
					else
					{
						errors.Add("Invalid value: " + built);
						return false;
					}
				}
				var letter = text[offset];
				var space = char.IsWhiteSpace(letter);
				var comma = letter == ',';
				var close = letter == ')';
				if (space || comma || close)
				{
					var built = builder.ToString();
					var success = values.TryGetValue(built, out parsed);
					if (!success)
					{
						errors.Add("Invalid value: " + built);
						return false;
					}
					builder.Length = 0;
					if (space)
					{
						var add = false;
						while (true)
						{
							++offset;
							if (offset >= text.Length)
							{
								if (builder.Length > 0)
								{
									errors.Add("Invalid value: " + builder.ToString());
									success = false;
								}
								break;
							}
							comma = letter == ',';
							close = letter == ')';
							if (comma || close)
							{
								if (builder.Length > 0)
								{
									errors.Add("Invalid value: " + builder.ToString());
									success = false;
								}
								break;
							}
							space = char.IsWhiteSpace(letter);
							if (builder.Length > 0 || !space)
							{
								if (space)
								{
									if (add)
									{
										builder.Append(' ');
										add = false;
									}
								}
								else
								{
									builder.Append(letter);
									add = true;
								}
							}
						}
					}
					return success;
				}
				builder.Append(letter);
				++offset;
			}
		}

		public bool TryParseInt32(out int value)
		{
			builder.Length = 0;
			while (true)
			{
				if (offset >= text.Length)
				{
					return TryParseInt32Internal(out value);
				}
				var letter = text[offset];
				if (letter == ',' || letter == ')' || char.IsWhiteSpace(letter))
				{
					return TryParseInt32Internal(out value);
				}
				if (char.IsDigit(letter) || ((letter == '+' || letter == '-') && builder.Length <= 0))
				{
					builder.Append(letter);
					++offset;
					continue;
				}
				else
				{
					errors.Add("Invalid Int32: " + letter);
					value = default;
					return false;
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool TryParseInt32Internal(out int value)
		{
			if (builder.Length <= 0)
			{
				errors.Add("Missing Digits");
				value = default;
				return false;
			}
			var parse = builder.ToString();
			if (!int.TryParse(parse, out value))
			{
				errors.Add("Invalid Int32");
				return false;
			}
			return true;
		}
		#endregion //Methods
	}
}

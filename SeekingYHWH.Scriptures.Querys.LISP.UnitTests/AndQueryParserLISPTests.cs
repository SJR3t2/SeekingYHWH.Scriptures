using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

using Xunit;

using SeekingYHWH.Scriptures;

namespace SeekingYHWH.Scriptures
{
	public class AndQueryParserLISPTests
	{
		#region Class Fields
		private static readonly Dictionary<string, Converter<QueryParserLISPParser, QueryParserLISP>> parsers = new ()
		{
			{ AndQueryParserLISP.Query, AndQueryParserLISP.Create },
			{ TrueQueryParserLISP.Query, TrueQueryParserLISP.Create },
		};
		#endregion //Class Fields

		[Fact]
		public void TryParseOneTest()
		{
			var parser = new QueryParserLISPParser(parsers, "And(True())");
			var parsed = parser.TryParse(out var provider);
			Assert.True(parsed);
			var actual = provider as AndQueryProvider;
			Assert.NotNull(actual);
			Assert.Equal(1, actual.Length);
		}

		[Fact]
		public void TryParseTwoTest()
		{
			var parser = new QueryParserLISPParser(parsers, "And(True(),True())");
			var parsed = parser.TryParse(out var provider);
			Assert.True(parsed);
			var actual = provider as AndQueryProvider;
			Assert.NotNull(actual);
			Assert.Equal(2, actual.Length);
		}
	}
}

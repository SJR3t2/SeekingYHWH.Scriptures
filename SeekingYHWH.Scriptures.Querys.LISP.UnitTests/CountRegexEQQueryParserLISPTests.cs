using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

using Xunit;

using SeekingYHWH.Scriptures;

namespace SeekingYHWH.Scriptures
{
	public class CountRegexEQQueryParserLISPTests
	{
		#region Class Fields
		private static readonly Dictionary<string, Converter<QueryParserLISPParser, QueryParserLISP>> parsers = new Dictionary<string, Converter<QueryParserLISPParser, QueryParserLISP>>(StringComparer.InvariantCultureIgnoreCase)
		{
			{ CountRegexEQQueryParserLISP.Query, CountRegexEQQueryParserLISP.Create },
		};
		#endregion //Class Fields

		[Fact]
		public void TryParsePatternTest()
		{
			var parser = new QueryParserLISPParser(parsers, "CountRegexEQ(1,pattern)");
			var parsed = parser.TryParse(out var provider);
			Assert.True(parsed);
			var actual = provider as CountRegexEQQueryProvider;
			Assert.NotNull(actual);
			Assert.Equal(1, actual.Count);
			Assert.Equal("pattern", actual.Pattern);
		}

		[Fact]
		public void TryParseOptionsTest()
		{
			var parser = new QueryParserLISPParser(parsers, "CountRegexEQ(1, pattern, IgnoreCase)");
			var parsed = parser.TryParse(out var provider);
			Assert.True(parsed);
			var actual = provider as CountRegexEQQueryProvider;
			Assert.NotNull(actual);
			Assert.Equal(1, actual.Count);
			Assert.Equal("pattern", actual.Pattern);
			Assert.Equal(RegexOptions.IgnoreCase, actual.Options);
		}
	}
}

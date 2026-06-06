using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

using Xunit;

using SeekingYHWH.Scriptures;

namespace SeekingYHWH.Scriptures
{
	public class QueryParserLISPParserTests
	{
		[Fact]
		public void TryParseEnumSingleIgnoreCaseTest()
		{
			var parser = new QueryParserLISPParser(null, "IgnoreCase");
			var values = new Dictionary<string, RegexOptions>()
			{
				{ "IgnoreCase", RegexOptions.IgnoreCase },
			};
			var parsed = parser.TryParseEnumSingle(values, RegexOptions.IgnoreCase, out var actual);
			Assert.True(parsed);
			Assert.Equal(RegexOptions.IgnoreCase, actual);
		}

		[Fact]
		public void TryParseStringDoubleTest()
		{
			var parser = new QueryParserLISPParser(null, "\"Double\"");
			var parsed = parser.TryParseString(out var actual);
			Assert.True(parsed);
			Assert.Equal("Double", actual);
		}

		[Fact]
		public void TryParseStringSingleTest()
		{
			var parser = new QueryParserLISPParser(null, "'Single'");
			var parsed = parser.TryParseString(out var actual);
			Assert.True(parsed);
			Assert.Equal("Single", actual);
		}

		[Fact]
		public void TryParseStringTextTest()
		{
			var parser = new QueryParserLISPParser(null, "Text");
			var parsed = parser.TryParseString(out var actual);
			Assert.True(parsed);
			Assert.Equal("Text", actual);
		}
	}
}
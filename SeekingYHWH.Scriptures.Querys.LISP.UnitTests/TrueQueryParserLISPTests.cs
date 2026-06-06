using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

using Xunit;

using SeekingYHWH.Scriptures;

namespace SeekingYHWH.Scriptures
{
	public class TrueQueryParserLISPTests
	{
		#region Class Fields
		private static readonly Dictionary<string, Converter<QueryParserLISPParser, QueryParserLISP>> parsers = new ()
		{
			{ TrueQueryParserLISP.Query, TrueQueryParserLISP.Create },
		};
		#endregion //Class Fields

		[Fact]
		public void TryParseTest()
		{
			var parser = new QueryParserLISPParser(parsers, "True()");
			var parsed = parser.TryParse(out var provider);
			Assert.True(parsed);
			var actual = provider as TrueQueryProvider;
			Assert.NotNull(actual);
		}
	}
}

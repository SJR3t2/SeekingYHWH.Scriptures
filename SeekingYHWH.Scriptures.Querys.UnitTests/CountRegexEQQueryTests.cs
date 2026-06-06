using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

using Xunit;

using SeekingYHWH.Scriptures;

namespace SeekingYHWH.Scriptures
{
	public class CountRegexEQQueryTests
	{
		[Theory]
		[InlineData(1, "A")]
		[InlineData(2, "AA")]
		[InlineData(3, "AAA")]
		public void CountRegexEQQueryTest(int count, string text)
		{
			var regex = new Regex("A");
			var query = new CountRegexEQQuery(count, regex);
			query.Reset();
			query.Find(text);
			var success = query.Evaluate();
			Assert.True(success);
		}
	}
}

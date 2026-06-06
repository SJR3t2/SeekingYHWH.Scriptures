using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

using Xunit;

using SeekingYHWH.Scriptures;

namespace SeekingYHWH.Scriptures
{
	public class CountIndexEQQueryTests
	{
		[Theory]
		[InlineData(1, "A")]
		[InlineData(2, "AA")]
		[InlineData(3, "AAA")]
		public void CountIndexEQQueryTest(int count, string text)
		{
			var query = new CountIndexEQQuery(count, "A", StringComparison.CurrentCultureIgnoreCase);
			query.Reset();
			query.Find(text);
			var success = query.Evaluate();
			Assert.True(success);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SeekingYHWH.Scriptures
{
	public abstract class CountRegexQuery : Query
	{
		#region Fields
		protected readonly int count;
		protected readonly Regex regex;

		protected int value;
		#endregion //Fields

		#region Constructors
		protected CountRegexQuery(int count, Regex regex)
			: base()
		{
			this.count = count;
			this.regex = regex;
		}
		#endregion //Constructors

		#region Properties
		public int Count => count;
		public Regex Regex => regex;
		#endregion //Properties

		#region Methods
		public sealed override void Reset()
		{
			value = 0;
		}

		public sealed override void Find(string text)
		{
			var length = text.Length;
			for (var offset = 0; offset < length;)
			{
				var match = regex.Match(text, offset);
				if (!match.Success)
				{
					return;
				}
				++value;
				offset = match.Index + 1;
			}
		}
		#endregion //Methods
	}
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SeekingYHWH.Scriptures
{
	public sealed class NRegexQuery : Query
	{
		#region Fields
		private readonly Regex regex;

		private bool found;
		#endregion //Fields

		#region Constructors
		public NRegexQuery(Regex regex)
			: base()
		{
			this.regex = regex;
		}
		#endregion //Constructors

		#region Methods
		public override void Reset()
		{
			found = false;
		}

		public override void Find(string text)
		{
			if (found)
			{
				return;
			}

			found = regex.IsMatch(text);
		}

		public override bool Evaluate()
		{
			return !found;
		}
		#endregion //Methods
	}
}

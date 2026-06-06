using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class CountIndexQuery : Query
	{
		#region Fields
		protected readonly int count;
		protected readonly string text;
		protected readonly StringComparison comparison;

		protected int value;
		#endregion //Fields

		#region Constructors
		public CountIndexQuery(int count, string text, StringComparison comparison)
			: base()
		{
			this.count = count;
			this.text = text;
			this.comparison = comparison;
		}
		#endregion //Constructors

		#region Properties
		public int Count => count;
		public string Text => text;
		public StringComparison Comparison => comparison;
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
				var index = text.IndexOf(this.text, offset, comparison);
				if (index < 0)
				{
					return;
				}
				++value;
				offset = index + 1;
			}
		}
		#endregion //Methods
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class CountIndexQueryProvider : QueryProvider
	{
		#region Fields
		protected readonly int count;
		protected readonly string text;
		protected readonly StringComparison comparison;
		#endregion //Fields

		#region Constructors
		protected CountIndexQueryProvider(int count, string text, StringComparison comparison)
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
	}
}

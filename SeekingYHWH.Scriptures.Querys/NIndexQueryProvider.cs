using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NIndexQueryProvider : QueryProvider
	{
		#region Fields
		private readonly string text;
		private readonly StringComparison comparison;
		#endregion //Fields

		#region Constructors
		public NIndexQueryProvider(string text, StringComparison comparison)
			: base()
		{
			this.text = text;
			this.comparison = comparison;
		}
		#endregion //Constructors

		#region Properties
		public string Text => text;
		public StringComparison Comparison => comparison;
		#endregion //Properties

		#region Methods
		public override Query Create()
		{
			var predicate = new NIndexQuery(text, comparison);
			return predicate;
		}
		#endregion //Methods
	}
}

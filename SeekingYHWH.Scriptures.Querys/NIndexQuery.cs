using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NIndexQuery : Query
	{
		#region Fields
		private readonly string text;
		private readonly StringComparison comparison;

		private bool found;
		#endregion //Fields

		#region Constructors
		public NIndexQuery(string text, StringComparison comparison)
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

			found = text.IndexOf(this.text, comparison) >= 0;
		}

		public override bool Evaluate()
		{
			return !found;
		}
		#endregion //Methods
	}
}

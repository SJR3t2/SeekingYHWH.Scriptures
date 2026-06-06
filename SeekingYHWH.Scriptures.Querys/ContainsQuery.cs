using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class ContainsQuery : Query
	{
		#region Fields
		private readonly string text;

		private bool found;
		#endregion //Fields

		#region Constructors
		public ContainsQuery(string text)
			: base()
		{
			this.text = text;
		}
		#endregion //Constructors

		#region Properties
		public string Text => text;
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

			found = text.Contains(this.text);
		}

		public override bool Evaluate()
		{
			return found;
		}
		#endregion //Methods
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NContainsQuery : Query
	{
		#region Fields
		private readonly string contains;

		private bool found;
		#endregion //Fields

		#region Constructors
		public NContainsQuery(string contains)
			: base()
		{
			this.contains = contains;
		}
		#endregion //Constructors

		#region Properties
		public string Contains => contains;
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

			found = text.Contains(contains);
		}

		public override bool Evaluate()
		{
			return !found;
		}
		#endregion //Methods
	}
}

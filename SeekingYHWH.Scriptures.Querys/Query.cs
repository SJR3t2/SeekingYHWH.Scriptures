using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class Query
	{
		#region Methods
		public abstract void Reset();
		public abstract void Find(string text);
		public abstract bool Evaluate();
		#endregion //Methods
	}
}

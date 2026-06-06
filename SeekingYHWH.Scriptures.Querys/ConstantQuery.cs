using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class ConstantQuery : Query
	{
		#region Constructors
		public ConstantQuery()
			: base()
		{
		}
		#endregion //Constructors

		#region Methods
		public override void Reset()
		{
		}

		public override void Find(string text)
		{
		}
		#endregion //Methods
	}
}

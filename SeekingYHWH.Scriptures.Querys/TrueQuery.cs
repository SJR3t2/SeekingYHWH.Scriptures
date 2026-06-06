using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class TrueQuery : ConstantQuery
	{
		#region Constructors
		public TrueQuery()
			: base()
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			return true;
		}
		#endregion //Methods
	}
}

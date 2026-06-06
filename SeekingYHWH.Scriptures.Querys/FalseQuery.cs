using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class FalseQuery : ConstantQuery
	{
		#region Constructors
		public FalseQuery()
			: base()
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			return false;
		}
		#endregion //Methods
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NXorQuery : DoubleQuery
	{
		#region Constructors
		public NXorQuery(Query x, Query y)
			: base(x, y)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			return x.Evaluate() == y.Evaluate();
		}
		#endregion //Methods
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NXorQueryProvider : DoubleQueryProvider
	{
		#region Constructors
		public NXorQueryProvider(QueryProvider x, QueryProvider y)
			: base(x, y)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var x = CreatePredicateX();
			var y = CreatePredicateY();
			return new NXorQuery(x, y);
		}
		#endregion //Methods
	}
}

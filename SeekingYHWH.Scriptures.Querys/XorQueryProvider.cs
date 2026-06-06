using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class XorQueryProvider : DoubleQueryProvider
	{
		#region Constructors
		public XorQueryProvider(QueryProvider x, QueryProvider y)
			: base(x, y)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var x = CreatePredicateX();
			var y = CreatePredicateY();
			return new XorQuery(x, y);
		}
		#endregion //Methods
	}
}

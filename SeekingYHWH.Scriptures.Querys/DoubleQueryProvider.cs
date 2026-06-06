using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class DoubleQueryProvider : QueryProvider
	{
		#region Fields
		protected readonly QueryProvider x;
		protected readonly QueryProvider y;
		#endregion //Fields

		#region Constructors
		protected DoubleQueryProvider(QueryProvider x, QueryProvider y)
			: base()
		{
			this.x = x;
			this.y = y;
		}
		#endregion //Constructors

		#region Properties
		public QueryProvider X => x;
		public QueryProvider Y => y;
		#endregion //Properties

		#region Methods
		protected void CreatePredicates(out Query x, out Query y)
		{
			x = this.x.Create();
			y = this.y.Create();
		}

		protected Query CreatePredicateX()
		{
			return x.Create();
		}

		protected Query CreatePredicateY()
		{
			return y.Create();
		}
		#endregion //Methods
	}
}

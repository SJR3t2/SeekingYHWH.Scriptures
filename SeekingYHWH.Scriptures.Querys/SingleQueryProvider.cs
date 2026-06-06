using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class SingleQueryProvider : QueryProvider
	{
		#region Fields
		protected readonly QueryProvider provider;
		#endregion //Fields

		#region Constructors
		protected SingleQueryProvider(QueryProvider provider)
			: base()
		{
			this.provider = provider;
		}
		#endregion //Constructors

		#region Properties
		public QueryProvider Provider => provider;
		#endregion //Properties

		#region Methods
		protected Query CreatePredicate()
		{
			var predicate = provider.Create();
			return predicate;
		}
		#endregion //Methods
	}
}

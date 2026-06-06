using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class MultipleQueryProvider : QueryProvider
	{
		#region Fields
		protected readonly QueryProvider[] providers;
		#endregion //Fields

		#region Constructors
		protected MultipleQueryProvider(QueryProvider[] providers)
			: base()
		{
			this.providers = providers;
		}
		#endregion //Constructors

		#region Properties
		public int Length => providers.Length;
		#endregion //Properties

		#region Methods
		protected Query[] CreatePredicates()
		{
			var predicates = new Query[providers.Length];
			for (var i = predicates.Length - 1; i >= 0; --i)
			{
				predicates[i] = providers[i].Create();
			}
			return predicates;
		}
		#endregion //Methods
	}
}

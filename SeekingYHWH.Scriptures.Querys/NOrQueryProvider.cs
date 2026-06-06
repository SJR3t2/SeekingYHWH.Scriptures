using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NOrQueryProvider : MultipleQueryProvider
	{
		#region Constructors
		public NOrQueryProvider(QueryProvider[] providers)
			: base(providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new NOrQuery(predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

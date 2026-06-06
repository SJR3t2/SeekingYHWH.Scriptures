using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class DiffQueryProvider : MultipleQueryProvider
	{
		#region Constructors
		public DiffQueryProvider(QueryProvider[] providers)
			: base(providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new DiffQuery(predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

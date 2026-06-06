using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class SameQueryProvider : MultipleQueryProvider
	{
		#region Constructors
		public SameQueryProvider(QueryProvider[] providers)
			: base(providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new SameQuery(predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

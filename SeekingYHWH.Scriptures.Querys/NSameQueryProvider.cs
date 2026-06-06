using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NSameQueryProvider : MultipleQueryProvider
	{
		#region Constructors
		public NSameQueryProvider(QueryProvider[] providers)
			: base(providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new NSameQuery(predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

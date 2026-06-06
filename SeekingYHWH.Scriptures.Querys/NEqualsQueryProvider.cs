using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NEqualsQueryProvider : MultipleQueryProvider
	{
		#region Constructors
		public NEqualsQueryProvider(QueryProvider[] providers)
			: base(providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new NEqualsQuery(predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

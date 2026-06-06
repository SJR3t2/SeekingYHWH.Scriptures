using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class EqualsQueryProvider : MultipleQueryProvider
	{
		#region Constructors
		public EqualsQueryProvider(QueryProvider[] providers)
			: base(providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new EqualsQuery(predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

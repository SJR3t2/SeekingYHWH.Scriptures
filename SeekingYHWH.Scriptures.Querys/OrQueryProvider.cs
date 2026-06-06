using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class OrQueryProvider : MultipleQueryProvider
	{
		#region Constructors
		public OrQueryProvider(QueryProvider[] providers)
			: base(providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new OrQuery(predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

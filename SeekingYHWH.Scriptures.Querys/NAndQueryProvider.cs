using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NAndQueryProvider : MultipleQueryProvider
	{
		#region Constructors
		public NAndQueryProvider(QueryProvider[] providers)
			: base(providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new NAndQuery(predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

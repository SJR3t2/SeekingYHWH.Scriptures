using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class FalsesQueryProvider : MultipleQueryProvider
	{
		#region Constructors
		public FalsesQueryProvider(QueryProvider[] providers)
			: base(providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new FalsesQuery(predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

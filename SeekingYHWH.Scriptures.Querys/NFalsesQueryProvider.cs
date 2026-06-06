using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NFalsesQueryProvider : MultipleQueryProvider
	{
		#region Constructors
		public NFalsesQueryProvider(QueryProvider[] providers)
			: base(providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new NFalsesQuery(predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

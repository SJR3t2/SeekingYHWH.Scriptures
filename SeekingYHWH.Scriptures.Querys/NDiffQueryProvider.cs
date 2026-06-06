using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NDiffQueryProvider : MultipleQueryProvider
	{
		#region Constructors
		public NDiffQueryProvider(QueryProvider[] providers)
			: base(providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new NDiffQuery(predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

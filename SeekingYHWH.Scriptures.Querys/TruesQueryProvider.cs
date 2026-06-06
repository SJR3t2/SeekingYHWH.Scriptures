using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class TruesQueryProvider : MultipleQueryProvider
	{
		#region Constructors
		public TruesQueryProvider(QueryProvider[] providers)
			: base(providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new TruesQuery(predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

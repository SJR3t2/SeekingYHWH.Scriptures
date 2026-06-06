using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NTruesQueryProvider : MultipleQueryProvider
	{
		#region Constructors
		public NTruesQueryProvider(QueryProvider[] providers)
			: base(providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new NTruesQuery(predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountTruesLTQueryProvider : CountQueryProvider
	{
		#region Constructors
		public CountTruesLTQueryProvider(int count, QueryProvider[] providers)
			: base(count, providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new CountTruesLTQuery(count, predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

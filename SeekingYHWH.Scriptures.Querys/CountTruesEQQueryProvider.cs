using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountTruesEQQueryProvider : CountQueryProvider
	{
		#region Constructors
		public CountTruesEQQueryProvider(int count, QueryProvider[] providers)
			: base(count, providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new CountTruesEQQuery(count, predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

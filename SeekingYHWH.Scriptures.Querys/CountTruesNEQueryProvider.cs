using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountTruesNEQueryProvider : CountQueryProvider
	{
		#region Constructors
		public CountTruesNEQueryProvider(int count, QueryProvider[] providers)
			: base(count, providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new CountTruesNEQuery(count, predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

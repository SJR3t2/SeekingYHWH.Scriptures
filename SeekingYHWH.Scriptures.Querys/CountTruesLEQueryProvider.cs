using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountTruesLEQueryProvider : CountQueryProvider
	{
		#region Constructors
		public CountTruesLEQueryProvider(int count, QueryProvider[] providers)
			: base(count, providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new CountTruesLEQuery(count, predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

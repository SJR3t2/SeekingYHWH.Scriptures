using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountTruesGEQueryProvider : CountQueryProvider
	{
		#region Constructors
		public CountTruesGEQueryProvider(int count, QueryProvider[] providers)
			: base(count, providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new CountTruesGEQuery(count, predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

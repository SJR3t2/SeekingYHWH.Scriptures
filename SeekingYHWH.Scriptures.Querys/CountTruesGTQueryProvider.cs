using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountTruesGTQueryProvider : CountQueryProvider
	{
		#region Constructors
		public CountTruesGTQueryProvider(int count, QueryProvider[] providers)
			: base(count, providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new CountTruesGTQuery(count, predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

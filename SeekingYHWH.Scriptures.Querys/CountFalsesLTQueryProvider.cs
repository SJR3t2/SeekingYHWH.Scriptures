using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountFalsesLTQueryProvider : CountQueryProvider
	{
		#region Constructors
		public CountFalsesLTQueryProvider(int count, QueryProvider[] providers)
			: base(count, providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new CountFalsesLTQuery(count, predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

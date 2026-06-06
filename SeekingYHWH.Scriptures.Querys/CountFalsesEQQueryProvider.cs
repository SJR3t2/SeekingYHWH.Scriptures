using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountFalsesEQQueryProvider : CountQueryProvider
	{
		#region Constructors
		public CountFalsesEQQueryProvider(int count, QueryProvider[] providers)
			: base(count, providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new CountFalsesEQQuery(count, predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

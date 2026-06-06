using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountFalsesGTQueryProvider : CountQueryProvider
	{
		#region Constructors
		public CountFalsesGTQueryProvider(int count, QueryProvider[] providers)
			: base(count, providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new CountFalsesGTQuery(count, predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

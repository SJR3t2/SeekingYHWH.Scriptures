using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountFalsesLEQueryProvider : CountQueryProvider
	{
		#region Constructors
		public CountFalsesLEQueryProvider(int count, QueryProvider[] providers)
			: base(count, providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new CountFalsesLEQuery(count, predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

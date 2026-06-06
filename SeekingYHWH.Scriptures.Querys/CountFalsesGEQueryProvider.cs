using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountFalsesGEQueryProvider : CountQueryProvider
	{
		#region Constructors
		public CountFalsesGEQueryProvider(int count, QueryProvider[] providers)
			: base(count, providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new CountFalsesGEQuery(count, predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

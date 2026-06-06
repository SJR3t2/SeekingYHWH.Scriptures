using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountFalsesNEQueryProvider : CountQueryProvider
	{
		#region Constructors
		public CountFalsesNEQueryProvider(int count, QueryProvider[] providers)
			: base(count, providers)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicates = CreatePredicates();
			var predicate = new CountFalsesNEQuery(count, predicates);
			return predicate;
		}
		#endregion //Methods
	}
}

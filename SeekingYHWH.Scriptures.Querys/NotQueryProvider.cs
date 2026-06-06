using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NotQueryProvider : SingleQueryProvider
	{
		#region Constructors
		public NotQueryProvider(QueryProvider provider)
			: base(provider)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var predicatePredicate = CreatePredicate();
			var predicate = new NotQuery(predicatePredicate);
			return predicate;
		}
		#endregion //Methods
	}
}

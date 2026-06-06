using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class OrQuery : MultipleQuery
	{
		#region Constructors
		public OrQuery(Query[] predicates)
			: base(predicates)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			foreach (var predicate in querys)
			{
				if (predicate.Evaluate())
				{
					return true;
				}
			}
			return false;
		}
		#endregion //Methods
	}
}

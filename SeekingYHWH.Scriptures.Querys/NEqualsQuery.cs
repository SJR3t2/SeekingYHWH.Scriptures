using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NEqualsQuery : MultipleQuery
	{
		#region Constructors
		public NEqualsQuery(Query[] predicates)
			: base(predicates)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			var value = querys[0].Evaluate();
			for (var i = querys.Length - 1; i > 0; --i)
			{
				var predicate = querys[i];
				if (predicate.Evaluate() != value)
				{
					return true;
				}
			}
			return false;
		}
		#endregion //Methods
	}
}

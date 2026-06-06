using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class TruesQuery : MultipleQuery
	{
		#region Constructors
		public TruesQuery(Query[] predicates)
			: base(predicates)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			foreach (var predicate in querys)
			{
				if (!predicate.Evaluate())
				{
					return false;
				}
			}
			return true;
		}
		#endregion //Methods
	}
}

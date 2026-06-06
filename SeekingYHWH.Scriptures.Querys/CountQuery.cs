using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class CountQuery : MultipleQuery
	{
		#region Fields
		protected readonly int count;
		#endregion //Fields

		#region Constructors
		protected CountQuery(int count, Query[] predicates)
			: base(predicates)
		{
			this.count = count;
		}
		#endregion //Constructors

		#region Properties
		public int Count => count;
		#endregion //Properties

		#region Methods
		protected int CountTrues()
		{
			var count = 0;
			foreach (var predicate in querys)
			{
				if (predicate.Evaluate())
				{
					++count;
				}
			}
			return count;
		}
		
		protected int CountFalses()
		{
			var count = 0;
			foreach (var predicate in querys)
			{
				if (!predicate.Evaluate())
				{
					++count;
				}
			}
			return count;
		}
		#endregion //Methods
	}
}

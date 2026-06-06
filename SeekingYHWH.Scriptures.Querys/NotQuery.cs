using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NotQuery : SingleQuery
	{
		#region Constructors
		public NotQuery(Query predicate)
			: base(predicate)
		{
		}
		#endregion //Constructors

		#region Methods
		public override bool Evaluate()
		{
			return !predicate.Evaluate();
		}
		#endregion //Methods
	}
}

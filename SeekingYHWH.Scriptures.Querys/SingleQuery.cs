using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class SingleQuery : Query
	{
		#region Fields
		protected readonly Query predicate;
		#endregion //Fields

		#region Constructors
		protected SingleQuery(Query predicate)
			: base()
		{
			this.predicate = predicate;
		}
		#endregion //Constructors

		#region Properties
		public Query Predicate => predicate;
		#endregion //Properties

		#region Methods
		public override void Reset()
		{
			predicate.Reset();
		}

		public override void Find(string text)
		{
			predicate.Find(text);
		}
		#endregion //Methods
	}
}

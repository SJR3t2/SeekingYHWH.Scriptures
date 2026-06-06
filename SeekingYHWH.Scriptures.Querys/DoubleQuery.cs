using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class DoubleQuery : Query
	{
		#region Fields
		protected readonly Query x;
		protected readonly Query y;
		#endregion //Fields

		#region Constructors
		protected DoubleQuery(Query x, Query y)
			: base()
		{
			this.x = x;
			this.y = y;
		}
		#endregion //Constructors

		#region Properties
		public Query X => x;
		public Query Y => y;
		#endregion //Properties

		#region Methods
		public override void Reset()
		{
			x.Reset();
			y.Reset();
		}

		public override void Find(string text)
		{
			x.Find(text);
			y.Find(text);
		}
		#endregion //Methods
	}
}

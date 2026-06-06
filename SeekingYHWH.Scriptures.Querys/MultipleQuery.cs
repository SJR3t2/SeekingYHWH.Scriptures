using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class MultipleQuery : Query
	{
		#region Fields
		protected readonly Query[] querys;
		#endregion //Fields

		#region Constructors
		protected MultipleQuery(Query[] querys)
			: base()
		{
			this.querys = querys;
		}
		#endregion //Constructors

		#region Properties
		public int Length => querys.Length;
		#endregion //Properties

		#region Methods
		public override void Reset()
		{
			foreach (var query in querys)
			{
				query.Reset();
			}
		}

		public override void Find(string text)
		{
			foreach (var query in querys)
			{
				query.Find(text);
			}
		}
		#endregion //Methods
	}
}

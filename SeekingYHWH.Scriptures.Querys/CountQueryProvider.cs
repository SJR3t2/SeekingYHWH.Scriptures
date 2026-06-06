using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class CountQueryProvider : MultipleQueryProvider
	{
		#region Fields
		protected readonly int count;
		#endregion //Fields

		#region Constructors
		protected CountQueryProvider(int count, QueryProvider[] providers)
			: base(providers)
		{
			this.count = count;
		}
		#endregion //Constructors

		#region Properties
		public int Count => count;
		#endregion //Properties
	}
}

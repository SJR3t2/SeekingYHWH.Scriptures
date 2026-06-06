using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountIndexEQQueryProvider : CountIndexQueryProvider
	{
		#region Constructors
		public CountIndexEQQueryProvider(int count, string text, StringComparison comparison)
			: base(count, text, comparison)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var query = new CountIndexEQQuery(count, text, comparison);
			return query;
		}
		#endregion //Methods
	}
}

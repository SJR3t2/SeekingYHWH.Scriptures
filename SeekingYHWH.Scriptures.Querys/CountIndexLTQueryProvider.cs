using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountIndexLTQueryProvider : CountIndexQueryProvider
	{
		#region Constructors
		public CountIndexLTQueryProvider(int count, string text, StringComparison comparison)
			: base(count, text, comparison)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var query = new CountIndexLTQuery(count, text, comparison);
			return query;
		}
		#endregion //Methods
	}
}

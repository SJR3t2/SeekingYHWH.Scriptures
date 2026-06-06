using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountIndexLEQueryProvider : CountIndexQueryProvider
	{
		#region Constructors
		public CountIndexLEQueryProvider(int count, string text, StringComparison comparison)
			: base(count, text, comparison)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var query = new CountIndexLEQuery(count, text, comparison);
			return query;
		}
		#endregion //Methods
	}
}

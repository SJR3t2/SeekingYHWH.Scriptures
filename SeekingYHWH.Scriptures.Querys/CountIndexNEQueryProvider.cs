using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class CountIndexNEQueryProvider : CountIndexQueryProvider
	{
		#region Constructors
		public CountIndexNEQueryProvider(int count, string text, StringComparison comparison)
			: base(count, text, comparison)
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			var query = new CountIndexNEQuery(count, text, comparison);
			return query;
		}
		#endregion //Methods
	}
}

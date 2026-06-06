using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class NContainsQueryProvider : QueryProvider
	{
		#region Fields
		private readonly string contains;
		#endregion //Fields

		#region Constructors
		public NContainsQueryProvider(string contains)
			: base()
		{
			this.contains = contains;
		}
		#endregion //Constructors

		#region Properties
		public string Contains => contains;
		#endregion //Properties

		#region Methods
		public override Query Create()
		{
			var predicate = new NContainsQuery(contains);
			return predicate;
		}
		#endregion //Methods
	}
}

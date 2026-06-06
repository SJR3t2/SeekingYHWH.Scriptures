using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class FalseQueryProvider : ConstantQueryProvider
	{
		#region Constructors
		public FalseQueryProvider()
			: base()
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			return new FalseQuery();
		}
		#endregion //Methods
	}
}

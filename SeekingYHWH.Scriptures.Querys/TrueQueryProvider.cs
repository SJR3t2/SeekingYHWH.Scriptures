using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class TrueQueryProvider : ConstantQueryProvider
	{
		#region Constructors
		public TrueQueryProvider()
			: base()
		{
		}
		#endregion //Constructors

		#region Methods
		public override Query Create()
		{
			return new TrueQuery();
		}
		#endregion //Methods
	}
}

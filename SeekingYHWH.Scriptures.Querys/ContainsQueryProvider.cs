using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public sealed class ContainsQueryProvider : QueryProvider
	{
		#region Fields
		private readonly string text;
		#endregion //Fields

		#region Constructors
		public ContainsQueryProvider(string text)
			: base()
		{
			this.text = text;
		}
		#endregion //Constructors

		#region Properties
		public string Text => text;
		#endregion //Properties

		#region Methods
		public override Query Create()
		{
			var predicate = new ContainsQuery(text);
			return predicate;
		}
		#endregion //Methods
	}
}

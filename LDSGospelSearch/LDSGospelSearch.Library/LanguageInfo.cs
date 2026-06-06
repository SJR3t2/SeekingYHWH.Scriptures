using System;
using System.Collections.Generic;
using System.Text;

namespace LDSGospelSearch
{
	public class LanguageInfo
	{
		#region Fields
		private readonly int id;
		private readonly string native;
		private readonly string code;
		private readonly string other;
		#endregion //Fields

		#region Constructors
		public LanguageInfo(int id, string native, string code, string other)
		{
			this.id = id;
			this.native = native;
			this.code = code;
			this.other = other;
		}
		#endregion //Constructors

		#region Properties
		public int Id => id;
		public string Native => native;
		public string Code => code;
		public string Other => other;
		#endregion //Properties
	}
}

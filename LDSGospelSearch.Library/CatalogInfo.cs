using System;
using System.Collections.Generic;
using System.Text;

namespace LDSGospelSearch
{
	public class CatalogInfo
	{
		#region Fields
		private readonly int languageId;
		private readonly string languageCode;
		private readonly int version;
		#endregion //Fields

		#region Constructors
		public CatalogInfo(int languageId, string languageCode, int version)
		{
			this.languageId = languageId;
			this.languageCode = languageCode;
			this.version = version;
		}
		#endregion //Constructors

		#region Properties
		public int LanguageId => languageId;
		public string LanguageCode => languageCode;
		public int Version => version;
		#endregion //Properties
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LDSGospelSearch
{
	public class NavigationInfo
	{
		#region Fields
		private readonly string title;
		private readonly string html;
		#endregion //Fields

		#region Constructors
		public NavigationInfo(string title, string html)
		{
			this.title = title;
			this.html = html;
		}
		#endregion //Constructors

		#region Properties

		public string Title => title;
		public string HTML => html;
		#endregion //Properties
	}
}

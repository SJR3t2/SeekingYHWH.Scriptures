using System;
using System.Collections.Generic;
using System.Text;

using SeekingYHWH.Scriptures.LDSGospelLibrary;
using SeekingYHWH.Scriptures;

namespace LDSGospelSearch
{
	public sealed class SearchState
	{
		#region Fields
		private readonly SearchStates states;
		private readonly Extractor extractor;
		private Query query;
		#endregion //Fields

		#region Constructors
		public SearchState(SearchStates states, Extractor extractor)
		{
			this.states = states;
			this.extractor = extractor;
		}
		#endregion //Constructors

		#region Properties
		public SearchStates States => states;
		public Extractor Extractor => extractor;
		public Query Query { get => query; set => query = value; }
		#endregion //Properties
	}
}

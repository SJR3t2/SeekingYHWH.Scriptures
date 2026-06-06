using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SeekingYHWH.Scriptures
{
	public abstract class QueryParserParser
	{
		#region Fields
		protected readonly List<string> errors = new List<string>();
		#endregion //Fields

		#region Constructors
		public QueryParserParser()
		{
		}
		#endregion //Constructors

		#region Properties
		public List<string> Errors => errors;
		#endregion //Properties

		#region Methods
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void AddError(string error)
		{
			errors.Add(error);
		}
		#endregion //Methods
	}
}

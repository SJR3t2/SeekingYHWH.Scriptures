using System;
using System.Collections.Generic;
using System.Text;

using Innovoft.IO;

namespace SeekingYHWH.Scriptures;

partial class Searcher
{
	private sealed class Verse
	{
		private readonly BytesColumn name = new BytesColumn();
		private readonly BytesColumn text = new BytesColumn();

		public Verse()
		{
		}

		public BytesColumn Name => name;
		public BytesColumn Text => text;

		public void Clear()
		{
			name.Clear();
			text.Clear();
		}
	}
}

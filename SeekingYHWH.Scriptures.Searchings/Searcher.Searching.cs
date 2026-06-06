using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

using Innovoft.IO;

namespace SeekingYHWH.Scriptures;

partial class Searcher
{
	private sealed class Searching
	{
		public static int LengthDescendingComparison(Searching x, Searching y)
		{
			var xReaderLength = x!.Reader!.Length;
			var yReaderLength = y!.Reader!.Length;
			if (xReaderLength == yReaderLength)
			{
				return 0;
			}
			if (xReaderLength < yReaderLength)
			{
				return +1;
			}
			else
			{
				return -1;
			}
		}

		private readonly int book;
		private readonly string? pre;
		
		private BytesSplitReader? reader;
		private readonly BytesColumn[] header = new BytesColumn[1];
		private readonly BytesColumn[] columns = new BytesColumn[2];
		private readonly Queue<Verse> queue = new Queue<Verse>();

		private bool finished = false;

		public Searching(int book, string? pre, BytesSplitReader? reader)
		{
			this.book = book;
			this.pre = pre;
			this.reader = reader;
		}

		~Searching()
		{
			Dispose(disposing: false);
		}

		public int Book => book;
		
		public string? Pre => pre;
		
		public BytesSplitReader? Reader => reader;

		public bool Finished => finished;

		public void Dispose()
		{
			Dispose(disposing: true);
		}

		private void Dispose(bool disposing)
		{
			if (!disposing)
			{
				return;
			}

			Interlocked.Exchange(ref reader, null)?.Dispose();
		}

		public bool TryRead(BytesColumn title, List<Verse> verses, out long offset)
		{
			lock (reader!)
			{
				foreach (var verse in verses)
				{
					queue.Enqueue(verse);
				}
				verses.Clear();
				header[0] = title;
				while (true)
				{
					offset = reader!.Position;
					title.Clear();
					if (!reader!.ReadColumnsEnding(seperator, header))
					{
						finished = true;
						return false;
					}
					while (true)
					{
						if (!queue.TryDequeue(out var verse))
						{
							verse = new Verse();
						}
						verse.Clear();
						var text = verse.Text;
						columns[0] = verse.Name;
						columns[1] = text;
						if (!reader!.ReadColumnsEnding(seperator, columns) ||
							text.Count <= 0)
						{
							queue.Enqueue(verse);
							return true;
						}
						verses.Add(verse);
					}
				}
			}
		}
	}
}

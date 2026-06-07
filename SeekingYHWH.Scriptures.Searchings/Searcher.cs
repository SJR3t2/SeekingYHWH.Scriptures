using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading;

using Innovoft.IO;

namespace SeekingYHWH.Scriptures;

public sealed partial class Searcher
{
	private const byte seperator = BytesSplitReader.Tab;

	private static readonly Comparison<Searching> searchingsComparison = Searching.LengthDescendingComparison;
	private static readonly Comparison<Matchs> matchssComparison = Matchs.OffsetAscendingComparison;

	private int threadsCount;

	private ThreadStart? search;

	private QueryProvider? provider;

	private readonly Queue<Searching> searchings = new Queue<Searching>();
	private readonly List<Searching> searchingsBuilder = new List<Searching>();
	private SpinLock searchingsLock = new SpinLock(false);

	private readonly List<Matchs> matchss = new List<Matchs>();
	private SpinLock matchssLock = new SpinLock(false);

	public Searcher()
	{
		this.threadsCount = Environment.ProcessorCount;
	}

	public Searcher(int threadsCount)
	{
		this.threadsCount = threadsCount;
	}

	public int ThreadsCount { get => threadsCount; set => threadsCount = value; }

	public void SearchBySentence()
	{
		search = SearchSentence;
	}

	public void SearchByVerse()
	{
		search = SearchVerse;
	}

	public void SearchByChapter()
	{
		search = SearchChapter;
	}

	public List<string> Search(string languagePath, IEnumerable<BookInfo> books, QueryProvider provider)
	{
		this.provider = provider;

		searchings.Clear();
		searchingsBuilder.Clear();
		foreach (var book in books)
		{
			var readerPath = Path.Combine(languagePath!, book.Code + ".tsv.br");
			var readerFile = new FileStream(readerPath, FileMode.Open, FileAccess.Read, FileShare.Read);
			var readerStream = new BrotliStream(readerFile, CompressionMode.Decompress);
			var reader = new BytesSplitReader(readerStream);
			var searching = new Searching(searchingsBuilder.Count, book.Pre, reader, readerFile.Length);
			searchingsBuilder.Add(searching);
		}
		searchingsBuilder.Sort(searchingsComparison);
		foreach (var searching in searchingsBuilder)
		{
			searchings.Enqueue(searching);
		}

		var threads = new Thread[threadsCount - 1];
		for (var i = threadsCount - 2; i >= 0; --i)
		{
			var thread = new Thread(search!);
			threads[i] = thread;
			thread.Start();
		}
		search!();

		foreach (var thread in threads)
		{
			thread.Join();
		}

		foreach (var searching in searchingsBuilder)
		{
			searching.Dispose();
		}
		searchingsBuilder.Clear();

		matchss.Sort(matchssComparison);
		var values = new List<string>();
		foreach (var matchs in matchss)
		{
			values.AddRange(matchs.Values);
		}
		matchss.Clear();
		return values;
	}

	private void SearchSentence()
	{
		var query = provider!.Create();
		var title = new BytesColumn();
		var verses = new List<Verse>();
		var builder = new StringBuilder();
		while (TryGetSearching(out var searching))
		{
			var book = searching!.Book;
			var pre = searching.Pre;
			while (searching!.TryRead(title, verses, out var offset))
			{
				var titleText = default(string);
				var titleSeperator = default(string);
				var matchs = default(List<string>);
				foreach (var verse in verses)
				{
					var verseText = verse.Text;
					var verseTextCount = verseText.Count;
					var verseTextLast = verseTextCount - 1;
					for (var starting = 0; starting < verseTextCount;)
					{
						query.Reset();
						string text;
						if (starting < verseTextLast &&
							verseText.TryIndexOf(0x2E, starting + 1, out var index))//.
						{
							text = verseText.ToStringEnding(starting, index);
							starting = index + 1;
						}
						else
						{
							text = verseText.ToString(starting);
							starting = verseTextCount;
						}
						query.Find(text);
						if (!query.Evaluate())
						{
							continue;
						}
						if (titleText is null)
						{
							titleText = title.ToString();
							if (!string.IsNullOrWhiteSpace(pre))
							{
								titleText = pre + " " + titleText;
							}
							titleSeperator = char.IsDigit(titleText[titleText.Length - 1]) ? ":" : " ";
							matchs = new List<string>();
						}
						string match;
						var nameColumn = verse.Name;
						if (nameColumn.Count > 0)
						{
							var nameText = nameColumn.ToString();
							builder.Clear();
							builder.Append(titleText);
							builder.Append(titleSeperator);
							builder.Append(nameText);
							builder.Append(' ');
							builder.Append(text);
							match = builder.ToString();
						}
						else
						{
							builder.Clear();
							builder.AppendLine(titleText);
							builder.Append(text);
							match = builder.ToString();
						}
						matchs!.Add(match);
					}
				}
				if (matchs is not null)
				{
					MatchsAdd(book, offset, matchs);
				}
			}
		}
	}

	private void SearchVerse()
	{
		var query = provider!.Create();
		var title = new BytesColumn();
		var verses = new List<Verse>();
		var builder = new StringBuilder();
		while (TryGetSearching(out var searching))
		{
			var book = searching!.Book;
			var pre = searching.Pre;
			while (searching!.TryRead(title, verses, out var offset))
			{
				var titleText = default(string);
				var titleSeperator = default(string);
				var matchs = default(List<string>);
				foreach (var verse in verses)
				{
					query.Reset();
					var text = verse.Text.ToString();
					query.Find(text);
					if (!query.Evaluate())
					{
						continue;
					}
					if (titleText is null)
					{
						titleText = title.ToString();
						if (!string.IsNullOrWhiteSpace(pre))
						{
							titleText = pre + " " + titleText;
						}
						titleSeperator = char.IsDigit(titleText[titleText.Length - 1]) ? ":" : " ";
						matchs = new List<string>();
					}
					string match;
					var nameColumn = verse.Name;
					if (nameColumn.Count > 0)
					{
						var nameText = nameColumn.ToString();
						builder.Clear();
						builder.Append(titleText);
						builder.Append(titleSeperator);
						builder.Append(nameText);
						builder.Append(' ');
						builder.Append(text);
						match = builder.ToString();
					}
					else
					{
						builder.Clear();
						builder.AppendLine(titleText);
						builder.Append(text);
						match = builder.ToString();
					}
					matchs!.Add(match);
				}
				if (matchs is not null)
				{
					MatchsAdd(book, offset, matchs);
				}
			}
		}
	}

	private void SearchChapter()
	{
		var query = provider!.Create();
		var title = new BytesColumn();
		var verses = new List<Verse>();
		var builder = new StringBuilder();
		while (TryGetSearching(out var searching))
		{
			var book = searching!.Book;
			var pre = searching.Pre;
			while (searching!.TryRead(title, verses, out var offset))
			{
				query.Reset();
				foreach (var verse in verses)
				{
					var text = verse.Text.ToString();
					query.Find(text);
					if (!query.Evaluate())
					{
						continue;
					}
					var match = title.ToString();
					if (!string.IsNullOrWhiteSpace(pre))
					{
						match = pre + " " + match;
					}
					var matchs = new List<string>(1) { match, };
					MatchsAdd(book, offset, matchs);
					break;
				}
			}
		}
	}

	private bool TryGetSearching(out Searching? value)
	{
		var locked = false;
		try
		{
			searchingsLock.Enter(ref locked);
			while (true)
			{
				if (!searchings.TryDequeue(out value))
				{
					return false;
				}
				if (value.Finished)
				{
					continue;
				}
				searchings.Enqueue(value);
				return true;
			}
		}
		finally
		{
			if (locked)
			{
				searchingsLock.Exit();
			}
		}
	}

	private void MatchsAdd(int book, long offset, List<string> values)
	{
		var value = new Matchs(book, offset, values);
		var locked = false;
		try
		{
			matchssLock.Enter(ref locked);

			matchss.Add(value);
		}
		finally
		{
			if (locked)
			{
				matchssLock.Exit();
			}
		}
	}
}

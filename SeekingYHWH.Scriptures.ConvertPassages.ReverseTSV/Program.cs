using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeekingYHWH.Scripturtes;

internal static class Program
{
	private static string sourcePath = @"D:\Projects\SeekingYHWH\Scriptures\BookOfMormon.LDS.RLDS.tsv";
	private static string resultsPath = @"D:\Projects\SeekingYHWH\Scriptures\BookOfMormon.RLDS.LDS.tsv";

	private static FileStream? readerStream = null;
	private static StreamReader? reader = null;
	private static FileStream? writerStream = null;
	private static StreamWriter? writer = null;

	private static long lineNumber = 0;

	public static int Main(string[] args)
	{
		return Run();
	}

	private static int Run()
	{
		readerStream = null;
		reader = null;
		writerStream = null;
		writer = null;
		try
		{
			writerStream = new FileStream(resultsPath, FileMode.Create, FileAccess.Write, FileShare.Read);
			writer = new StreamWriter(writerStream);
			readerStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read, FileShare.Read);
			reader = new StreamReader(readerStream);

			Process();
		}
		catch
		{
			return -1;
		}
		finally
		{
			writer?.Dispose();
			writerStream?.Dispose();
			reader?.Dispose();
			readerStream?.Dispose();
		}
		return 0;
	}

	private static void Process()
	{
		if (!TryReadBook(out var book))
		{
			return;
		}
		while (true)
		{
			writer!.Write(book);

			var prevSourceChapterText = (string)null;
			var prevSourceChapterValue = 0;
			var prevSourceVerseText = (string)null;
			var prevSourceVerseValue = 0;
			var prevResultChapterText = (string)null;
			var prevResultChapterValue = 0;
			var prevResultVerseText = (string)null;
			var prevResultVerseValue = 1;
			var lastResultChapter = 0;
			var lastResultVerse = 0;
			var lastSource = false;
			var lastSourceChapter = (string?)null;
			var lastSourceVerse = (string?)null;
			while (TryReadVerseInfo(out var info))
			{
				var sourceChapterText = info![0];
				int sourceChapterValue;
				if (sourceChapterText != prevSourceChapterText)
				{
					if (prevSourceChapterText != null)
					{
					}
					if (!int.TryParse(sourceChapterText, out sourceChapterValue))
					{
						Console.Error.WriteLine("Invalid Source Chapter Value {0} on line {1} with book {2}",
							sourceChapterText, lineNumber, book);
					}
					else if (sourceChapterValue != prevSourceChapterValue + 1)
					{
						Console.Error.WriteLine("Invalid Source Chapter Increase {0} on line {1} with book {2} PrevOpenChapter {3}",
							sourceChapterText, lineNumber, book, prevSourceChapterText);
					}
					prevSourceChapterText = sourceChapterText;
					prevSourceChapterValue = sourceChapterValue;
					prevSourceVerseText = null;
					prevSourceVerseValue = 0;
				}
				else
				{
					sourceChapterValue = prevSourceChapterValue;
				}
				var sourceVerseText = info[1];
				if (!int.TryParse(sourceVerseText, out var sourceVerseValue))
				{
					Console.Error.WriteLine("Invalid Source Verse Value {0} on line {1} with book {2} chapter {3}",
						sourceVerseText, lineNumber, book, sourceChapterText);
				}
				else if (sourceVerseValue != prevSourceVerseValue + 1)
				{
					Console.Error.WriteLine("Invalid Source Verse Increase {0} on line {1} with book {2} chapter {3} PrevOpenVerse {4}",
						sourceVerseText, lineNumber, book, sourceChapterText, prevSourceVerseText);
				}
				prevSourceVerseText = sourceVerseText;
				prevSourceVerseValue = sourceVerseValue;
				var resultOpenChapterText = info[2];
				int resultOpenChapterValue;
				if (resultOpenChapterText != prevResultChapterText)
				{
					if (!int.TryParse(resultOpenChapterText, out  resultOpenChapterValue))
					{
						Console.Error.WriteLine("Invalid Result Chapter Value {0} on line {1} with book {2}",
							resultOpenChapterText, lineNumber, book);
					}
					else if (resultOpenChapterValue != prevResultChapterValue + 1)
					{
						Console.Error.WriteLine("Invalid Result OpenChapter Increase {0} on line {1} with book {2} PrevCloseChapter {3}",
							resultOpenChapterText, lineNumber, book, prevResultChapterText);
					}
					prevResultChapterText = resultOpenChapterText;
					prevResultChapterValue = resultOpenChapterValue;
					prevResultVerseText = null;
					prevResultVerseValue = 1;
				}
				else
				{
					resultOpenChapterValue = prevResultChapterValue;
				}
					var resultOpenVerseText = info[3];
				if (!int.TryParse(resultOpenVerseText, out var resultOpenVerseValue))
				{
					Console.Error.WriteLine("Invalid Result Verse Min Value {0} on line {1} with book {2}",
						resultOpenVerseText, lineNumber, book);
				}
				else if (resultOpenVerseValue != prevResultVerseValue && resultOpenVerseValue != prevResultVerseValue + 1)
				{
					Console.Error.WriteLine("Invalid Result Verse Min Increase {0} on line {1} with book {2} PrevCloseChapter {3}",
						resultOpenVerseText, lineNumber, book, prevResultVerseText);
				}
				prevResultVerseText = resultOpenVerseText;
				prevResultVerseValue = resultOpenVerseValue;
				string? resultCloseChapterText;
				int resultCloseChapterValue;
				string? resultCloseVerseText;
				int resultCloseVerseValue;
				if (info.Length == 6)
				{
					resultCloseChapterText = info[4];
					if (!int.TryParse(resultCloseChapterText, out resultCloseChapterValue))
					{
						Console.Error.WriteLine("Invalid Result CloseChapter Value {0} on line {1} with book {2}",
							resultCloseChapterText, lineNumber, book);
					}
					else if (resultCloseChapterValue < resultOpenChapterValue)
					{
						Console.Error.WriteLine("Invalid Result CloseChapter Increase {0} on line {1} with book {2} OpenChapter {3}",
							resultCloseChapterText, lineNumber, book, resultOpenChapterValue);
					}
					resultCloseVerseText = info[5];
					if (!int.TryParse(resultCloseVerseText, out resultCloseVerseValue))
					{
						Console.Error.WriteLine("Invalid Result CloseVerse Value {0} on line {1} with book {2}",
							resultCloseVerseText, lineNumber, book);
					}
					else if (resultCloseVerseValue <= resultOpenVerseValue)
					{
						Console.Error.WriteLine("Invalid Result CloseVerse Increase {0} on line {1} with book {2} PrevCloseChapter {3}",
							resultCloseVerseText, lineNumber, book, prevResultVerseText);
					}
					prevResultChapterText = resultCloseChapterText;
					prevResultChapterValue = resultCloseChapterValue;
					prevResultVerseText = resultCloseVerseText;
					prevResultVerseValue = resultCloseVerseValue;
				}
				else
				{
					resultCloseChapterText = null;
					resultCloseChapterValue = 0;
					resultCloseVerseText = null;
					resultCloseVerseValue = 0;
				}
				if (resultOpenChapterValue != lastResultChapter || resultOpenVerseValue != lastResultVerse)
				{
					if (lastSource)
					{
						writer.Write('\t');
						writer.Write(lastSourceChapter);
						writer.Write('\t');
						writer.Write(lastSourceVerse);
						lastSource = false;
						lastSourceChapter = null;
						lastSourceVerse = null;
					}
					writer.WriteLine();
					writer.Write(resultOpenChapterText);
					writer.Write('\t');
					writer.Write(resultOpenVerseText);
					writer.Write('\t');
					writer.Write(sourceChapterText);
					writer.Write('\t');
					writer.Write(sourceVerseText);
					lastResultChapter = resultOpenChapterValue;
					lastResultVerse = resultOpenVerseValue;
				}
				else
				{
					lastSource = true;
					lastSourceChapter = sourceChapterText;
					lastSourceVerse = sourceVerseText;
				}
				if (resultCloseVerseText != null)
				{
					if (lastSource)
					{
						writer.Write('\t');
						writer.Write(lastSourceChapter);
						writer.Write('\t');
						writer.Write(lastSourceVerse);
						lastSource = false;
						lastSourceChapter = null;
						lastSourceVerse = null;
					}
					for (var verse = resultOpenVerseValue + 1; verse <= resultCloseVerseValue; ++verse)
					{
						writer.WriteLine();
						writer.Write(resultOpenChapterText);
						writer.Write('\t');
						writer.Write(verse);
						writer.Write('\t');
						writer.Write(sourceChapterText);
						writer.Write('\t');
						writer.Write(sourceVerseText);
					}
					lastResultChapter = resultCloseChapterValue;
					lastResultVerse = resultCloseVerseValue;
				}
			}

			if (lastSource)
			{
				writer.Write('\t');
				writer.Write(lastSourceChapter);
				writer.Write('\t');
				writer.Write(lastSourceVerse);
				lastSource = false;
				lastSourceChapter = null;
				lastSourceVerse = null;
			}
			writer.WriteLine();

			if (!TryReadBook(out book))
			{
				return;
			}
			writer!.WriteLine();
		}
	}

	private static bool TryReadBook(out string? value)
	{
		while (true)
		{
			var line = reader!.ReadLine();
			if (line == null)
			{
				value = null;
				return false;
			}
			++lineNumber;
			if (line.Length <= 0)
			{
				continue;
			}
			value = line;
			return true;
		}
	}

	private static bool TryReadVerseInfo(out string[]? value)
	{
		var line = reader!.ReadLine();
		if (line == null)
		{
			value = null;
			return false;
		}
		++lineNumber;
		if (line.Length <= 0)
		{
			value = null;
			return false;
		}
		value = line.Split('\t');
		return true;
	}
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeekingYHWH.Scriptures;

internal static class Program
{
	//private static string sourcePath = @"D:\Projects\SeekingYHWH\Scriptures\BookOfMormon.LDS.RLDS.tsv";
	//private static string nameSpace = "SeekingYHWH.Scriptures";
	//private static string className = "BoMLDS";
	//private static string resultsPath = @"D:\Projects\SeekingYHWH\Scriptures\SeekingYHWH.Scriptures.ConvertPassages\BoMLDS.cs";
	private static string sourcePath = @"D:\Projects\SeekingYHWH\Scriptures\BookOfMormon.RLDS.LDS.tsv";
	private static string nameSpace = "SeekingYHWH.Scriptures";
	private static string className = "BoMRLDS";
	private static string resultsPath = @"D:\Projects\SeekingYHWH\Scriptures\SeekingYHWH.Scriptures.ConvertPassages\BoMRLDS.cs";

	private static FileStream? readerStream = null;
	private static StreamReader? reader = null;
	private static FileStream? writerStream = null;
	private static StreamWriter? writer = null;

	private static Dictionary<string, Dictionary<int, VerseInfo>> booksChapters = new Dictionary<string, Dictionary<int, VerseInfo>>();
	private static long lineNumber = 0;

	public static int Main(string[] args)
	{
		return Run();
	}

	private static int Run()
	{
		ChapterInfos();
		return Write();
	}

	private static int ChapterInfos()
	{
		lineNumber = 0;
		readerStream = null;
		reader = null;
		try
		{
			readerStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read, FileShare.Read);
			reader = new StreamReader(readerStream);

			while (TryReadBook(out var book))
			{
				var bookChapters = new Dictionary<int, VerseInfo>();
				booksChapters.Add(book, bookChapters);
				var prevSourceChapterText = (string?)null;
				var prevSourceChapterValue = 0;
				var prevSourceVerseText = (string?)null;
				var prevSourceVerseValue = 0;
				var prevResultChapterText = (string?)null;
				var prevResultChapterValue = 0;
				var prevResultVerseText = (string?)null;
				var prevResultVerseValue = 1;
				var chapterOpen = false;
				while (true)
				{
					if (!TryReadVerseInfo(out var info))
					{
						var chapterInfo = new VerseInfo(0, chapterOpen ? 1 : 0, 0, 1);
						bookChapters.Add(prevSourceChapterValue, chapterInfo);
						break;
					}
					var sourceChapterText = info[0];
					int sourceChapterValue;
					if (sourceChapterText != prevSourceChapterText)
					{
						int.TryParse(sourceChapterText, out sourceChapterValue);
						prevSourceVerseText = null;
						prevSourceVerseValue = 0;
					}
					else
					{
						sourceChapterValue = prevSourceChapterValue;
					}
					var sourceVerseText = info[1];
					int.TryParse(sourceVerseText, out var sourceVerseValue);
					prevSourceVerseText = sourceVerseText;
					prevSourceVerseValue = sourceVerseValue;
					var resultOpenChapterText = info[2];
					int resultOpenChapterValue;
					if (resultOpenChapterText != prevResultChapterText)
					{
						int.TryParse(resultOpenChapterText, out resultOpenChapterValue);
						prevResultVerseText = null;
						prevResultVerseValue = 0;
					}
					else
					{
						resultOpenChapterValue = prevResultChapterValue;
					}
					var resultOpenVerseText = info[3];
					int.TryParse(resultOpenVerseText, out var resultOpenVerseValue);
					string? resultCloseChapterText;
					int resultCloseChapterValue;
					string? resultCloseVerseText;
					int resultCloseVerseValue;
					if (info.Length == 6)
					{
						resultCloseChapterText = info[4];
						int.TryParse(resultCloseChapterText, out resultCloseChapterValue);
						resultCloseVerseText = info[5];
						int.TryParse(resultCloseVerseText, out resultCloseVerseValue);
					}
					else
					{
						resultCloseChapterText = null;
						resultCloseChapterValue = 0;
						resultCloseVerseText = null;
						resultCloseVerseValue = 0;
					}
					if (sourceChapterValue != prevSourceChapterValue && prevSourceChapterValue != 0)
					{
						var chapterClose = resultOpenChapterValue != prevResultChapterValue && resultOpenVerseValue == 1;
						if (chapterClose || chapterOpen)
						{
							var chapterInfo = new VerseInfo(0, chapterOpen ? 1 : 0, 0, chapterClose ? 1 : 0);
							bookChapters.Add(prevSourceChapterValue, chapterInfo);
						}
						chapterOpen = false;
					}
					if (sourceVerseValue == 1 && resultOpenVerseValue == 1 && prevResultVerseValue != 1)
					{
						chapterOpen = true;
					}
					prevSourceChapterText = sourceChapterText;
					prevSourceChapterValue = sourceChapterValue;
					prevSourceVerseText = sourceVerseText;
					prevSourceVerseValue = sourceVerseValue;
					prevResultChapterText = resultOpenChapterText;
					prevResultChapterValue = resultOpenChapterValue;
					prevResultVerseText = resultOpenVerseText;
					prevResultVerseValue = resultOpenVerseValue;
					if (info.Length == 6)
					{
						prevResultChapterText = resultCloseChapterText;
						prevResultChapterValue = resultCloseChapterValue;
						prevResultVerseText = resultCloseVerseText;
						prevResultVerseValue = resultCloseVerseValue;
					}
				}
			}
		}
		catch
		{
			return -1;
		}
		finally
		{
			reader?.Dispose();
			readerStream?.Dispose();
		}
		return 0;
	}

	private static int Write()
	{
		lineNumber = 0;
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

			writer.WriteLine("using System;");
			writer.WriteLine("using System.Collections.Generic;");
			writer.WriteLine();
			writer.Write("namespace ");
			writer.Write(nameSpace);
			writer.WriteLine(';');
			writer.WriteLine();
			writer.Write("public static class ");
			writer.WriteLine(className);
			writer.WriteLine("{");//class
			writer.WriteLine("\tpublic static readonly Dictionary<string, VerseInfo?[]?[]> Books = new Dictionary<string, VerseInfo?[]?[]>()");
			writer.WriteLine("\t{");//field

			while (TryReadBook(out var book))
			{
				var bookChapters = booksChapters[book];

				writer.Write("\t\t{ \"");//book
				writer.Write(book);
				writer.WriteLine("\", new VerseInfo?[]?[]");
				writer.WriteLine("\t\t\t{");
				writer.WriteLine("\t\t\t\tnull,");

				var prevSourceChapterText = (string?)null;
				var prevSourceChapterValue = 0;
				var prevSourceVerseText = (string?)null;
				var prevSourceVerseValue = 0;
				var prevResultChapterText = (string?)null;
				var prevResultChapterValue = 0;
				var prevResultVerseText = (string?)null;
				var prevResultVerseValue = 1;
				while (TryReadVerseInfo(out var info))
				{
					var sourceChapterText = info[0];
					int sourceChapterValue;
					if (sourceChapterText != prevSourceChapterText)
					{
						if (prevSourceChapterText != null)
						{
							writer.WriteLine("\t\t\t\t},");
						}
						writer.WriteLine("\t\t\t\tnew VerseInfo?[]");
						writer.WriteLine("\t\t\t\t{");
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
						if (bookChapters.TryGetValue(sourceChapterValue, out var bookChapter))
						{
							writer.Write("\t\t\t\t\tnew VerseInfo(");
							writer.Write(bookChapter.CloseChapter);
							writer.Write(", ");
							writer.Write(bookChapter.OpenVerse);
							writer.Write(", ");
							writer.Write(bookChapter.CloseChapter);
							writer.Write(", ");
							writer.Write(bookChapter.CloseVerse);
							writer.Write("),");
						}
						else
						{
							writer.Write("\t\t\t\t\tnull,");
						}
						writer.Write("//");
						writer.Write(book);
						writer.Write(' ');
						writer.WriteLine(sourceChapterText);
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
					writer.Write("\t\t\t\t\tnew VerseInfo(");
					var resultOpenChapterText = info[2];
					int resultOpenChapterValue;
					if (resultOpenChapterText != prevResultChapterText)
					{
						if (!int.TryParse(resultOpenChapterText, out resultOpenChapterValue))
						{
							Console.Error.WriteLine("Invalid Result OpenChapter Value {0} on line {1} with book {2}",
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
					writer.Write(resultOpenChapterText);//Result Chapter
					writer.Write(", ");
					var resultVerseMinText = info[3];
					if (!int.TryParse(resultVerseMinText, out var resultOpenVerseValue))
					{
						Console.Error.WriteLine("Invalid Result Verse Min Value {0} on line {1} with book {2}",
							resultVerseMinText, lineNumber, book);
					}
					else if (resultOpenVerseValue != prevResultVerseValue && resultOpenVerseValue != prevResultVerseValue + 1)
					{
						Console.Error.WriteLine("Invalid Result Verse Min Increase {0} on line {1} with book {2} PrevCloseChapter {3}",
							resultVerseMinText, lineNumber, book, prevResultVerseText);
					}
					prevResultVerseText = resultVerseMinText;
					prevResultVerseValue = resultOpenVerseValue;
					writer.Write(resultVerseMinText);//Result Verse Min
					if (info.Length == 6)
					{
						var resultCloseChapterText = info[4];
						if (!int.TryParse(resultCloseChapterText, out var resultCloseChapterValue))
						{
							Console.Error.WriteLine("Invalid Result CloseChapter Value {0} on line {1} with book {2}",
								resultCloseChapterText, lineNumber, book);
						}
						else if (resultCloseChapterValue < resultOpenChapterValue)
						{
							Console.Error.WriteLine("Invalid Result CloseVerse Increase {0} on line {1} with book {2} Result OpenChapter {3}",
								resultCloseChapterText, lineNumber, book, resultOpenChapterText);
						}
						var resultCloseVerseText = info[5];
						if (!int.TryParse(resultCloseVerseText, out var resultCloseVerseValue))
						{
							Console.Error.WriteLine("Invalid Result CloseVerse Value {0} on line {1} with book {2}",
								resultCloseVerseText, lineNumber, book);
						}
						else if (resultCloseChapterValue == resultOpenChapterValue && resultCloseVerseValue <= resultOpenVerseValue)
						{
							Console.Error.WriteLine("Invalid Result CloseVerse Increase {0} on line {1} with book {2} PrevCloseChapter {3}",
								resultCloseVerseText, lineNumber, book, prevResultVerseText);
						}
						prevResultVerseText = resultCloseVerseText;
						prevResultVerseValue = resultCloseVerseValue;
						writer.Write(", ");
						writer.Write(resultCloseChapterText);//CloseChapter
						writer.Write(", ");
						writer.Write(resultCloseVerseText);//CloseVerse
					}
					writer.Write("),//");
					writer.Write(book);
					writer.Write(' ');
					writer.Write(sourceChapterText);
					writer.Write(':');
					writer.WriteLine(sourceVerseText);
				}

				writer.WriteLine("\t\t\t\t},");
				writer.WriteLine("\t\t\t}");
				writer.WriteLine("\t\t},");//book
			}

			writer.WriteLine("\t};");//field
			writer.WriteLine("}");//class
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
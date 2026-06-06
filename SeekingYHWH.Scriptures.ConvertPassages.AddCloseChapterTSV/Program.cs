using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeekingYHWH.Scripturtes;

internal static class Program
{
	private static string sourcePath = @"D:\Projects\SeekingYHWH\Scriptures\BookOfMormon.LDS.RLDS.MissingCloseChapter.tsv";
	private static string resultsPath = @"D:\Projects\SeekingYHWH\Scriptures\BookOfMormon.LDS.RLDS.tsv";

	private static int Main(string[] args)
	{
		return Run();
	}

	private static int Run()
	{
		var readerStream = (FileStream?)null;
		var reader = (StreamReader?)null;
		var writerStream = (FileStream?)null;
		var writer = (StreamWriter?)null;
		try
		{
			writerStream = new FileStream(resultsPath, FileMode.Create, FileAccess.Write, FileShare.Read);
			writer = new StreamWriter(writerStream);
			readerStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read, FileShare.Read);
			reader = new StreamReader(readerStream);

			while (true)
			{
				var line = reader.ReadLine();
				if (line == null)
				{
					break;
				}

				var columns = line.Split('\t');

				if (columns.Length < 5)
				{
					writer.WriteLine(line);
				}
				else if (columns.Length > 5)
				{
					Console.Error.WriteLine(line);
				}
				else
				{
					writer.Write(columns[0]);
					writer.Write('\t');
					writer.Write(columns[1]);
					writer.Write('\t');
					writer.Write(columns[2]);
					writer.Write('\t');
					writer.Write(columns[3]);
					writer.Write('\t');
					writer.Write(columns[2]);
					writer.Write('\t');
					writer.Write(columns[4]);
					writer.WriteLine();
				}
			}
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
}

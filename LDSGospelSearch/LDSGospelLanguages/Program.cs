using LDSGospelSearch;

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace LDSGospelLanguages
{
	internal static class Program
	{
		#region Main
		private static void Main(string[] args)
		{
			var errors = ParseCommandLine(args);
			if (errors != null)
			{
				PrintHelp(errors);
				return;
			}

			Prepare();
			Results();
		}
		#endregion Main

		#region Fields
		private static string sourcePath;
		private static string resultsPath;
		#endregion //Fields

		#region Methods
		private static List<string> ParseCommandLine(string[] args)
		{
			var errors = new List<string>();
			if (args == null || args.Length == 0)
			{
				return errors;
			}

			for (var i = 0; i < args.Length; ++i)
			{
				switch (args[i])
				{
				default:
					errors.Add("Invalid Parameter: " + args[i]);
					break;

				case "-Source":
					try
					{
						sourcePath = args[++i];
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -Source " + exception.Message);
					}
					break;

				case "-Results":
					try
					{
						resultsPath = args[++i];
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -Results " + exception.Message);
					}
					break;
				}
			}

			if (errors.Count > 0)
			{
				return errors;
			}

			return null;
		}

		private static void PrintHelp(List<string> errors)
		{
			Console.WriteLine();
			Console.WriteLine("LDSGospelLanguages.exe");
			Console.WriteLine(" Required");
			Console.WriteLine("  -Results Results.txt");
			Console.WriteLine(" Optional");
			Console.WriteLine("  -Source Folder");
			Console.WriteLine();

			if (errors != null && errors.Count > 0)
			{
				foreach (var error in errors)
				{
					Console.Error.WriteLine(error);
				}
				Console.WriteLine();
			}
		}

		private static void Prepare()
		{
			Console.Title = "LDSGospelLanguages";

			PrepareSourcePath();

			GC.Collect();
		}

		private static void PrepareSourcePath()
		{
			if (sourcePath != null)
			{
				return;
			}

			sourcePath = Library.GetSourcePath();
		}

		private static void Results()
		{
			switch (Path.GetExtension(resultsPath))
			{
			case ".txt":
				Text("\t");
				break;

			case ".csv":
				Text(",");
				break;

			case ".html":
			case ".htm":
				HTML();
				break;

			default:
				throw new FormatException();
			}
		}

		private static void Text(string separator)
		{
			using (var writerStream = new FileStream(resultsPath, FileMode.Create, FileAccess.Write, FileShare.Read))
			using (var writer = new StreamWriter(writerStream))
			{
				var path = Path.Combine(sourcePath, @"persisted-catalog.sqlite");
				if (!File.Exists(path))
				{
					Console.WriteLine("Missing file persisted-catalog.sqlite");
					return;
				}
				var connectionString = Library.CreateConnectionString(path);
				using (var connection = new SQLiteConnection(connectionString))
				{
					connection.Open();

					TextHeader(writer, separator);

					var sql = "SELECT id, native_name, iso639_3, bcp47 FROM persisted_language ORDER BY id ASC";
					using (var command = new SQLiteCommand(sql, connection))
					using (var reader = command.ExecuteReader())
					{
						var idOffset = reader.GetOrdinal("id");
						var nativeOffset = reader.GetOrdinal("native_name");
						var codeOffset = reader.GetOrdinal("iso639_3");
						var otherOffset = reader.GetOrdinal("bcp47");

						while (reader.Read())
						{
							var id = reader.GetInt32(idOffset);
							var native = reader.GetString(nativeOffset);
							var code = reader.GetString(codeOffset);
							var other = reader.GetString(otherOffset);
							TextEntry(writer, separator, id, native, code, other);
						}
					}
				}
			}
		}

		private static void TextHeader(StreamWriter writer, string separator)
		{
			writer.Write("Id");
			writer.Write(separator);
			writer.Write("Native");
			writer.Write(separator);
			writer.Write("Code");
			writer.Write(separator);
			writer.Write("Other");
			writer.WriteLine();
		}

		private static void TextEntry(StreamWriter writer, string separator, int id, string native, string code, string other)
		{
			writer.Write(id);
			writer.Write(separator);
			writer.Write(native);
			writer.Write(separator);
			writer.Write(code);
			writer.Write(separator);
			writer.Write(other);
			writer.WriteLine();
		}

		private static void HTML()
		{
			using (var writerStream = new FileStream(resultsPath, FileMode.Create, FileAccess.Write, FileShare.Read))
			using (var writer = new StreamWriter(writerStream))
			{
				var path = Path.Combine(sourcePath, @"persisted-catalog.sqlite");
				if (!File.Exists(path))
				{
					Console.WriteLine("Missing file persisted-catalog.sqlite");
					return;
				}
				var connectionString = Library.CreateConnectionString(path);
				using (var connection = new SQLiteConnection(connectionString))
				{
					connection.Open();

					HTMLHeader(writer);

					var sql = "SELECT native_name, iso639_3 FROM persisted_language ORDER BY id ASC";
					using (var command = new SQLiteCommand(sql, connection))
					using (var reader = command.ExecuteReader())
					{
						var nativeOffset = reader.GetOrdinal("native_name");
						var codeOffset = reader.GetOrdinal("iso639_3");

						while (reader.Read())
						{
							var native = reader.GetString(nativeOffset);
							var code = reader.GetString(codeOffset);
							HTMLEntry(writer, native, code);
						}
					}

					HTMLFooter(writer);
				}
			}
		}

		private static void HTMLHeader(StreamWriter writer)
		{
			writer.WriteLine("<table>");
			writer.WriteLine("<tbody>");
			writer.WriteLine("<tr><th>Native</th><th>Code</th></tr>");
		}

		private static void HTMLEntry(StreamWriter writer, string native, string code)
		{
			writer.Write("<tr>");
			writer.Write("<td>");
			foreach (var c in native)
			{
				writer.Write("&#x{0:X4};", (ushort)c);
			}
			writer.Write("</td>");
			writer.Write("<td>");
			writer.Write(code);
			writer.Write("</td>");
			writer.WriteLine("</tr>");
		}

		private static void HTMLFooter(StreamWriter writer)
		{
			writer.WriteLine("</tbody>");
			writer.WriteLine("</table>");
		}
		#endregion //Methods
	}
}

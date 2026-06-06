using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using SeekingYHWH.Scriptures.LDSGospelLibrary;
using SeekingYHWH.Scriptures;

namespace LDSGospelSearch
{
	internal static class Program
	{
		#region Main
		private static void Main(string[] args)
		{
			Intro();

			var errors = ParseCommandLine(args);
			if (errors != null)
			{
				PrintHelp(errors);
				return;
			}

			Prepare();
			Results();
		}
		#endregion //Main

		#region Fields
		private static string sourcePath;
		private static bool sourceSpecific;
		private static string language;
		private static readonly HashSet<string> books = new HashSet<string>();
		private static readonly SearchStates states = new SearchStates(Extractor.CreateMap());
		private static Func<NavigationInfo, ParallelLoopState, long, SearchState, SearchState> search;
		private static bool separate = true;
		private static readonly ParallelOptions options = new ParallelOptions();
		private static ProcessPriorityClass priority = ProcessPriorityClass.Idle;
		private static FileMode resultsMode = FileMode.Create;
		private static string resultsPath;

		private static int languageId;
		private static string catalogPath;
		private static List<string> catalogs;
		#endregion //Fields

		#region Methods
		private static void Intro()
		{
			Console.Title = "LDSGospelSearch.Console";

			Console.WriteLine("LDSGospelSearch.Console.exe {0} https://SeekingYHWH.org/resources/software/ldsgospelsearch/",
				FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion);
			Console.WriteLine();
		}

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
						sourceSpecific = true;
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -Source " + exception.Message);
					}
					break;

				case "-Language":
					try
					{
						language = args[++i];
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -Language " + exception.Message);
					}
					break;

				case "-BooksAdd":
					try
					{
						foreach (var book in args[++i].Split(','))
						{
							if (!Library.ContainsBook(book))
							{
								continue;
							}

							books.Add(book);
						}
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -BooksAdd " + exception.Message);
					}
					break;

				case "-BooksClear":
					try
					{
						books.Clear();
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -BooksClear " + exception.Message);
					}
					break;

				case "-BooksRemove":
					try
					{
						foreach (var book in args[++i].Split(','))
						{
							books.Remove(book);
						}
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -BooksRemove " + exception.Message);
					}
					break;

				case "-MapAdd":
					try
					{
						var original = args[++i];
						var replace = args[++i];

						if (original.Length != 1)
						{
							continue;
						}

						states.Map[original[0]] = replace;
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -MapAdd " + exception.Message);
					}
					break;

				case "-MapClear":
					try
					{
						states.Map.Clear();
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -MapClear " + exception.Message);
					}
					break;

				case "-MapRemove":
					try
					{
						var original = args[++i];

						if (original.Length != 1)
						{
							continue;
						}

						states.Map.Remove(original[0]);
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -MapRemove " + exception.Message);
					}
					break;

				case "-Search":
					try
					{
						search = ConfigSearch(args[++i]);
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -Search " + exception.Message);
					}
					break;

				case "-Query":
					try
					{
						if (!QueryParserXML.TryParsePath(args[++i], out var provider, out var es))
						{
							foreach (var e in es)
							{
								errors.Add("Problems processing -Query " + e);
							}
						}
						else
						{
							states.Provider = provider;
						}
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -Query " + exception.Message);
					}
					break;

				case "-RenamesAdd":
					try
					{
						var original = args[++i];
						var replace = args[++i];

						states.Renames[original] = replace;
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -RenamesAdd " + exception.Message);
					}
					break;

				case "-RenamesClear":
					try
					{
						states.Renames.Clear();
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -RenamesClear " + exception.Message);
					}
					break;

				case "-RenamesRemove":
					try
					{
						states.Renames.Remove(args[++i]);
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -RenamesRemove " + exception.Message);
					}
					break;

				case "-CapitalizesAdd":
					try
					{
						var text = args[++i];
						var upper = text.ToUpper();

						states.Capitalizes[text] = upper;
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -CapitalizesAdd " + exception.Message);
					}
					break;

				case "-CapitalizesClear":
					try
					{
						states.Capitalizes.Clear();
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -CapitalizesClear " + exception.Message);
					}
					break;

				case "-CapitalizesRemove":
					try
					{
						states.Capitalizes.Remove(args[++i]);
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -CapitalizesRemove " + exception.Message);
					}
					break;

				case "-Separate":
					try
					{
						separate = bool.Parse(args[++i]);
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -Separate " + exception.Message);
					}
					break;

				case "-Threads":
					try
					{
						options.MaxDegreeOfParallelism = int.Parse(args[++i]);
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -Threads " + exception.Message);
					}
					break;

				case "-Priority":
					try
					{
						priority = (ProcessPriorityClass)Enum.Parse(typeof(ProcessPriorityClass), args[++i], ignoreCase: true);
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -Priority " + exception.Message);
					}
					break;

				case "-ResultsMode":
					try
					{
						resultsMode = (FileMode)Enum.Parse(typeof(FileMode), args[++i], ignoreCase: true);
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -ResultsMode " + exception.Message);
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

				case "-Config":
					try
					{
						Config(args[++i]);
					}
					catch (Exception exception)
					{
						errors.Add("Problems processing -Config " + exception.Message);
					}
					break;
				}
			}

			if (search == null)
			{
				errors.Add("Missing -Search");
			}
			if (states.Provider == null)
			{
				errors.Add("Missing -Predicate");
			}

			if (errors.Count > 0)
			{
				return errors;
			}

			return null;
		}

		#region Config
		private static void Config(string path)
		{
			var xml = new XmlDocument();
			xml.Load(path);
			var config = xml.DocumentElement;

			ConfigSource(config.SelectSingleNode("Source"));
			ConfigLanguage(config.SelectSingleNode("Language"));
			ConfigBooks(config.SelectSingleNode("Books"));
			ConfigMap(config.SelectSingleNode("Map"));
			ConfigSearch(config.SelectSingleNode("Search"));
			ConfigQuery(config.SelectSingleNode("Query"));
			ConfigRenames(config.SelectSingleNode("Renames"));
			ConfigCapitalizes(config.SelectSingleNode("Capitalizes"));
			ConfigSeparate(config.SelectSingleNode("Separate"));
			ConfigPriority(config.SelectSingleNode("Priority"));
			ConfigResultsMode(config.SelectSingleNode("ResultsMode"));
			ConfigResults(config.SelectSingleNode("Results"));
		}

		private static void ConfigSource(XmlNode config)
		{
			if (config == null || string.IsNullOrWhiteSpace(config.InnerText))
			{
				return;
			}

			sourcePath = config.InnerText;
		}

		private static void ConfigLanguage(XmlNode config)
		{
			if (config == null || string.IsNullOrWhiteSpace(config.InnerText))
			{
				return;
			}

			language = config.InnerText;
		}

		private static void ConfigBooks(XmlNode config)
		{
			if (config == null)
			{
				return;
			}

			foreach (XmlNode node in config.ChildNodes)
			{
				if (node.NodeType != XmlNodeType.Element)
				{
					continue;
				}

				switch (node.Name)
				{
				case "Add":
					if (!Library.ContainsBook(node.InnerText))
					{
						continue;
					}

					books.Add(node.InnerText);
					break;

				case "Clear":
					books.Clear();
					break;

				case "Remove":
					books.Remove(node.InnerText);
					break;
				}
			}
		}

		private static void ConfigMap(XmlNode config)
		{
			if (config == null)
			{
				return;
			}

			foreach (XmlNode node in config.ChildNodes)
			{
				if (node.NodeType != XmlNodeType.Element)
				{
					continue;
				}

				XmlAttribute original;
				XmlAttribute replace;
				switch (node.Name)
				{
				case "Add":
					original = node.Attributes["Original"];
					replace = node.Attributes["Replace"];
					if (original == null || replace == null)
					{
						continue;
					}
					if (original.InnerText.Length != 1)
					{
						continue;
					}
					states.Map[original.InnerText[0]] = replace.InnerText;
					break;

				case "Clear":
					states.Map.Clear();
					break;

				case "Remove":
					original = node.Attributes["Original"];
					if (original == null)
					{
						continue;
					}
					if (original.InnerText.Length != 1)
					{
						continue;
					}
					states.Map.Remove(original.InnerText[0]);
					break;
				}
			}
		}

		private static void ConfigSearch(XmlNode config)
		{
			if (config == null || string.IsNullOrWhiteSpace(config.InnerText))
			{
				return;
			}

			search = ConfigSearch(config.InnerText);
		}

		private static Func<NavigationInfo, ParallelLoopState, long, SearchState, SearchState> ConfigSearch(string type)
		{
			switch (type)
			{
			case "Verse":
			case "verse":
			case "V":
			case "v":
				return Search.Verse;

			case "Chapter":
			case "chapter":
			case "C":
			case "c":
				return Search.Chapter;

			case "Sentence":
			case "sentence":
			case "S":
			case "s":
				return Search.Sentence;

			default:
				throw new InvalidCastException("Invalid Search: " + type);
			}
		}

		private static void ConfigQuery(XmlNode config)
		{
			if (config == null || string.IsNullOrWhiteSpace(config.InnerText))
			{
				return;
			}

			if (QueryParserXML.TryParse(config, out var provider, out var es))
			{
				states.Provider = provider;
			}
		}

		private static void ConfigRenames(XmlNode config)
		{
			states.ConfigRenames(config);
		}

		private static void ConfigCapitalizes(XmlNode config)
		{
			states.ConfigCapitalizes(config);
		}

		private static void ConfigSeparate(XmlNode config)
		{
			if (config == null || string.IsNullOrWhiteSpace(config.InnerText))
			{
				return;
			}

			separate = bool.Parse(config.InnerText);
		}

		private static void ConfigPriority(XmlNode config)
		{
			if (config == null || string.IsNullOrWhiteSpace(config.InnerText))
			{
				return;
			}

			priority = (ProcessPriorityClass)Enum.Parse(typeof(ProcessPriorityClass), config.InnerText, ignoreCase: true);
		}

		private static void ConfigResultsMode(XmlNode config)
		{
			if (config == null || string.IsNullOrWhiteSpace(config.InnerText))
			{
				return;
			}

			resultsMode = (FileMode)Enum.Parse(typeof(FileMode), config.InnerText, ignoreCase: true);
		}

		private static void ConfigResults(XmlNode config)
		{
			if (config == null || string.IsNullOrWhiteSpace(config.InnerText))
			{
				return;
			}

			resultsPath = config.InnerText;
		}
		#endregion //Config

		private static void PrintHelp(List<string> errors)
		{
			Console.WriteLine("LDSGospelSearch.Console.exe");
			Console.WriteLine(" Required");
			Console.WriteLine("  -Search { Sentence, Verse, Chapter }");
			Console.WriteLine("  -Query Query.config");
			Console.WriteLine(" Optional");
			Console.WriteLine("  -Source Folder");
			Console.WriteLine("  -Language eng");//iso639_3
			Console.WriteLine("  -BooksAdd Book,Book,Book { " + string.Join(", ", Library.Books) + " }");
			Console.WriteLine("  -BooksClear");
			Console.WriteLine("  -BooksRemove Book,Book,Book { " + string.Join(", ", Library.Books) + " }");
			Console.WriteLine("  -MapAdd Original Replace");
			Console.WriteLine("  -MapClear");
			Console.WriteLine("  -MapRemove Original");
			Console.WriteLine("  -RenamesAdd Original Replace");
			Console.WriteLine("  -RenamesClear");
			Console.WriteLine("  -RenamesRemove Original");
			Console.WriteLine("  -CapitalizesAdd text");
			Console.WriteLine("  -CapitalizesClear");
			Console.WriteLine("  -CapitalizesRemove text");
			Console.WriteLine("  -Separate { true, false }");
			Console.WriteLine("  -Threads -1");
			Console.WriteLine("  -Priority { Idle, Normal, High, RealTime, BelowNormal, AboveNormal }");
			Console.WriteLine("  -ResultsMode { Create, Append, CreateNew }");
			Console.WriteLine("  -Results Results.txt");
			Console.WriteLine("  -Config Config.config");
			Console.WriteLine();

			if (errors != null && errors.Count > 0)
			{
				foreach (var error in errors)
				{
					Console.WriteLine(error);
				}
				Console.WriteLine();
			}
		}

		private static void Prepare()
		{
			PrepareSourcePath();
			PrepareLanguage();
			PrepareBooks();

			try
			{
				Process.GetCurrentProcess().PriorityClass = priority;
			}
			catch
			{
				//Nothing on purpose
			}

			GC.Collect();
		}

		private static void PrepareSourcePath()
		{
			if (sourcePath != null)
			{
				return;
			}

			sourcePath = Library.GetSourcePath();
			sourceSpecific = false;
		}
		
		private static void PrepareLanguage()
		{
			if (language != null)
			{
				return;
			}

			language = "eng";
		}

		private static void PrepareBooks()
		{
			if (books.Count > 0)
			{
				return;
			}

			foreach (var book in Library.Books)
			{
				books.Add(book);
			}
		}

		private static void Results()
		{
			FileStream writerStream = null;
			StreamWriter writer = null;
			try
			{
				if (resultsPath != null)
				{
					writerStream = new FileStream(resultsPath, resultsMode, FileAccess.Write, FileShare.Read);
					writer = new StreamWriter(writerStream);
				}

				if (!TryPersisted(out var connectionString))
				{
					if (sourceSpecific)
					{
						Console.Error.WriteLine("Missing file persisted-catalog.sqlite");
					}
					else
					{
						Console.Error.WriteLine("Please install Gospel Library https://www.microsoft.com/en-us/p/gospel-library/9wzdncrfj2k4");
					}
					return;
				}
				if (!TryLanguage(connectionString))
				{
					Console.Error.WriteLine("Language {0} not found", language);
					return;
				}
				if (!TryCatalog(connectionString))
				{
					Console.Error.WriteLine("Missing entry catalog");
					return;
				}
				if (!TryCatalogs())
				{
					Console.Error.WriteLine("No package.sqlite found");
					return;
				}

				states.Matchs = new List<SearchMatch>();
				var navigations = Library.GetNavigationsPaths(catalogs);
				Parallel.ForEach(navigations, options, states.Init, search, states.Finally);
				states.MatchsSort(SearchMatch.OffsetAscendingCompare);

				if (writer != null)
				{
					Write(writer);
				}
				Write(Console.Out);
			}
			finally
			{
				writer?.Dispose();
				writerStream?.Dispose();
			}
		}

		private static bool TryPersisted(out string connectionString)
		{
			var path = Path.Combine(sourcePath, @"persisted-catalog.sqlite");
			if (!File.Exists(path))
			{
				connectionString = null;
				return false;
			}
			connectionString = Library.CreateConnectionString(path);
			return true;
		}

		private static bool TryLanguage(string connectionString)
		{
			using (var connection = new SQLiteConnection(connectionString))
			{
				connection.Open();
				var sql = string.Format("SELECT id FROM persisted_language WHERE iso639_3 = '{0}'", language);
				using (var command = new SQLiteCommand(sql, connection))
				using (var reader = command.ExecuteReader())
				{
					var idOffset = reader.GetOrdinal("id");

					while (reader.Read())
					{
						languageId = reader.GetInt32(idOffset);
						return true;
					}
				}
			}
			return false;
		}

		private static bool TryCatalog(string connectionString)
		{
			int version;
			using (var connection = new SQLiteConnection(connectionString))
			{
				connection.Open();
				var sql = string.Format("SELECT version FROM persisted_catalog WHERE language_id = {0}", languageId);
				using (var command = new SQLiteCommand(sql, connection))
				using (var reader = command.ExecuteReader())
				{
					var versionOffset = reader.GetOrdinal("version");

					if (!reader.Read())
					{
						Console.Error.WriteLine("Missing catalog for {0}", language);
						return false;
					}
					version = reader.GetInt32(versionOffset);
				}
			}
			var trying = version;
			while (true)
			{
				catalogPath = Library.GetCatalogPath(sourcePath, language, trying);
				if (File.Exists(catalogPath))
				{
					if (trying != version)
					{
						Console.WriteLine("Using older version {0} for catalog becasue newest versrion {1} was not found",
							trying, version);
					}
					return true;
				}
				--trying;
				if (trying < 0)
				{
					Console.Error.WriteLine("Missing any version for catalog");
					return false;
				}
			}
		}

		private static bool TryCatalogs()
		{
			catalogs = new List<string>(books.Count);
			var connectionString = Library.CreateConnectionString(catalogPath);
			using (var connection = new SQLiteConnection(connectionString))
			{
				connection.Open();
				foreach (var book in books)
				{
					if (!Library.TryGetURI(book, out var uri))
					{
						continue;
					}
					string id;
					int version;
					var sql = string.Format("SELECT id, version FROM item WHERE language_id = {0} AND uri = '{1}'", languageId, uri);
					using (var command = new SQLiteCommand(sql, connection))
					using (var reader = command.ExecuteReader())
					{
						var idOffset = reader.GetOrdinal("id");
						var versionOffset = reader.GetOrdinal("version");

						if (!reader.Read())
						{
							Console.Error.WriteLine("Missing entry for {0}", book);
							continue;
						}
						id = reader.GetString(idOffset);
						version = reader.GetInt32(versionOffset);
					}
					var trying = version;
					while (true)
					{
						var path = Library.GetPackagePath(sourcePath, id, trying);
						if (File.Exists(path))
						{
							if (trying != version)
							{
								Console.WriteLine("Using older version {0} for {1} becasue newest versrion {2} was not found",
									trying, book, version);
							}
							catalogs.Add(path);
							break;
						}
						--trying;
						if (trying < 0)
						{
							Console.Error.WriteLine("Missing any version for {0} package.sqlite", book);
							break;
						}
					}
				}
			}
			return catalogs.Count > 0;
		}

		private static void Write(TextWriter writer)
		{
			if (separate)
			{
				states.MatchsWriteSeparate(writer);
			}
			else
			{
				states.MatchWrite(writer);
			}
		}
		#endregion //Methods
	}
}

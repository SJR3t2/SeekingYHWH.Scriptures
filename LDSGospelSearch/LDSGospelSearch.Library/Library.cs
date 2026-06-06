using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Net;
using System.Text;

using SeekingYHWH.Scriptures.LDSGospelLibrary;

namespace LDSGospelSearch
{
	public static class Library
	{
		#region Constants
		public const string PersistedCatalog = "persisted-catalog.sqlite";

		public const string ConnectionStringFormat = "Data Source={0}; Read Only=True;";

		public const string BookOT = "OT";
		public const string BookNT = "NT";
		public const string BookBoM = "BoM";
		public const string BookDnC = "DnC";
		public const string BookPGP = "PGP";
		public const string BookJST = "JST";

		public const string URIOT = "/scriptures/ot";
		public const string URINT = "/scriptures/nt";
		public const string URIBoM = "/scriptures/bofm";
		public const string URIDnC = "/scriptures/dc-testament";
		public const string URIPGP = "/scriptures/pgp";
		public const string URIJST = "/scriptures/jst";
		#endregion //Constants

		#region Fields
		private static readonly Dictionary<string, string> books = new Dictionary<string, string>()
		{
			{ BookOT, URIOT },
			{ BookNT, URINT },
			{ BookBoM, URIBoM },
			{ BookDnC, URIDnC },
			{ BookPGP, URIPGP },
			{ BookJST, URIJST },
		};
		private static readonly Dictionary<string, string> uris = new Dictionary<string, string>()
		{
			{ URIOT, BookOT },
			{ URINT , BookNT },
			{ URIBoM , BookBoM },
			{ URIDnC , BookDnC },
			{ URIPGP , BookPGP },
			{ URIJST , BookJST },
		};
		#endregion //Fields

		#region Properties
		public static IEnumerable<string> Books => books.Keys;
		#endregion //Properties

		#region Methods
		public static string GetSourcePath()
		{
			var path = Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
				"Packages",
				"TheChurchofJesusChristofL.GospelLibrary_ae8bh92e13w8t",
				"LocalState",
				"Platform-V4",
				"Library");
			return path;
		}

		public static string GetPersistedPath(string path)
		{
			return Path.Combine(path, PersistedCatalog);
		}

		public static string GetCatalogPath(string sourcePath, string languageCode, int version)
		{
			var path = Path.Combine(
				sourcePath,
				"catalog",
				languageCode,
				version.ToString(),
				"catalog.sqlite");
			return path;
		}

		public static string GetCatalogPath(string sourcePath, string languageCode, string version)
		{
			var path = Path.Combine(
				sourcePath,
				"catalog",
				languageCode,
				version,
				"catalog.sqlite");
			return path;
		}

		public static string GetPackagePath(string sourcePath, string id, int version)
		{
			var path = Path.Combine(
				sourcePath,
				id,
				version.ToString(),
				"package.sqlite");
			return path;
		}

		public static string GetPackagePath(string sourcePath, string id, string version)
		{
			var path = Path.Combine(
				sourcePath,
				id,
				version,
				"package.sqlite");
			return path;
		}

		public static bool ContainsBook(string book)
		{
			return books.ContainsKey(book);
		}

		public static bool TryGetURI(string book, out string uri)
		{
			return books.TryGetValue(book, out uri);
		}

		public static string CreateConnectionString(string path)
		{
			return string.Format(ConnectionStringFormat, path);
		}

		public static void GetCatalogs(string connectionString, Action<CatalogInfo> action)
		{
			using (var connection = new SQLiteConnection(connectionString))
			{
				connection.Open();

				var sql = "SELECT language_id, language_iso639, version FROM persisted_catalog";
				using (var command = new SQLiteCommand(sql, connection))
				using (var reader = command.ExecuteReader())
				{
					var languageIdOffset = reader.GetOrdinal("language_id");
					var languageCodeOffset = reader.GetOrdinal("language_iso639");
					var versionOffset = reader.GetOrdinal("version");

					while (reader.Read())
					{
						var languageId = reader.GetInt32(languageIdOffset);
						var languageCode = reader.GetString(languageCodeOffset);
						var version = reader.GetInt32(versionOffset);
						var value = new CatalogInfo(languageId, languageCode, version);
						action(value);
					}
				}
			}
		}

		public static void GetCatalogs(string connectionString, Action<int, string, int> action)
		{
			using (var connection = new SQLiteConnection(connectionString))
			{
				connection.Open();

				var sql = "SELECT language_id, language_iso639, version FROM persisted_catalog";
				using (var command = new SQLiteCommand(sql, connection))
				using (var reader = command.ExecuteReader())
				{
					var languageIdOffset = reader.GetOrdinal("language_id");
					var codeOffset = reader.GetOrdinal("language_iso639");
					var versionOffset = reader.GetOrdinal("version");

					while (reader.Read())
					{
						var languageId = reader.GetInt32(languageIdOffset);
						var code = reader.GetString(codeOffset);
						var version = reader.GetInt32(versionOffset);
						action(languageId, code, version);
					}
				}
			}
		}

		public static void GetPackages(string connectionString, int languageId, Action<string, string, int> action)
		{
			using (var connection = new SQLiteConnection(connectionString))
			{
				connection.Open();

				var sql = string.Format("SELECT id, uri, version FROM item WHERE uri LIKE '/scriptures/%' AND language_id = {0}", languageId);
				using (var command = new SQLiteCommand(sql, connection))
				using (var reader = command.ExecuteReader())
				{
					var idOffset = reader.GetOrdinal("id");
					var uriOffset = reader.GetOrdinal("uri");
					var versionOffset = reader.GetOrdinal("version");

					while (reader.Read())
					{
						var uri = reader.GetString(uriOffset);
						if (!uris.ContainsKey(uri))
						{
							continue;
						}
						var id = reader.GetString(idOffset);
						var version = reader.GetInt32(versionOffset);
						action(id, uri, version);
					}
				}
			}
		}

		public static void GetLanguages(string connectionString, Action<LanguageInfo> action)
		{
			using (var connection = new SQLiteConnection(connectionString))
			{
				connection.Open();

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
						var value = new LanguageInfo(id, native, code, other);
						action(value);
					}
				}
			}
		}

		public static void GetLanguages(string connectionString, Action<int, string, string, string> action)
		{
			using (var connection = new SQLiteConnection(connectionString))
			{
				connection.Open();

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
						action(id, native, code, other);
					}
				}
			}
		}

		public static IEnumerable<NavigationInfo> GetNavigationsPaths(IEnumerable<string> paths)
		{
			foreach (var path in paths)
			{
				var connectionString = CreateConnectionString(path);
				using (var connection = new SQLiteConnection(connectionString))
				{
					connection.Open();

					var sql = "SELECT uri, title, content_html FROM nav_item INNER JOIN subitem_content ON nav_item.subitem_id = subitem_content.subitem_id ORDER BY position ASC";
					using (var command = new SQLiteCommand(sql, connection))
					using (var reader = command.ExecuteReader())
					{
						var uriOrdinal = reader.GetOrdinal("uri");
						var titleOrdinal = reader.GetOrdinal("title");
						var htmlOrdinal = reader.GetOrdinal("content_html");

						while (reader.Read())
						{
							var uri = reader.GetString(uriOrdinal);
							if (!Scriptures.IsScripture(uri))
							{
								continue;
							}
							var title = WebUtility.HtmlDecode(reader.GetString(titleOrdinal));
							var html = WebUtility.HtmlDecode(reader.GetString(htmlOrdinal));
							var value = new NavigationInfo(title, html);
							yield return value;
						}
					}
				}
			}
		}

		public static IEnumerable<NavigationInfo> GetNavigationsConnects(IEnumerable<string> connects)
		{
			foreach (var connect in connects)
			{
				using (var connection = new SQLiteConnection(connect))
				{
					connection.Open();
					var sql = "SELECT uri, title, content_html FROM nav_item INNER JOIN subitem_content ON nav_item.subitem_id = subitem_content.subitem_id ORDER BY position ASC";
					using (var command = new SQLiteCommand(sql, connection))
					using (var reader = command.ExecuteReader())
					{
						var uriOrdinal = reader.GetOrdinal("uri");
						var titleOrdinal = reader.GetOrdinal("title");
						var htmlOrdinal = reader.GetOrdinal("content_html");

						while (reader.Read())
						{
							var uri = reader.GetString(uriOrdinal);
							if (!Scriptures.IsScripture(uri))
							{
								continue;
							}
							var title = WebUtility.HtmlDecode(reader.GetString(titleOrdinal));
							var html = WebUtility.HtmlDecode(reader.GetString(htmlOrdinal));
							var value = new NavigationInfo(title, html);
							yield return value;
						}
					}
				}
			}
		}
		#endregion //Methods
	}
}

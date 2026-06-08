using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Microsoft.Win32;

using SeekingYHWH.Scriptures.LDSGospelLibrary;
using SeekingYHWH.Scriptures;

namespace LDSGospelSearch
{
	public partial class MainWindow : Window
	{
		private string sourcePath;
		private readonly Dictionary<string, Dictionary<string, string>> catalogs = new Dictionary<string, Dictionary<string, string>>();
		private Dictionary<string, string> packages = new Dictionary<string, string>();
		private readonly Dictionary<string, string> uris = new Dictionary<string, string>();
		private readonly SearchStates states = new SearchStates(Extractor.CreateMap(), new List<SearchMatch>());
		private readonly Func<SearchState> statesInit;
		private readonly Action<SearchState> statesFinally;
		private readonly ParallelOptions searchOptions = new ParallelOptions();
		private Func<NavigationInfo, ParallelLoopState, long, SearchState, SearchState> searchMethod;
		private readonly Comparison<SearchMatch> searchComparion = SearchMatch.OffsetAscendingCompare;
		private readonly StringBuilder scripturesBulider;
		private readonly StringWriter scripturesWriter;

		public MainWindow()
		{
			InitializeComponent();

			this.statesInit = states.Init;
			this.statesFinally = states.Finally;

			this.scripturesBulider = new StringBuilder();
			this.scripturesWriter = new StringWriter(this.scripturesBulider);

			this.verse.IsChecked = true;
		}

		private void OnLoaded(object sender, RoutedEventArgs args)
		{
			sourcePath = Library.GetSourcePath();
			var persistedPath = Library.GetPersistedPath(sourcePath);
			if (!File.Exists(persistedPath))
			{
				MessageBox.Show(
					"You need download Gospel Library app first. Please goto the Help menu then Get required Gospel Library.",
					"Download Gospel Library", MessageBoxButton.OK, MessageBoxImage.Error);
				Disable();
				return;
			}
			var persistedConnect = Library.CreateConnectionString(persistedPath);
			Library.GetCatalogs(persistedConnect, AddCatalog);
			if (catalogs.Count <= 0)
			{
				Disable();
				return;
			}
			languages.ItemsSource = catalogs.Keys;
			var languageApp = System.Threading.Thread.CurrentThread.CurrentUICulture.ThreeLetterISOLanguageName;
			if (catalogs.ContainsKey(languageApp))
			{
				languages.SelectedItem = languageApp;
			}
		}

		private void Disable()
		{
			queryText.IsEnabled = false;
			searchButton.IsEnabled = false;
			languages.IsEnabled = false;
		}

		private void AddCatalog(int languageId, string languageCode, int catalogVersion)
		{
			string catalogPath;
			while (true)
			{
				catalogPath = Library.GetCatalogPath(sourcePath, languageCode, catalogVersion);
				if (File.Exists(catalogPath))
				{
					break;
				}
				--catalogVersion;
				if (catalogVersion <= 0)
				{
					return;
				}
			}
			var catalogConnectionString = Library.CreateConnectionString(catalogPath);
			Library.GetPackages(catalogConnectionString, languageId, AddPackage);
			if (packages != null)
			{
				catalogs.Add(languageCode, packages);
				packages = null;
			}
		}

		private void AddPackage(string id, string uri, int version)
		{
			while (true)
			{
				var packagePath = Library.GetPackagePath(sourcePath, id, version);
				if (File.Exists(packagePath))
				{
					var packageConnect = Library.CreateConnectionString(packagePath);
					if (packages == null)
					{
						packages = new Dictionary<string, string>();
					}
					packages.Add(uri, packageConnect);
					return;
				}
				--version;
				if (version < 0)
				{
					return;
				}
			}
		}

		private void OnLanguageChanged(object sender, SelectionChangedEventArgs args)
		{
			var language = languages.SelectedItem as string;
			if (language == null)
			{
				return;
			}
			if (!catalogs.TryGetValue(language, out packages))
			{
				return;
			}
			string package;
			if (packages.TryGetValue(Library.URIOT, out package))
			{
				ot.IsEnabled = true;
				uris[Library.URIOT] = package;
				ot.IsChecked = true;
			}
			else
			{
				ot.IsChecked = false;
				ot.IsEnabled = false;
			}
			if (packages.TryGetValue(Library.URINT, out package))
			{
				nt.IsEnabled = true;
				uris[Library.URINT] = package;
				nt.IsChecked = true;
			}
			else
			{
				nt.IsChecked = false;
				nt.IsEnabled = false;
			}
			if (packages.TryGetValue(Library.URIBoM, out package))
			{
				bom.IsEnabled = true;
				uris[Library.URIBoM] = package;
				bom.IsChecked = true;
			}
			else
			{
				bom.IsChecked = false;
				bom.IsEnabled = false;
			}
			if (packages.TryGetValue(Library.URIDnC, out package))
			{
				dnc.IsEnabled = true;
				uris[Library.URIDnC] = package;
				dnc.IsChecked = true;
			}
			else
			{
				dnc.IsChecked = false;
				dnc.IsEnabled = false;
			}
			if (packages.TryGetValue(Library.URIPGP, out package))
			{
				pgp.IsEnabled = true;
				uris[Library.URIPGP] = package;
				pgp.IsChecked = true;
			}
			else
			{
				pgp.IsChecked = false;
				pgp.IsEnabled = false;
			}
			if (packages.TryGetValue(Library.URIJST, out package))
			{
				jst.IsEnabled = true;
				uris[Library.URIJST] = package;
				jst.IsChecked = true;
			}
			else
			{
				jst.IsChecked = false;
				jst.IsEnabled = false;
			}
		}

		private void OnSearch(object sender, RoutedEventArgs args)
		{
			scripturesText.Clear();
			if (!QueryParserLISP.TryParse(queryText.Text, out var provider, out var errors))
			{
				var message = string.Join(Environment.NewLine, errors);
				MessageBox.Show(
					message,
					"Search Query Error", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			states.Provider = provider;
			var navigations = Library.GetNavigationsConnects(uris.Values);
			states.MatchsClear();
			Parallel.ForEach(navigations, searchOptions, statesInit, searchMethod, statesFinally);
			var count = 0;
			foreach (var match in states.Matchs)
			{
				count += match.Values.Count;
			}
			scripturesCount.Text = "Scriptures: " + count.ToString();
			states.MatchsSort(searchComparion);
			scripturesBulider.Clear();
			states.MatchsWriteSeparate(scripturesWriter);
			scripturesText.Text = scripturesBulider.ToString();
			scripturesBulider.Clear();
		}

		private void OnOTChecked(object sender, RoutedEventArgs args)
		{
			if (packages.TryGetValue(Library.URIOT, out var package))
			{
				uris[Library.URIOT] = package;
			}
			SetRunEnabled();
		}

		private void OnOTUnchecked(object sender, RoutedEventArgs args)
		{
			uris.Remove(Library.URIOT);
			SetRunEnabled();
		}

		private void OnNTChecked(object sender, RoutedEventArgs args)
		{
			if (packages.TryGetValue(Library.URINT, out var package))
			{
				uris[Library.URINT] = package;
			}
			SetRunEnabled();
		}

		private void OnNTUnchecked(object sender, RoutedEventArgs args)
		{
			uris.Remove(Library.URINT);
			SetRunEnabled();
		}

		private void OnBoMChecked(object sender, RoutedEventArgs args)
		{
			if (packages.TryGetValue(Library.URIBoM, out var package))
			{
				uris[Library.URIBoM] = package;
			}
			SetRunEnabled();
		}

		private void OnBoMUnchecked(object sender, RoutedEventArgs args)
		{
			uris.Remove(Library.URIBoM);
			SetRunEnabled();
		}

		private void OnDnCChecked(object sender, RoutedEventArgs args)
		{
			if (packages.TryGetValue(Library.URIDnC, out var package))
			{
				uris[Library.URIDnC] = package;
			}
			SetRunEnabled();
		}

		private void OnDnCUnchecked(object sender, RoutedEventArgs args)
		{
			uris.Remove(Library.URIDnC);
			SetRunEnabled();
		}

		private void OnPGPChecked(object sender, RoutedEventArgs args)
		{
			if (packages.TryGetValue(Library.URIPGP, out var package))
			{
				uris[Library.URIPGP] = package;
			}
			SetRunEnabled();
		}

		private void OnPGPUnchecked(object sender, RoutedEventArgs args)
		{
			uris.Remove(Library.URIPGP);
			SetRunEnabled();
		}

		private void OnJSTChecked(object sender, RoutedEventArgs args)
		{
			if (packages.TryGetValue(Library.URIJST, out var package))
			{
				uris[Library.URIJST] = package;
			}
			SetRunEnabled();
		}

		private void OnJSTUnchecked(object sender, RoutedEventArgs args)
		{
			uris.Remove(Library.URIJST);
			SetRunEnabled();
		}

		private void SetRunEnabled()
		{
			searchButton.IsEnabled = uris.Count > 0;
		}

		private void OnSentenceChecked(object sender, RoutedEventArgs args)
		{
			searchMethod = Search.Sentence;
		}

		private void OnVerseChecked(object sender, RoutedEventArgs args)
		{
			searchMethod = Search.Verse;
		}

		private void OnChapterChecked(object sender, RoutedEventArgs args)
		{
			searchMethod = Search.Chapter;
		}

		private void OnQueryLoad(object sender, RoutedEventArgs args)
		{
			var dialog = new OpenFileDialog()
			{
				Title = "Query Load",
				Filter = "Text (*.txt)|*.txt",
				DefaultExt = ".txt",
				AddExtension = true,
				CheckFileExists = true,
			};
			if (dialog.ShowDialog() ?? false)
			{
				using (var readerStream = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
				using (var reader = new StreamReader(readerStream))
				{
					queryText.Text = reader.ReadToEnd();
				}
			}
		}

		private void OnQuerySave(object sender, RoutedEventArgs args)
		{
			var dialog = new SaveFileDialog()
			{
				Title = "Query Save",
				Filter = "Text (*.txt)|*.txt",
				DefaultExt = ".txt",
				AddExtension = true,
			};
			if (dialog.ShowDialog() ?? false)
			{
				using (var writerStream = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write, FileShare.Read))
				using (var writer = new StreamWriter(writerStream))
				{
					writer.Write(queryText.Text);
				}
			}
		}

		private void OnScripturesSave(object sender, RoutedEventArgs args)
		{
			var dialog = new SaveFileDialog()
			{
				Title = "Scriptures Save",
				Filter = "Text (*.txt)|*.txt",
				DefaultExt = ".txt",
				AddExtension = true,
			};
			if (dialog.ShowDialog() ?? false)
			{
				using (var writerStream = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write, FileShare.Read))
				using (var writer = new StreamWriter(writerStream))
				{
					states.MatchsWriteSeparate(writer);
				}
			}
		}

		private void OnExit(object sender, RoutedEventArgs args)
		{
			this.Close();
		}

		private void OnQueryClear(object sender, RoutedEventArgs args)
		{
			queryText.Clear();
		}

		private void OnQueryCopy(object sender, RoutedEventArgs args)
		{
			Clipboard.SetText(queryText.Text);
		}

		private void OnQueryPaste(object sender, RoutedEventArgs args)
		{
			queryText.Text = Clipboard.GetText();
		}

		private void OnScripturesClear(object sender, RoutedEventArgs args)
		{
			states.MatchsClear();
			scripturesText.Clear();
			scripturesCount.Text = "Scriptures: 0";
		}

		private void OnScripturesCopy(object sender, RoutedEventArgs args)
		{
			Clipboard.SetText(scripturesText.Text);
		}

		private void OnGetGospelLibrary(object sender, RoutedEventArgs args)
		{
			Process.Start("https://apps.microsoft.com/store/detail/gospel-library/9WZDNCRFJ2K4");
		}

		private void OnWhatsExcluded(object sender, RoutedEventArgs args)
		{
			var message =
				"Esther\n" +
				"Songs of Solomon\n" +
				"D&C 77\n" +
				"D&C 102\n" +
				"D&C 108\n" +
				"D&C 109\n" +
				"D&C 110\n" +
				"D&C 111\n" +
				"D&C 113\n" +
				"D&C 114\n" +
				"D&C 115\n" +
				"D&C 118\n" +
				"D&C 123\n" +
				"D&C 124\n" +
				"D&C 126\n" +
				"D&C 127\n" +
				"D&C 128\n" +
				"D&C 129\n" +
				"D&C 130\n" +
				"D&C 131\n" +
				"D&C 132\n" +
				"D&C 135\n" +
				"D&C 136\n" +
				"D&C 137\n" +
				"D&C 138\n" +
				"OD 1\n" +
				"OD 2\n";
			MessageBox.Show(
				message,
				"What's Excluded", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private void OnHelpQuery(object sender, RoutedEventArgs args)
		{
			var message =
				"Logic:\n" +
				"And(Query(...),Query(...),Query(...)...)\n" +
				"Or(Query(...),Query(...),Query(...)...)\n" +
				"Xor(Query(...),Query(...))\n" +
				"Not(Query(...))\n" +
				"NAnd(Query(...),Query(...),Query(...)...)\n" +
				"NOr(Query(...),Query(...),Query(...)...)\n" +
				"NXor(Query(...),Query(...))\n" +
				"Equals(Query(...),Query(...),Query(...)...)\n" +
				"Same(Query(...),Query(...),Query(...)...)\n" +
				"Diff(Query(...),Query(...),Query(...)...)\n" +
				"Trues(Query(...),Query(...),Query(...)...)\n" +
				"Falses(Query(...),Query(...),Query(...)...)\n" +
				"NEquals(Query(...),Query(...),Query(...)...)\n" +
				"NSame(Query(...),Query(...),Query(...)...)\n" +
				"NDiff(Query(...),Query(...),Query(...)...)\n" +
				"NTrues(Query(...),Query(...),Query(...)...)\n" +
				"NFalses(Query(...),Query(...),Query(...)...)\n" +
				"\n" +
				"Count:\n" +
				"CountTruesLT(number,Query(...),Query(...),Query(...)...)\n" +
				"CountTruesLE(number,Query(...),Query(...),Query(...)...)\n" +
				"CountTruesEQ(number,Query(...),Query(...),Query(...)...)\n" +
				"CountTruesNE(number,Query(...),Query(...),Query(...)...)\n" +
				"CountTruesGE(number,Query(...),Query(...),Query(...)...)\n" +
				"CountTruesGT(number,Query(...),Query(...),Query(...)...)\n" +
				"CountFalsesLT(number,Query(...),Query(...),Query(...)...)\n" +
				"CountFalsesLE(number,Query(...),Query(...),Query(...)...)\n" +
				"CountFalsesEQ(number,Query(...),Query(...),Query(...)...)\n" +
				"CountFalsesNE(number,Query(...),Query(...),Query(...)...)\n" +
				"CountFalsesGE(number,Query(...),Query(...),Query(...)...)\n" +
				"CountFalsesGT(number,Query(...),Query(...),Query(...)...)\n" +
				"CountRegexsLT(number,pattern) or CountRegexsLT(number,pattern,{ IgnoreCase, None})\n" +
				"CountRegexsLE(number,pattern) or CountRegexsLE(number,pattern,{ IgnoreCase, None})\n" +
				"CountRegexsEQ(number,pattern) or CountRegexsEQ(number,pattern,{ IgnoreCase, None})\n" +
				"CountRegexsNE(number,pattern) or CountRegexsNE(number,pattern,{ IgnoreCase, None})\n" +
				"CountRegexsGE(number,pattern) or CountRegexsGE(number,pattern,{ IgnoreCase, None})\n" +
				"CountRegexsGT(number,pattern) or CountRegexsGT(number,pattern,{ IgnoreCase, None})\n" +
				"CountIndexLT(text) or CountIndexLT(text,{ CurrentCultureIgnoreCase, CurrentCulture, InvariantCultureIgnoreCase, InvariantCulture, OrdinalIgnoreCase, Ordinal })\n" +
				"CountIndexLE(text) or CountIndexLE(text,{ CurrentCultureIgnoreCase, CurrentCulture, InvariantCultureIgnoreCase, InvariantCulture, OrdinalIgnoreCase, Ordinal })\n" +
				"CountIndexEQ(text) or CountIndexEQ(text,{ CurrentCultureIgnoreCase, CurrentCulture, InvariantCultureIgnoreCase, InvariantCulture, OrdinalIgnoreCase, Ordinal })\n" +
				"CountIndexNE(text) or CountIndexNE(text,{ CurrentCultureIgnoreCase, CurrentCulture, InvariantCultureIgnoreCase, InvariantCulture, OrdinalIgnoreCase, Ordinal })\n" +
				"CountIndexGE(text) or CountIndexGE(text,{ CurrentCultureIgnoreCase, CurrentCulture, InvariantCultureIgnoreCase, InvariantCulture, OrdinalIgnoreCase, Ordinal })\n" +
				"CountIndexGT(text) or CountIndexGT(text,{ CurrentCultureIgnoreCase, CurrentCulture, InvariantCultureIgnoreCase, InvariantCulture, OrdinalIgnoreCase, Ordinal })\n" +
				"\n" +
				"Search:\n" +
				"Regex(pattern) or Regex(pattern,{ IgnoreCase, None})\n" +
				"Index(text) or Index(text,{ CurrentCultureIgnoreCase, CurrentCulture, InvariantCultureIgnoreCase, InvariantCulture, OrdinalIgnoreCase, Ordinal })\n" +
				"Contains(text)\n" +
				"NRegex(pattern) or Regex(pattern,{ IgnoreCase, None})\n" +
				"NIndex(text) or Index(text,{ CurrentCultureIgnoreCase, CurrentCulture, InvariantCultureIgnoreCase, InvariantCulture, OrdinalIgnoreCase, Ordinal })\n" +
				"NContains(text)\n" +
				"\n" +
				"Constants:\n" +
				"True()\n" +
				"False()";
			MessageBox.Show(
				message,
				"Help Query", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private void OnHelpRegexMSDoc(object sender, RoutedEventArgs args)
		{
			Process.Start("https://learn.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=netframework-4.8");
		}

		private void OnHelpRegexMSLearn(object sender, RoutedEventArgs args)
		{
			Process.Start("https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expressions");
		}

		private void OnHelpRegexMSCheat(object sender, RoutedEventArgs args)
		{
			Process.Start("https://learn.microsoft.com/en-us/previous-versions/troubleshoot/winautomation/process-development-tips/text-manipulation/regular-expressions-cheat-sheet");
		}

		private void OnHelpRegexMikesCheat(object sender, RoutedEventArgs args)
		{
			Process.Start("https://www.mikesdotnetting.com/article/46/c-regular-expressions-cheat-sheet");
		}

		private void OnHelpRegexMediumCheat(object sender, RoutedEventArgs args)
		{
			Process.Start("https://medium.com/factory-mind/regex-tutorial-a-simple-cheatsheet-by-examples-649dc1c3f285");
		}

		private void OnHelpRegexCornerRegex(object sender, RoutedEventArgs args)
		{
			Process.Start("https://www.c-sharpcorner.com/article/regular-expressions-in-net/");
		}

		private void OnHelpRegexCornerExamples(object sender, RoutedEventArgs args)
		{
			Process.Start("https://www.c-sharpcorner.com/article/c-sharp-regex-examples/");
		}

		private void OnHelpRegexStormTester(object sender, RoutedEventArgs args)
		{
			Process.Start("http://regexstorm.net/tester");
		}

		private void OnExampleGodhead(object sender, RoutedEventArgs args)
		{
			queryText.Text =
				@"And(" +
				@"Or(Regex(\bGod,None),Regex(\bFather))," +
				@"Or(Regex(\bLord,None),Regex(\bSon,None),Regex(\bJesus,None),Regex(\bChrist),Regex(\bMessiah,None))," +
				@"Or(Regex(\bspirit),Regex(\bghost)))";
		}

		private void OnExampleAllThings(object sender, RoutedEventArgs args)
		{
			queryText.Text = "Index(\"all things\")";
		}

		private void OnBlog(object sender, RoutedEventArgs args)
		{
			Process.Start("https://seekingyhwh.org/posts/");
		}

		private void OnSoftware(object sender, RoutedEventArgs args)
		{
			Process.Start("https://seekingyhwh.org/resources/software/");
		}

		private void OnDownload(object sender, RoutedEventArgs args)
		{
			Process.Start("https://seekingyhwh.org/resources/software/ldsgospelsearch/");
		}
	}
}

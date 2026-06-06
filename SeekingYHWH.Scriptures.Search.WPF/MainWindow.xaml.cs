using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SeekingYHWH.Scriptures;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	private List<string>? verses;

	public MainWindow()
	{
		InitializeComponent();
	}

	private void OnLoaded(object sender, RoutedEventArgs args)
	{
		if (Languages.Locals.Count <= 0)
		{
			OnDownload(null, null);
		}
		if (Languages.Locals.Count > 0 && !Options.IsSelected())
		{
			OnOptions(null, null);
		}
	}

	private void OnDownload(object sender, RoutedEventArgs args)
	{
		var dialog = new DownloadWindow();
		dialog.ShowDialog();
	}

	private void OnOptions(object sender, RoutedEventArgs args)
	{
		var dialog = new OptionsWindow();
		dialog.ShowDialog();
    }

	private void OnScripturesCopyAll(object sender, RoutedEventArgs args)
	{
		if (verses is null || verses.Count <= 0)
		{
			return;
		}

		try
		{
			var text = string.Join(Environment.NewLine, verses);
			Clipboard.SetText(text);
		}
		catch
		{
			MessageBox.Show("Can't Copy All", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
		}
	}

	private void OnScripturesCopySelected(object sender, RoutedEventArgs args)
	{
		var selceted = found.SelectedItems;
		if (selceted is null || selceted.Count <= 0)
		{
			return;
		}

		IEnumerator? enumerator = null;
		try
		{
			var builder = new StringBuilder();
			string text;
			enumerator = selceted.GetEnumerator();
			if (enumerator.MoveNext())
			{
				while (true)
				{
					builder.Append(enumerator.Current.ToString());
					if (!enumerator.MoveNext())
					{
						break;
					}
					builder.AppendLine();
				}
			}
			text = builder.ToString();
			Clipboard.SetText(text);
		}
		catch
		{
			MessageBox.Show("Can't Copy Selected", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
		}
		finally
		{
			if (enumerator != null)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
	}

	private void OnQueryPaste(object sender, RoutedEventArgs args)
	{
		queryText.Text = Clipboard.GetText();
	}

	private void OnQueryCopy(object sender, RoutedEventArgs args)
	{
		Clipboard.SetText(queryText.Text);
	}

	private void OnQueryClear(object sender, RoutedEventArgs args)
	{
		queryText.Text = string.Empty;
	}

	private void OnScripturesClearSelected(object sender, RoutedEventArgs args)
	{
		found.SelectedItems.Clear();
	}

	private void OnSearch(object sender, RoutedEventArgs args)
	{
		found.SelectedItems.Clear();
		found.ItemsSource = null;
		scripturesCount.Text = "Scriptures: 0";

		if (Languages.Locals.Count <= 0)
		{
			OnDownload(null, null);
		}
		if (Languages.Locals.Count > 0 && !Options.IsSelected())
		{
			OnOptions(null, null);
		}
		if (!Options.IsSelected())
		{
			return;
		}

		var query = queryText.Text;
		if (string.IsNullOrWhiteSpace(query))
		{
			return;
		}

		if (!QueryParserLISP.TryParse(query, out var provider, out var errors))
		{
			var message = string.Join(Environment.NewLine, errors);
			MessageBox.Show(message, "Invalid Query", MessageBoxButton.OK, MessageBoxImage.Error);
			return;
		}

		verses = Options.Search(provider);

		found.ItemsSource = verses;
		scripturesCount.Text = "Scriptures: " + verses.Count;
	}

	private void OnSelectedChanged(object sender, SelectionChangedEventArgs args)
	{
		selectedsCount.Text = "Selected: " + found.SelectedItems.Count;
	}

	private void OnQueryOpen(object sender, RoutedEventArgs args)
	{
		var dialog = new Microsoft.Win32.OpenFileDialog();
		dialog.DefaultExt = ".txt";
		dialog.Filter = "Text|*.txt";
		var result = dialog.ShowDialog();
		if (result != true)
		{
			return;
		}
		var path = dialog.FileName;
		FileStream? stream = null;
		StreamReader? reader = null;
		string? query;
		try
		{
			stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
			reader = new StreamReader(stream);
			query = reader.ReadToEnd();
		}
		catch
		{
			var message = "Couldn't open file " + path;
			MessageBox.Show(message, "Couldn't Open", MessageBoxButton.OK, MessageBoxImage.Error);
			return;
		}
		finally
		{
			reader?.Dispose();
			stream?.Dispose();
		}
		queryText.Text = query;
	}

	private void OnQuerySave(object sender, RoutedEventArgs args)
	{
		var dialog = new Microsoft.Win32.SaveFileDialog();
		dialog.DefaultExt = ".txt";
		dialog.Filter = "Text|*.txt";
		var result = dialog.ShowDialog();
		if (result != true)
		{
			return;
		}
		var path = dialog.FileName;
		FileStream? stream = null;
		StreamWriter? writer = null;
		try
		{
			stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
			writer = new StreamWriter(stream);
			writer.WriteLine(queryText.Text);
		}
		catch
		{
			var message = "Couldn't save file " + path;
			MessageBox.Show(message, "Couldn't Save", MessageBoxButton.OK, MessageBoxImage.Error);
			return;
		}
		finally
		{
			writer?.Dispose();
			stream?.Dispose();
		}
	}

	private void OnScripturesSaveAll(object sender, RoutedEventArgs args)
	{
		var dialog = new Microsoft.Win32.SaveFileDialog();
		dialog.DefaultExt = ".txt";
		dialog.Filter = "Text|*.txt";
		var result = dialog.ShowDialog();
		if (result != true)
		{
			return;
		}
		var path = dialog.FileName;
		FileStream? stream = null;
		StreamWriter? writer = null;
		try
		{
			stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
			writer = new StreamWriter(stream);
			if (verses is null || verses.Count <= 0)
			{
				return;
			}
			foreach (var verse in verses)
			{
				writer.WriteLine(verse);
			}
		}
		catch
		{
			var message = "Couldn't save file " + path;
			MessageBox.Show(message, "Couldn't Save", MessageBoxButton.OK, MessageBoxImage.Error);
			return;
		}
		finally
		{
			writer?.Dispose();
			stream?.Dispose();
		}
	}

	private void OnSaveSelected(object sender, RoutedEventArgs args)
	{
		var dialog = new Microsoft.Win32.SaveFileDialog();
		dialog.DefaultExt = ".txt";
		dialog.Filter = "Text|*.txt";
		var result = dialog.ShowDialog();
		if (result != true)
		{
			return;
		}
		var path = dialog.FileName;
		FileStream? stream = null;
		StreamWriter? writer = null;
		try
		{
			stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
			writer = new StreamWriter(stream);
			var selceted = found.SelectedItems;
			if (selceted is null || selceted.Count <= 0)
			{
				return;
			}
			foreach (var verse in selceted)
			{
				writer.WriteLine(verse);
			}
		}
		catch
		{
			var message = "Couldn't save file " + path;
			MessageBox.Show(message, "Couldn't Save", MessageBoxButton.OK, MessageBoxImage.Error);
			return;
		}
		finally
		{
			writer?.Dispose();
			stream?.Dispose();
		}
	}

	private void OnExit(object sender, RoutedEventArgs args)
	{
		Close();
	}

	private void OnAbout(object sender, RoutedEventArgs args)
	{
		var builder = new StringBuilder();
		var assembly = Assembly.GetEntryAssembly();
		builder.AppendLine("1.0.3");
		var metas = assembly.GetCustomAttributes<AssemblyMetadataAttribute>();
		foreach (var meta in metas)
		{
			builder.Append(meta.Key);
			builder.Append(" ");
			builder.AppendLine(meta.Value);
		}
#if DEBUG
		builder.AppendLine("Bulid: DEBUG");
#endif
		var message = builder.ToString();
		MessageBox.Show(message, "About", MessageBoxButton.OK, MessageBoxImage.Information);
	}

	private void OnHelpQuerys(object sender, RoutedEventArgs args)
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

	private void OnWhatsExcluded(object sender, RoutedEventArgs args)
	{
		var message =
			"Esther\n" +
			"Songs of Solomon\n" +
			"D&C (LDS 77)\n" +
			"D&C (LDS 102)(RLDS 99)(1835 5)(1844 5)\n" +
			"D&C (LDS 108)\n" +
			"D&C (LDS 109)\n" +
			"D&C (LDS 110)\n" +
			"D&C (LDS 111)\n" +
			"D&C (LDS 113)\n" +
			"D&C (LDS 114)\n" +
			"D&C (LDS 115)\n" +
			"D&C (LDS 118)\n" +
			"D&C (LDS 123)\n" +
			"D&C (LDS 124)(RLDS 107)(1844 103)\n" +
			"D&C (LDS 126)\n" +
			"D&C (LDS 127)(RLDS 109)(1844 105)\n" +
			"D&C (LDS 128)(RLDS 110)(1844 106)\n" +
			"D&C (LDS 129)\n" +
			"D&C (LDS 130)\n" +
			"D&C (LDS 131)\n" +
			"D&C (LDS 132)\n" +
			"D&C (LDS 135)(RLDS 113)(1844 111)\n" +
			"D&C (LDS 136)\n" +
			"D&C (LDS 137)\n" +
			"D&C (LDS 138)\n" +
			"D&C (LDS OD 1)\n" +
			"D&C (LDS OD 2)\n" +
			"D&C (RLDS 99)(LDS 102)(1835 5)(1844 5)\n" +
			"D&C (RLDS 107)(LDS 124)(1844 103)\n" +
			"D&C (RLDS 109)(LDS 127)(1844 105)\n" +
			"D&C (RLDS 110)(LDS 128)(1844 106)\n" +
			"D&C (RLDS 113)(LDS 135)(1844 111)\n" +
			"D&C (RLDS 114-165)\n" +
			"D&C (1835)(LDS 102)(RLDS 99)(1844 5)\n" +
			"D&C (1844 5)(LDS 102)(RLDS 99)(1835 5)\n" +
			"D&C (1844 103)(LDS 124)(RLDS 107)\n" +
			"D&C (1844 105)(LDS 127)(RLDS 109)\n" +
			"D&C (1844 106)(LDS 128)(RLDS 110)\n" +
			"D&C (1844 111)(LDS 135)(RLDS 113)";
		MessageBox.Show(
			message,
			"What's Excluded", MessageBoxButton.OK, MessageBoxImage.Information);
	}

	private void OnLink(object sender, RoutedEventArgs args)
	{
		if (!(sender is MenuItem menu) ||
			!(menu.DataContext is string url))
		{
			return;
		}
		try
		{
			var info = new ProcessStartInfo(url)
			{
				UseShellExecute = true,
			};
			Process.Start(info);
		}
		catch
		{
		}
	}

	private void OnExample(object sender, RoutedEventArgs args)
	{
		if (!(sender is MenuItem menu) ||
			!(menu.DataContext is string query))
		{
			return;
		}
		queryText.Text = query;
	}
}
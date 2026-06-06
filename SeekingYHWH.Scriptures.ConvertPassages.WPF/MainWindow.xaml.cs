using System;
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
	private readonly Options options = new Options();
	private readonly string optionsPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SeekingYHWH", "ScripturesConvertPassages", "Options.tsv");
	private readonly PassagesConverter converter = new PassagesConverter();
	private readonly Dictionary<string, BookConverter> lds = PassagesConverter.CreateBooksEmpty();
	private readonly Dictionary<string, BookConverter> rlds = PassagesConverter.CreateBooksEmpty();

	public MainWindow()
	{
		InitializeComponent();

		try
		{
			Directory.CreateDirectory(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SeekingYHWH", "ScripturesConvertPassages"));
		}
		catch
		{
			//Nothing on purpse
		}
		options.Read(optionsPath);
		options.ClearChanged();

		options.SetInitialize(converter, lds, rlds);

		switch (options.Direction)
		{
		case "L":
		case "l":
		default:
			OnLDSToRLDS(null, null);
			break;

		case "R":
		case "r":
			OnRLDSToLDS(null, null);
			break;
		}
	}

	private void OnOptions(object sender, RoutedEventArgs args)
	{
		var dialog = new OptionsWindow(options);
		dialog.ShowDialog();
		if (options.Changed)
		{
			options.Write(optionsPath);
			options.SetInitializeChanged(converter, lds, rlds);
			options.ClearChanged();
		}
	}

	private void OnLDSToRLDS(object sender, RoutedEventArgs args)
	{
		directionButton.Click -= OnLDSToRLDS;
		converter.Books = lds;
		fromLabel.Content = "LDS";
		toLabel.Content = "RLDS";
		directionButton.Click += OnRLDSToLDS;
	}

	private void OnRLDSToLDS(object sender, RoutedEventArgs args)
	{
		directionButton.Click -= OnRLDSToLDS;
		converter.Books = rlds;
		fromLabel.Content = "RLDS";
		toLabel.Content = "LDS";
		directionButton.Click += OnLDSToRLDS;
	}

	private void OnConvert(object sender, RoutedEventArgs args)
	{
		try
		{
			var value = passagesText.Text;
			convertedText.Text = converter.Convert(value);
		}
		catch (Exception exception)
		{
			convertedText.Text = string.Empty;

			status.Text = "Status: Exception";

			MessageBox.Show(exception.Message, "Problems Parsing Passages", MessageBoxButton.OK, MessageBoxImage.Error);

			return;
		}
		switch (options.Convert)
		{
		case "N":
		case "n":
			status.Text = "Status: Converted";
			break;

		case "A":
		case "a":
		default:
			try
			{
				Clipboard.SetText(convertedText.Text);

				if (!converter.Error)
				{
					status.Text = "Status: Converted Success Copied";
				}
				else
				{
					status.Text = "Status: Converted Failure Copied";
				}
			}
			catch (Exception exception)
			{
				if (!converter.Error)
				{
					status.Text = "Status: Converted Success Copy Error";
				}
				else
				{
					status.Text = "Status: Converted Failure Copy Error";
				}

				MessageBox.Show(exception.Message, "Can't Copy", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			break;

		case "S":
		case "s":
			if (!converter.Error)
			{
				try
				{
					Clipboard.SetText(convertedText.Text);

					status.Text = "Status: Converted Success Copied";
				}
				catch (Exception exception)
				{
					status.Text = "Status: Converted Success Copy Error";

					MessageBox.Show(exception.Message, "Can't Copy", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
			else
			{
				status.Text = "Status: Converted Failure";
			}
			break;
		}
	}

	private void OnCopy(object sender, RoutedEventArgs args)
	{
		try
		{
			Clipboard.SetText(convertedText.Text);
		}
		catch (Exception exception)
		{
			MessageBox.Show(exception.Message, "Can't Copy", MessageBoxButton.OK, MessageBoxImage.Error);
		}
	}

	private void OnClear(object sender, RoutedEventArgs args)
	{
		convertedText.Text = string.Empty;
		status.Text = "Status:";
	}

	private void OnExit(object sender, RoutedEventArgs args)
	{
		Close();
	}

	private void OnAbout(object sender, RoutedEventArgs args)
	{
		var builder = new StringBuilder();
		var assembly = Assembly.GetEntryAssembly();
		builder.AppendLine("1.0.0");
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

	private void OnHelp(object sender, RoutedEventArgs args)
	{
		var message =
			"Converts one versification to another.\n\n" +
			"Can convert a chapter (1), chapters (1-2), chapter and verse (1:2), chapter and verses (1:2-3), verse in a list after a chapter (1), verses in a list after a chapter( (1-2), and chapters and verses (1:2-3:4).\n\n" +
			"Multiple options can be specified by a ','. When using chapter or chapters they need to be in the list first.\n\n" +
			"Use ';' when you want to specify another book.\n\n" +
			"When a book is specified that is not for conversion the program will copy the text till ';' is reached.";
		MessageBox.Show(message, "Help", MessageBoxButton.OK, MessageBoxImage.Information);
	}

	private void OnWhatsExcluded(object sender, RoutedEventArgs args)
	{
		var message =
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
}

using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;

namespace SeekingYHWH.Scriptures;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var datasPath = Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
			"SeekingYHWH",
			"ScripuresSearch");
		Directory.CreateDirectory(datasPath);
		Stores.Prepare(datasPath);
		Languages.Prepare(datasPath);
		var optionsPath = Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
			"SeekingYHWH",
			"ScripturesSearch");
		Directory.CreateDirectory(optionsPath);
		Options.Prepare(optionsPath);
	}
}

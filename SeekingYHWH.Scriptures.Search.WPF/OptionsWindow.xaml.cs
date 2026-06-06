using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SeekingYHWH.Scriptures;

/// <summary>
/// Interaction logic for OptionsWindow.xaml
/// </summary>
public partial class OptionsWindow : Window
{
	public OptionsWindow()
	{
		InitializeComponent();
	}

	public override void EndInit()
	{
		base.EndInit();

		booksList.ItemsSource = Options.Books;

		languagesCombo.ItemsSource = null;
		var languages = Languages.Locals;
		languagesCombo.ItemsSource = languages;
		if (languages.Count == 1)
		{
			languagesCombo.SelectedIndex = 0;
		}
		switch (Options.Portion)
		{
		case Options.PortionSentence:
			portionSentence.IsChecked = true;
			break;

		default:
		case Options.PortionVerse:
			portionVerse.IsChecked = true;
			break;

		case Options.PortionChapter:
			portionChapter.IsChecked = true;
			break;
		}
	}

	private void OnLanguagesChanged(object sender, SelectionChangedEventArgs args)
	{
		var offset = languagesCombo.SelectedIndex;
		var languages = Languages.Locals;
		if (offset < 0 || offset >= languages.Count)
		{
			return;
		}
		Options.Change(languages[offset]);
	}

	private void OnPortionSentenceChecked(object sender, RoutedEventArgs args)
	{
		Options.PortionSetSentence();
	}

	private void OnPortionVerseChecked(object sender, RoutedEventArgs args)
	{
		Options.PortionSetVerse();
	}

	private void OnPortionChapterChecked(object sender, RoutedEventArgs args)
	{
		Options.PortionSetChapter();
	}

	protected override void OnClosed(EventArgs args)
	{
		base.OnClosed(args);

		Options.Save();
	}
}
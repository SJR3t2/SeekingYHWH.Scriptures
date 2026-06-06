namespace SeekingYHWH.Scriptures;

public partial class OptionsPage : ContentPage
{
	private LanguageInfo language;

	public OptionsPage()
	{
		InitializeComponent();

		booksList.ItemsSource = Options.Books;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		languagesPicker.ItemsSource = null;
		var languages = Languages.Locals;
		languagesPicker.ItemsSource = languages;
		if (languages.Count == 1)
		{
			languagesPicker.SelectedIndex = 0;
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

	private void LanguagesChanged(object sender, EventArgs args)
	{
		var offset = languagesPicker.SelectedIndex;
		var languages = Languages.Locals;
		if (offset < 0 || offset >= languages.Count)
		{
			return;
		}
		language = languages[offset];

		Options.Change(language);
	}

	private void PortionSentenceChanged(object sender, CheckedChangedEventArgs args)
	{
		if (!args.Value)
		{
			return;
		}

		Options.PortionSetSentence();
	}

	private void PortionVerseChanged(object sender, CheckedChangedEventArgs args)
	{
		if (!args.Value)
		{
			return;
		}

		Options.PortionSetVerse();
	}

	private void PortionChapterChanged(object sender, CheckedChangedEventArgs args)
	{
		if (!args.Value)
		{
			return;
		}

		Options.PortionSetChapter();
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();

		Options.Save();
	}
}
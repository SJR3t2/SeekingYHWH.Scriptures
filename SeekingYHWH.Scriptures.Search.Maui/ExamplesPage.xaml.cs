namespace SeekingYHWH.Scriptures;

public partial class ExamplesPage : ContentPage
{
	public ExamplesPage()
	{
		InitializeComponent();
	}

	private void OnTapped(object sender, EventArgs args)
	{
		if (sender is not TextCell cell)
		{
			return;
		}

		if (Shell.Current is not AppShell shell)
		{
			return;
		}

		var query = cell.Detail;
		shell.SearchPage.SetQueryText(query);
		shell.SelectSearchPage();
    }
}
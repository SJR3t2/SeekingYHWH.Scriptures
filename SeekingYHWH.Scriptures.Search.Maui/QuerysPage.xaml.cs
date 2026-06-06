namespace SeekingYHWH.Scriptures;

public partial class QuerysPage : ContentPage
{

	public QuerysPage()
	{
		InitializeComponent();
	}

	private void OnQuery(object sender, EventArgs args)
	{
		if (sender is not TextCell cell)
		{
			return;
		}

		if (Shell.Current is not AppShell shell)
		{
			return;
		}

		var query = cell.Text;
		shell.SearchPage.AppendQueryQuery(query);
		shell.SelectSearchPage();
	}

	private void OnText(object sender, EventArgs args)
	{
		if (sender is not TextCell cell)
		{
			return;
		}

		if (Shell.Current is not AppShell shell)
		{
			return;
		}

		var query = cell.Text;
		shell.SearchPage.AppendQueryText(query);
		shell.SelectSearchPage();
	}

	private async void OnLink(object sender, EventArgs args)
	{
		if (sender is not TextCell cell)
		{
			return;
		}

		var url = cell.Detail;
		await Browser.Open(url);
	}
}
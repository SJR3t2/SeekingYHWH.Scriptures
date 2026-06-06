namespace SeekingYHWH.Scriptures;

public partial class ExcludedPage : ContentPage
{
	public ExcludedPage()
	{
		InitializeComponent();
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
namespace SeekingYHWH.Scriptures.ConvertPassages.MAUI;

public partial class LinksPage : ContentPage
{
	public LinksPage()
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
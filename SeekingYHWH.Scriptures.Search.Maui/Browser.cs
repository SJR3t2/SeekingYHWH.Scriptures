namespace SeekingYHWH.Scriptures;

internal static class Browser
{
	private static readonly BrowserLaunchOptions externally = new BrowserLaunchOptions() { LaunchMode = BrowserLaunchMode.External };
	private static readonly BrowserLaunchOptions internally = new BrowserLaunchOptions() { LaunchMode = BrowserLaunchMode.SystemPreferred };

	public static async Task Open(string url)
	{
		if (string.IsNullOrWhiteSpace(url))
		{
			return;
		}

		try
		{
			await Microsoft.Maui.ApplicationModel.Browser.Default.OpenAsync(url, externally);
			return;
		}
		catch
		{
		}

		try
		{
			await Microsoft.Maui.ApplicationModel.Browser.Default.OpenAsync(url, internally);
			return;
		}
		catch
		{
		}
	}
}

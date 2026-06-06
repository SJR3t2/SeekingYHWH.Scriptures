namespace SeekingYHWH.Scriptures;

public partial class SearchPage : ContentPage
{
	private readonly string queryPath = Path.Combine(FileSystem.CacheDirectory, "Query.txt");

	private List<string>? verses;

	public SearchPage()
	{
		InitializeComponent();

		if (File.Exists(queryPath))
		{
			queryEditor.Text = File.ReadAllText(queryPath);
		}
	}

	public void SetQueryText(string value)
	{
		queryEditor.Text = value;
	}

	public void AppendQueryQuery(string value)
	{
		queryEditor.Text = string.Concat(queryEditor.Text, value, "(");
	}

	public void AppendQueryText(string value)
	{
		queryEditor.Text += value;
	}

	public void OnSleep()
	{
		Directory.CreateDirectory(FileSystem.CacheDirectory);
		File.WriteAllText(queryPath, queryEditor.Text);
	}

	private async void CopyAll(object sender, EventArgs args)
	{
		if (verses is null || verses.Count <= 0)
		{
			return;
		}

		try
		{
			var text = string.Join(Environment.NewLine, verses);
			await Clipboard.SetTextAsync(text);
		}
		catch
		{
			await DisplayAlert("Copy", "Can't Copy All", "OK");
		}
	}

	private async void CopySelected(object sender, EventArgs args)
	{
		var selceted = found.SelectedItems;
		if (selceted is null || selceted.Count <= 0)
		{
			return;
		}

		try
		{
			var text = string.Join(Environment.NewLine, selceted);
			await Clipboard.SetTextAsync(text);
		}
		catch
		{
			await DisplayAlert("Copy", "Can't Copy Selected", "OK");
		}
	}

	private async void ClearSelected(object sender, EventArgs args)
	{
		found.SelectedItems?.Clear();
	}

	private async void Search(object sender, EventArgs args)
	{
		found.SelectedItems.Clear();
		found.ItemsSource = null;

		if (Languages.Locals.Count <= 0)
		{
			await DisplayAlert("Query", "Need to Download first", "OK");
			return;
		}
		if (!Options.IsSelected())
		{
			await DisplayAlert("Query", "Need to Select atleast one Include under Options first", "OK");
			return;
		}

		var query = queryEditor.Text;
		if (string.IsNullOrWhiteSpace(query))
		{
			return;
		}

		if (!QueryParserLISP.TryParse(query, out var provider, out var errors))
		{
			var message = string.Join(Environment.NewLine, errors);
			await DisplayAlert("Query", message, "OK");
			return;
		}

		verses = Options.Search(provider);

		found.ItemsSource = verses;
	}
}

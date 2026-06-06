namespace SeekingYHWH.Scriptures;

public partial class AppShell : Shell
{
	private readonly ShellContent searchShell;
	private readonly SearchPage searchPage;

	public AppShell()
	{
		InitializeComponent();

		var searchPageIcon = new FileImageSource();
		searchPage = new SearchPage();
		searchShell = new ShellContent()
		{
			Title = "Search",
			Icon = searchPageIcon,
			Content = searchPage,
		};
		searchPageIcon.SetAppTheme<string>(FileImageSource.FileProperty, "searchlight.svg", "searchdark.svg");
		this.Items.Add(searchShell);

		var optionsPageIcon = new FileImageSource();
		var optionsPage = new ShellContent()
		{
			Title = "Options",
			Icon = optionsPageIcon,
			Content = new OptionsPage(),
		};
		optionsPageIcon.SetAppTheme<string>(FileImageSource.FileProperty, "optionslight.svg", "optionsdark.svg");
		this.Items.Add(optionsPage);

		var downloadPageIcon = new FileImageSource();
		var downloadPage = new ShellContent()
		{
			Title = "Download",
			Icon = downloadPageIcon,
			Content = new DownloadPage(),
		};
		downloadPageIcon.SetAppTheme<string>(FileImageSource.FileProperty, "downloadlight.svg", "downloaddark.svg");
		this.Items.Add(downloadPage);

		var linksPageIcon = new FileImageSource();
		var linksPage = new ShellContent()
		{
			Title = "Links",
			Icon = linksPageIcon,
			Content = new LinksPage(),
		};
		linksPageIcon.SetAppTheme<string>(FileImageSource.FileProperty, "linkslight.svg", "linksdark.svg");
		this.Items.Add(linksPage);

		var excludedPageIcon = new FileImageSource();
		var excludedPage = new ShellContent()
		{
			Title = "Excluded",
			Icon = excludedPageIcon,
			Content = new ExcludedPage(),
		};
		excludedPageIcon.SetAppTheme<string>(FileImageSource.FileProperty, "excludedlight.svg", "excludeddark.svg");
		this.Items.Add(excludedPage);

		var examplesPageIcon = new FileImageSource();
		var examplesPage = new ShellContent()
		{
			Title = "Examples",
			Icon = examplesPageIcon,
			Content = new ExamplesPage(),
		};
		examplesPageIcon.SetAppTheme<string>(FileImageSource.FileProperty, "exampleslight.svg", "examplesdark.svg");
		this.Items.Add(examplesPage);

		var querysPageIcon = new FileImageSource();
		var querysPage = new ShellContent()
		{
			Title = "Queries",
			Icon = querysPageIcon,
			Content = new QuerysPage(),
		};
		querysPageIcon.SetAppTheme<string>(FileImageSource.FileProperty, "queryslight.svg", "querysdark.svg");
		this.Items.Add(querysPage);

		if (Languages.Locals.Count <= 0)
		{
			CurrentItem = downloadPage;
		}
		else if (!Options.IsSelected())
		{
			CurrentItem = optionsPage;
		}
		else
		{
			CurrentItem = searchShell;
		}
	}

	public SearchPage SearchPage => searchPage;

	public void SelectSearchPage()
	{
		CurrentItem = searchShell;
	}

	public void OnSleep()
	{
		searchPage.OnSleep();
	}
}

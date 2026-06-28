namespace SeekingYHWH.Scriptures;

public partial class AppShell : Shell
{
	private readonly ShellContent searchShell;
	private readonly SearchPage searchPage;

	public AppShell()
	{
		InitializeComponent();

		var searchIcon = new FileImageSource();
		searchPage = new SearchPage();
		searchShell = new ShellContent()
		{
			Title = "Search",
			Icon = searchIcon,
			Content = searchPage,
		};
		searchIcon.SetAppTheme<string>(FileImageSource.FileProperty, "searchlight.svg", "searchdark.svg");
		this.Items.Add(searchShell);

		var optionsIcon = new FileImageSource();
		var optionsPage = new ShellContent()
		{
			Title = "Options",
			Icon = optionsIcon,
			Content = new OptionsPage(),
		};
		optionsIcon.SetAppTheme<string>(FileImageSource.FileProperty, "optionslight.svg", "optionsdark.svg");
		this.Items.Add(optionsPage);

		var downloadIcon = new FileImageSource();
		var downloadPage = new ShellContent()
		{
			Title = "Download",
			Icon = downloadIcon,
			Content = new DownloadPage(),
		};
		downloadIcon.SetAppTheme<string>(FileImageSource.FileProperty, "downloadlight.svg", "downloaddark.svg");
		this.Items.Add(downloadPage);

		var linksIcon = new FileImageSource();
		var linksPage = new ShellContent()
		{
			Title = "Links",
			Icon = linksIcon,
			Content = new LinksPage(),
		};
		linksIcon.SetAppTheme<string>(FileImageSource.FileProperty, "linkslight.svg", "linksdark.svg");
		this.Items.Add(linksPage);

		var excludedIcon = new FileImageSource();
		var excludedPage = new ShellContent()
		{
			Title = "Excluded",
			Icon = excludedIcon,
			Content = new ExcludedPage(),
		};
		excludedIcon.SetAppTheme<string>(FileImageSource.FileProperty, "excludedlight.svg", "excludeddark.svg");
		this.Items.Add(excludedPage);

		var examplesIcon = new FileImageSource();
		var examplesPage = new ShellContent()
		{
			Title = "Examples",
			Icon = examplesIcon,
			Content = new ExamplesPage(),
		};
		examplesIcon.SetAppTheme<string>(FileImageSource.FileProperty, "exampleslight.svg", "examplesdark.svg");
		this.Items.Add(examplesPage);

		var querysIcon = new FileImageSource();
		var querysPage = new ShellContent()
		{
			Title = "Queries",
			Icon = querysIcon,
			Content = new QuerysPage(),
		};
		querysIcon.SetAppTheme<string>(FileImageSource.FileProperty, "queryslight.svg", "querysdark.svg");
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

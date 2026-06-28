namespace SeekingYHWH.Scriptures.ConvertPassages.MAUI;

public partial class AppShell : Shell
{
	private readonly string optionsPath = Path.Combine(FileSystem.CacheDirectory, "Options.tsv");
	private readonly Options options = new Options();

	public AppShell()
	{
		InitializeComponent();

		options.Read(optionsPath);
		options.ClearChanged();

		var convertIcon = new FileImageSource();
		convertIcon.SetAppTheme<string>(FileImageSource.FileProperty, "convertlight.svg", "convertdark.svg");
		var convertPage = new ConvertPage(options);
		var convertContent = new ShellContent()
		{
			Title = "Convert",
			Icon = convertIcon,
			Content = convertPage,
		};
		this.Items.Add(convertContent);

		var optionsIcon = new FileImageSource();
		optionsIcon.SetAppTheme<string>(FileImageSource.FileProperty, "optionslight.svg", "optionsdark.svg");
		var optionsContent = new ShellContent()
		{
			Title = "Options",
			Icon = optionsIcon,
			ContentTemplate = new DataTemplate(() => new OptionsPage(optionsPath, options)),
		};
		this.Items.Add(optionsContent);

		var linksIcon = new FileImageSource();
		linksIcon.SetAppTheme<string>(FileImageSource.FileProperty, "linkslight.svg", "linksdark.svg");
		var linksContent = new ShellContent()
		{
			Title = "Links",
			Icon = linksIcon,
			ContentTemplate = new DataTemplate(() => new LinksPage()),
		};
		this.Items.Add(linksContent);

		var excludedIcon = new FileImageSource();
		excludedIcon.SetAppTheme<string>(FileImageSource.FileProperty, "excludedlight.svg", "excludeddark.svg");
		var excludedContent = new ShellContent()
		{
			Title = "Excluded",
			Icon = excludedIcon,
			ContentTemplate = new DataTemplate(() => new ExcludedPage()),
		};
		this.Items.Add(excludedContent);
	}
}

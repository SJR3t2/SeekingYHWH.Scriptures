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

		var convertPage = new ConvertPage(options);
		var convertContent = new ShellContent()
		{
			Title = "Convert",
			Content = convertPage,
		};
		this.Items.Add(convertContent);

		var optionsContent = new ShellContent()
		{
			Title = "Options",
			ContentTemplate = new DataTemplate(() => new OptionsPage(optionsPath, options)),
		};
		this.Items.Add(optionsContent);

		var linksContent = new ShellContent()
		{
			Title = "Links",
			ContentTemplate = new DataTemplate(() => new LinksPage()),
		};
		this.Items.Add(linksContent);

		var excludedContent = new ShellContent()
		{
			Title = "Excluded",
			ContentTemplate = new DataTemplate(() => new ExcludedPage()),
		};
		this.Items.Add(excludedContent);
	}
}

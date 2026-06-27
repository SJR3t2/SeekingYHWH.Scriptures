namespace SeekingYHWH.Scriptures.ConvertPassages.MAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		var optionsPath = Path.Combine(FileSystem.CacheDirectory, "Options.tsv");
		var options = new Options();

		options.Read(optionsPath);
		options.ClearChanged();

		var convertPage = new ConvertPage(options);
		var convertContent = new ShellContent()
		{
			Title = "Convert",
			Content = convertPage,
		};
		this.Items.Add(convertContent);

		var optionsPage = new OptionsPage(optionsPath, options);
		var optionsContent = new ShellContent()
		{
			Title = "Options",
			Content = optionsPage,
		};
		this.Items.Add(optionsContent);

		var linksContent = new ShellContent()
		{
			Title = "Links",
			Content = new LinksPage(),
		};
		this.Items.Add(linksContent);

		var excludedContent = new ShellContent()
		{
			Title = "Excluded",
			Content = new ExcludedPage(),
		};
		this.Items.Add(excludedContent);
	}
}

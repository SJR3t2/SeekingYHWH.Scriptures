namespace SeekingYHWH.Scriptures.ConvertPassages.MAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		var convertPage = new ShellContent()
		{
			Title = "Convert",
			Content = new ConvertPage(),
		};
		this.Items.Add(convertPage);

		var optionsPage = new ShellContent()
		{
			Title = "Options",
			Content = new OptionsPage()
			{
				BindingContext = State.Options,
			},
		};
		this.Items.Add(optionsPage);

		var linksPage = new ShellContent()
		{
			Title = "Links",
			Content = new LinksPage(),
		};
		this.Items.Add(linksPage);

		var excludedPage = new ShellContent()
		{
			Title = "Excluded",
			Content = new ExcludedPage(),
		};
		this.Items.Add(excludedPage);
	}
}

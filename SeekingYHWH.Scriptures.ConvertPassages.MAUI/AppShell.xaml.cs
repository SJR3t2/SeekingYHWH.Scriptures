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
	}
}

namespace SeekingYHWH.Scriptures
{
	public partial class App : Application
	{
		private readonly AppShell shell;

		public App()
		{
			InitializeComponent();

			this.shell = new AppShell();
			MainPage = shell;
		}

		protected override void OnSleep()
		{
			base.OnSleep();

			Options.Save();

			shell.OnSleep();
		}
	}
}

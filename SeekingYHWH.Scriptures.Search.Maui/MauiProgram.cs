using Microsoft.Extensions.Logging;

namespace SeekingYHWH.Scriptures
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			Stores.Prepare(FileSystem.CacheDirectory);
			Languages.Prepare(FileSystem.CacheDirectory);
			Options.Prepare(FileSystem.CacheDirectory);

			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

			return builder.Build();
		}
	}
}

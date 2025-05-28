using CosyShelf.Data.Entities;
using CosyShelf.Data.Repositories;
using CosyShelf.Data.Services;
using Microsoft.Extensions.Logging;

namespace CosyShelf.UI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        // Initialise the database
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "cosyshelf.db");
        builder.Services.AddSingleton(_ => dbPath);

        // Register services
        builder.Services.AddSingleton<App>();
        builder.Services.AddSingleton<IRepository<BookEntity>, SQLiteRepository<BookEntity>>();
        builder.Services.AddSingleton<BookService>();
        builder.Services.AddSingleton<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

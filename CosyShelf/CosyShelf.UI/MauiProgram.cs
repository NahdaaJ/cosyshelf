﻿using Microsoft.Extensions.Logging;

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
		AppSetup.InitialiseDb();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

using Microsoft.Extensions.Logging;

namespace HotelApp;

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
				//Myfonts
				fonts.AddFont("SmoochSans-Black.ttf", "SmoochSans-Black");
				fonts.AddFont("SmoochSans-Bold.ttf", "SmoochSans-Bold");
				fonts.AddFont("SmoochSans-ExtraBold.ttf", "SmoochSans-ExtraBold");
				fonts.AddFont("SmoochSans-ExtraLight.ttf", "SmoochSans-ExtraLight");
				fonts.AddFont("SmoochSans-Light.ttf", "SmoochSans-Light");
				fonts.AddFont("SmoochSans-Medium.ttf", "SmoochSans-Medium");
				fonts.AddFont("SmoochSans-Regular.ttf", "SmoochSans-Regular");
				fonts.AddFont("SmoochSans-SemiBold.ttf", "SmoochSans-SemiBold");
				fonts.AddFont("SmoochSans-Thin.ttf", "SmoochSans-Thin");
				
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

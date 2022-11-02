using CommunityToolkit.Maui;
using JinjuWeather.Extensions;

namespace JinjuWeather;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigurePages()
            .ConfigureViewModels()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("NotoSansKR-Black.otf", "NotoSansBlack");
                fonts.AddFont("NotoSansKR-Bold.otf", "NotoSansBold");
                fonts.AddFont("NotoSansKR-Light.otf", "NotoSansLight");
                fonts.AddFont("NotoSansKR-Medium.otf", "NotoSansMedium");
                fonts.AddFont("NotoSansKR-Regular.otf", "NotoSansRegular");
                fonts.AddFont("NotoSansKR-Thin.otf", "NotoSansThin");
            });

        return builder.Build();
    }
}


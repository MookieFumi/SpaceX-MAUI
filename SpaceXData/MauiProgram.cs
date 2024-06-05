using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using SpaceXData.Services;
using SpaceXData.Services.App;
using SpaceXData.ViewModels;
using SpaceXData.Views;

namespace SpaceXData;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<SpaceXService>();
        builder.Services.AddTransient<INavigationService, NavigationService>();
        builder.Services.AddTransient<ICoreService, CoreService>();
        builder.Services.AddTransient<LaunchesView>();
        builder.Services.AddTransient<LaunchesViewModel>();

        builder.Services.AddTransient<LaunchDetailView>();
        builder.Services.AddTransient<LaunchDetailViewModel>();

        Routing.RegisterRoute(nameof(LaunchDetailView), typeof(LaunchDetailView));

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
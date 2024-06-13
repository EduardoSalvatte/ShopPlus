using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace ShopPlus
{
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
                })
            .ConfigureMauiHandlers(handlers =>
             {
#if ANDROID
                        handlers.AddHandler(typeof(Entry), typeof(ShopPlus.Platforms.Android.MyEntryHandler));
#endif
             });

#if DEBUG
            builder.Logging.AddDebug();
#endif


            return builder.Build();
        }
    }
}

using Maui.CertificateAndEncodingLab.App.HttpResponseHandlers;
using Maui.CertificateAndEncodingLab.App.Services;
using Maui.CertificateAndEncodingLab.App.ViewModels;
using Microsoft.Extensions.Logging;

namespace Maui.CertificateAndEncodingLab.App
{
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

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<IGoogleService, GoogleService>();
            builder.Services.AddTransient<EncondingMessageHandler>();
            builder.Services.AddTransient<HttpSslValidationHandler>();
            builder.Services.AddHttpClient<IGoogleService, GoogleService>(client =>
            {
                client.BaseAddress = new Uri("https://google.com");
            })
            .AddHttpMessageHandler<EncondingMessageHandler>()
            .ConfigurePrimaryHttpMessageHandler<HttpSslValidationHandler>();

            return builder.Build();
        }
    }
}

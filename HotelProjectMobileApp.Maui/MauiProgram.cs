﻿using CommunityToolkit.Maui;
using HotelProjectMobileApp.Maui.ViewModels;
using HotelProjectMobileApp.Maui.Views;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace HotelProjectMobileApp.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<CategoryDetailPage>();
            builder.Services.AddTransient<EventPage>();
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<RegisterPage>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<ReservationPage>();

            builder.Services.AddTransient<CategoryDetailViewModel>();
            builder.Services.AddTransient<EventViewModel>();
            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<ReservationViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

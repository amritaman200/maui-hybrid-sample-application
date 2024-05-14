using maui_hybrid.Service;
using Microsoft.Extensions.Logging;

namespace maui_hybrid
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
                });

            builder.Services.AddMauiBlazorWebView();
			

#if DEBUG
			builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
           
#endif
			//builder.Services.AddSingleton(sp=>new HttpClient { BaseAddress=new Uri("https://dummyapi.online/") });
            builder.Services.AddSingleton(sp => new HttpClient
            {
                BaseAddress = new Uri("https://dummyjson.com/")
            });
	
				builder.Services.AddSingleton<IMovieService, MovieService>();
			builder.Services.AddSingleton<IProductService, ProductService>();
			return builder.Build();
        }


    }
}

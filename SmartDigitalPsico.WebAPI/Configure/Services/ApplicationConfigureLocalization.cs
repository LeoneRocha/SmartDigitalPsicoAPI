using Microsoft.AspNetCore.Localization;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.WebAPI.Configure.Services
{
    public static class ApplicationConfigureLocalization
    {
        public static void Configure(IServiceCollection services)
        {
            addLocalization(services);
        }
        private static void addLocalization(IServiceCollection services)
        {
            services.AddMvc()
                    .AddViewLocalization()
                    .AddDataAnnotationsLocalization();

            services.AddScoped<LanguageActionFilterAttribute>();

            services.Configure<RequestLocalizationOptions>(
                options =>
                {
                    var supportedCultures = CultureDateTimeHelper.TranslateCulture(CultureDateTimeHelper.GetCultures());

                    options.DefaultRequestCulture = new RequestCulture(culture: "pt-BR", uiCulture: "pt-BR");

                    options.SupportedCultures = supportedCultures;
                    options.SupportedUICultures = supportedCultures;
                });
        }
    }
}
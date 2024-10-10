using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.API;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.Service.Configure
{
    public static class ServiceCollectionConfigureLocalization
    {
        public static void Configure(IServiceCollection services)
        {
            addLocalization(services);
        }
        private static void addLocalization(IServiceCollection services)
        { 
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
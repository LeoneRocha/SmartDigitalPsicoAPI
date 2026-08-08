using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.API;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Localization
{
    public static class LocalizationServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreRequestLocalization(
            this IServiceCollection services,
            string defaultCulture = "pt-BR")
        {
            services.AddScoped<LanguageActionFilterAttribute>();

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = CultureDateTimeHelper.TranslateCulture(CultureDateTimeHelper.GetCultures());
                options.DefaultRequestCulture = new RequestCulture(culture: defaultCulture, uiCulture: defaultCulture);
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
            return services;
        }
    }
}

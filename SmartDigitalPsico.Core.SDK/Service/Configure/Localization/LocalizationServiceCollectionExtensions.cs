using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.API;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Localization;

/// <summary>
/// DI localization — <see cref="LanguageActionFilterAttribute"/> + culturas SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions.AddCoreRequestLocalization",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Alias AddCoreRequestLocalization/AddCoreLocalization; filter IAppLogger SDP.")]
public static class LocalizationServiceCollectionExtensions
{
    public static IServiceCollection AddCoreLocalization(
        this IServiceCollection services,
        string defaultCulture = "pt-BR")
        => AddCoreRequestLocalization(services, defaultCulture);

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

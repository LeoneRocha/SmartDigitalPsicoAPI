using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Mvc;

/// <summary>
/// DI MVC controllers — exclusivo SDP (ausente em SCH AddCore*).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "AddCoreMvcControllers SDP-only.")]
public static class MvcControllersServiceCollectionExtensions
{
    public static IServiceCollection AddCoreMvcControllers(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddMvc(options =>
        {
            options.RespectBrowserAcceptHeader = true;
            options.FormatterMappings.SetMediaTypeMappingForFormat(
                "json",
                MediaTypeHeaderValue.Parse("application/json"));
        })
            .AddViewLocalization()
            .AddDataAnnotationsLocalization();
        return services;
    }
}

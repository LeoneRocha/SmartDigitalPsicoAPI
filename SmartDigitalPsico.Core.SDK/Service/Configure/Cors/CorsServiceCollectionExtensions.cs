using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Cors;

/// <summary>
/// DI CORS — exclusivo SDP (ausente em SCH CoreServiceCollectionExtensions).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "AddCoreCors SDP-only (sem par SCH AddCore*); política AllowAnyOrigin host-dev.")]
public static class CorsServiceCollectionExtensions
{
    public static IServiceCollection AddCoreCors(this IServiceCollection services)
    {
#pragma warning disable S5122
        services.AddCors(options => options.AddDefaultPolicy(builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("Content-Disposition");
        }));
#pragma warning restore S5122
        return services;
    }
}

using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;
using SmartDigitalPsico.Core.SDK.Domain.Security;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Security;

/// <summary>
/// DI crypto AES/RSA — tipos casca SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions.AddCoreCrypto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Alias AddCoreCrypto; registra CryptoAdapterFactory/CryptoService casca.")]
public static class CryptoServiceCollectionExtensions
{
    public static IServiceCollection AddCoreCrypto(this IServiceCollection services)
    {
        services.AddTransient<ICryptoAdapterFactory, CryptoAdapterFactory>();
        services.AddTransient<ICryptoService, CryptoService>();
        return services;
    }
}

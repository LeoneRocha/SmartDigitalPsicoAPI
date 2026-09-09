using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service;
using SmartDigitalPsico.Core.SDK.Domain.Resiliency;
using SmartDigitalPsico.Core.SDK.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.EntityBase;

/// <summary>
/// DI EntityBaseService — surface SDP (impl retida Onda 4). Alinhado a SCH <c>AddCoreEntityBaseService</c>.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions.AddCoreEntityBaseService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Registra open-generic EntityBaseService SDP + IResiliencePolicyConfig; host registra repos/validators.")]
public static class EntityBaseServiceCollectionExtensions
{
    /// <summary>
    /// Host ainda deve registrar por entidade: <c>IEntityBaseRepository&lt;T&gt;</c>, <c>IValidator&lt;T&gt;</c>,
    /// e preferencialmente logging/mapping/cache. Serviços derivados concretos podem substituir o open-generic.
    /// </summary>
    public static IServiceCollection AddCoreEntityBaseService(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);
        services.TryAddSingleton<IResiliencePolicyConfig, ResiliencePolicyConfig>();
        services.TryAddScoped(typeof(IEntityBaseService<,>), typeof(EntityBaseService<,>));
        return services;
    }
}

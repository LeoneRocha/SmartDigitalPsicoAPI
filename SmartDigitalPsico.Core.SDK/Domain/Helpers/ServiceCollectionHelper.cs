using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO;
using Sch = SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca ServiceCollectionHelper — delega ao SCH com mapeamento de RepositoryInfo.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.ServiceCollectionHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando ServiceCollectionHelper ao SCH.")]
public static class ServiceCollectionHelper
{
    public static T[] FilterItems<T>(T[] items, params T[][] filters)
        => Sch.ServiceCollectionHelper.FilterItems(items, filters);

    public static HashSet<Type> GetRegisteredInterfaces(IServiceCollection services)
        => Sch.ServiceCollectionHelper.GetRegisteredInterfaces(services);

    public static RepositoryInfo[] GetInterfaces(string[] classSuffixes, params Assembly[] assemblies)
        => Sch.ServiceCollectionHelper.GetInterfaces(classSuffixes, assemblies)
            .Select(r => new RepositoryInfo
            {
                InterfaceType = r.InterfaceType,
                ImplementationType = r.ImplementationType
            })
            .ToArray();

    public static void RegisterInterfaces(IServiceCollection services, string[] classSuffixes, List<Type> ignoredInterfaces, Assembly[] assemblies)
        => Sch.ServiceCollectionHelper.RegisterInterfaces(services, classSuffixes, ignoredInterfaces, assemblies);
}

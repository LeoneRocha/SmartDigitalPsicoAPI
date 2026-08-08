using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class ServiceCollectionHelper
    {
        public static T[] FilterItems<T>(T[] items, params T[][] filters)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.ServiceCollectionHelper.FilterItems(items, filters);

        public static HashSet<Type> GetRegisteredInterfaces(IServiceCollection services)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.ServiceCollectionHelper.GetRegisteredInterfaces(services);

        public static SmartDigitalPsico.Core.SDK.Domain.DTO.RepositoryInfo[] GetInterfaces(string[] classSuffixes, params Assembly[] assemblies)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.ServiceCollectionHelper.GetInterfaces(classSuffixes, assemblies);

        public static void RegisterInterfaces(IServiceCollection services, string[] classSuffixes, List<Type> ignoredInterfaces, Assembly[] assemblies)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.ServiceCollectionHelper.RegisterInterfaces(services, classSuffixes, ignoredInterfaces, assemblies);
    }
}

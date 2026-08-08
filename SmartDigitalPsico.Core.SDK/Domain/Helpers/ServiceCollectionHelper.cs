using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.DTO;
using System.Reflection;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por ServiceCollectionHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public static class ServiceCollectionHelper
    {
        public static T[] FilterItems<T>(T[] items, params T[][] filters)
        {
            var filteredItems = items;
            foreach (var filter in filters)
            {
                filteredItems = filteredItems.Where(item => !filter.Contains(item)).ToArray();
            }
            return filteredItems;

        }

        /// <summary>
        /// Método GetRegisteredInterfaces: consulta e retorna dados.
        /// </summary>
        public static HashSet<Type> GetRegisteredInterfaces(IServiceCollection services)
        {
            return services.Where(service => service.Lifetime == ServiceLifetime.Scoped)
                           .Select(service => service.ServiceType)
                           .ToHashSet();
        }

        /// <summary>
        /// Método GetInterfaces: consulta e retorna dados.
        /// </summary>
        public static RepositoryInfo[] GetInterfaces(string[] classSuffixes, params Assembly[] assemblies)
        {
            var repositories = assemblies.SelectMany(assembly => assembly.GetTypes())
                             .Where(type => type.IsClass && !type.IsAbstract && classSuffixes.Any(suffix => type.Name.EndsWith(suffix)))
                             .Select(type => new RepositoryInfo
                             {
                                 InterfaceType = type.GetInterfaces().FirstOrDefault(i => i.Name == $"I{type.Name}"),
                                 ImplementationType = type
                             })
                             .Where(repo => repo.InterfaceType != null)
                             .ToArray();

            return repositories.ToArray();
        }

    /// <summary>
    /// Método RegisterInterfaces: cria ou persiste um novo registro/recurso.
    /// </summary>
    public static void RegisterInterfaces(IServiceCollection services, string[] classSuffixes, List<Type> ignoredInterfaces, Assembly[] assemblies)
        {
            var interfaceInfos = GetInterfaces(classSuffixes, assemblies);

            interfaceInfos = interfaceInfos.OrderBy(i => i.InterfaceType!.Name).ToArray();

            var filteredInterfaces = FilterItems(interfaceInfos.Select(info => info.InterfaceType!).ToArray(), ignoredInterfaces.ToArray());

            filteredInterfaces = filteredInterfaces.OrderBy(i => i.Name).ToArray();

            foreach (var interfaceType in filteredInterfaces)
            {
                var implementationType = interfaceInfos.First(info => info.InterfaceType == interfaceType).ImplementationType;
                if (implementationType != null)
                {
                    services.AddScoped(interfaceType, implementationType);
                }
            }
        }
    }
}

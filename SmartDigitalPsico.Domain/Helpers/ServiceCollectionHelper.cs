using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.DTO;
using System.Reflection;

namespace SmartDigitalPsico.Service.Helpers
{
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
        public static HashSet<Type> GetRegisteredInterfaces(IServiceCollection services)
        {
            var registeredServices = new HashSet<Type>();

            foreach (var service in services)
            {
                if (service.Lifetime == ServiceLifetime.Scoped)
                {
                    registeredServices.Add(service.ServiceType);
                }
            }

            return registeredServices;
        }


        public static RepositoryInfo[] GetInterfaces(string classSuffix, params Assembly[] assemblies)
        {
            var repositories = new List<RepositoryInfo>();

            foreach (var assembly in assemblies)
            {
                var types = assembly.GetTypes()
                    .Where(type => type.IsClass && !type.IsAbstract && type.Name.EndsWith(classSuffix))
                    .ToArray();

                foreach (var type in types)
                {
                    var interfaceType = type.GetInterfaces()
                        .FirstOrDefault(i => i.Name == $"I{type.Name}");

                    if (interfaceType != null)
                    {
                        repositories.Add(new RepositoryInfo
                        {
                            InterfaceType = interfaceType,
                            ImplementationType = type
                        });
                    }
                }
            }

            return repositories.ToArray();
        }
    }
}

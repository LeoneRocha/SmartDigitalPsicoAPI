using SmartDigitalPsico.Domain.DTO;
using System.Reflection;

namespace SmartDigitalPsico.Service.Helpers
{
    public static class RepositoryHelper
    {
        public static RepositoryInfo[] GetRepositories(string classSuffix, params Assembly[] assemblies)
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

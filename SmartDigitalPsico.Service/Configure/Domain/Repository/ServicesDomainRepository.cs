using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.Repository;
using System.Reflection;

using SmartDigitalPsico.Domain.Interfaces.Common;
namespace SmartDigitalPsico.Service.Configure.Domain
{
    /// <summary>
    /// DI de repositórios: bloco cache/blob no Core + scan de produto.
    /// </summary>
    public static class ServicesDomainRepository
    {
        private const string RepositorySuffix = "Repository";

        public static void AddDependencies(IServiceCollection services)
        {
            services.AddCoreCacheAndStorageRepositories();
            RegisterRepositories(services);
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            var assemblies = new[]
            {
                Assembly.GetExecutingAssembly(),
                Assembly.Load("SmartDigitalPsico.Domain"),
                Assembly.Load("SmartDigitalPsico.Data")
            };

            var ignoredInterfaces = new List<Type>
            {
                typeof(SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository),
                typeof(SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository),
                typeof(SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IFileDiskRepository),
                typeof(SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter),
                typeof(IUserTokenSessionRepository)
            };

            SmartDigitalPsico.Core.SDK.Domain.Helpers.ServiceCollectionHelper.RegisterInterfaces(
                services, [RepositorySuffix], ignoredInterfaces, assemblies);
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Repository.CacheManager;
using SmartDigitalPsico.Data.Repository.FileManager;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Service.Helpers;
using SmartDigitalPsico.Service.Infrastructure.Azure.Storage;
using System.Reflection;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainRepository
    {
        private const string RepositorySuffix = "Repository";

        public static void AddDependencies(IServiceCollection services)
        {
            RegisterManuallyAddedServices(services);
            RegisterRepositories(services);
        }

        private static void RegisterManuallyAddedServices(IServiceCollection services)
        {
            services.AddSingleton<IMemoryCacheRepository, MemoryCacheRepository>();
            services.AddScoped<IFileManager, FileManager>();
            services.AddScoped<IStorageBlobAdapter, AzureStorageBlobAdapter>();
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
                typeof(IMemoryCacheRepository),
                typeof(IFileManager),
                typeof(IStorageBlobAdapter),
                typeof(IUserTokenSessionRepository)
            };

            ServiceCollectionHelper.RegisterInterfaces(services, [RepositorySuffix], ignoredInterfaces, assemblies);
        } 
    }
}
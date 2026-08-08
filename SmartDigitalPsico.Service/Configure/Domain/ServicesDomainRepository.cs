using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Repository.FileManager;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using System.Reflection;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    /// <summary>
    /// Classe responsável por ServicesDomainRepository.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServicesDomainRepository
    {
        private const string RepositorySuffix = "Repository";

        /// <summary>
        /// Método AddDependencies: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddDependencies(IServiceCollection services)
        {
            RegisterManuallyAddedServices(services);
            RegisterRepositories(services);
        }

        private static void RegisterManuallyAddedServices(IServiceCollection services)
        {
            services.AddSingleton<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository, SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.MemoryCacheRepository>();
            services.AddSingleton<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository, SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.DiskCacheRepository>();
            services.AddSingleton<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IFileDiskRepository, SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository>();
            services.AddScoped<IFileManager, FileManager>();
            services.AddScoped<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter, SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter>();
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
                typeof(IFileManager),
                typeof(SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter),
                typeof(IUserTokenSessionRepository)
            };

            SmartDigitalPsico.Core.SDK.Domain.Helpers.ServiceCollectionHelper.RegisterInterfaces(services, [RepositorySuffix], ignoredInterfaces, assemblies);
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Repository.FileManager;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
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
            services.AddSingleton<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository, SmartDigitalPsicoAPI.Core.SDK.Data.Repository.CacheManager.MemoryCacheRepository>();
            services.AddSingleton<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository, SmartDigitalPsicoAPI.Core.SDK.Data.Repository.CacheManager.DiskCacheRepository>();
            services.AddSingleton<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IFileDiskRepository, SmartDigitalPsicoAPI.Core.SDK.Data.Repository.FileManager.FileDiskRepository>();
            services.AddScoped<IFileManager, FileManager>();
            services.AddScoped<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter, SmartDigitalPsicoAPI.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter>();
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
                typeof(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository),
                typeof(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository),
                typeof(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IFileDiskRepository),
                typeof(IFileManager),
                typeof(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter),
                typeof(IUserTokenSessionRepository)
            };

            SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.ServiceCollectionHelper.RegisterInterfaces(services, [RepositorySuffix], ignoredInterfaces, assemblies);
        }
    }
}

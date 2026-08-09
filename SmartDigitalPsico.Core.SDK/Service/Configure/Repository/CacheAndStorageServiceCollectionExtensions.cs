using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager;
using SmartDigitalPsico.Core.SDK.Data.Repository.FileManager;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Repository
{
    public static class CacheAndStorageServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreCacheAndStorageRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IMemoryCacheRepository, MemoryCacheRepository>();
            services.AddSingleton<IDiskCacheRepository, DiskCacheRepository>();
            services.AddSingleton<IFileDiskRepository, FileDiskRepository>();
            services.AddScoped<IStorageBlobAdapter, AzureStorageBlobAdapter>();
            return services;
        }
    }
}

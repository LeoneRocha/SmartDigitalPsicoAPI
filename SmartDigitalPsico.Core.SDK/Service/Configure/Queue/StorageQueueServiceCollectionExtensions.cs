using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Queue
{
    public static class StorageQueueServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreStorageQueue(this IServiceCollection services, string queueName)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(queueName);

            services.AddTransient<IStorageQueueRepositoryFactory, StorageQueueRepositoryFactory>();
            services.AddScoped<IStorageQueueContract>(provider =>
            {
                var serviceFactory = provider.GetRequiredService<IStorageQueueRepositoryFactory>();
                return new StorageQueueService(serviceFactory, queueName);
            });
            return services;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Service.Infrastructure;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainQueue
    {
        public static void AddDependencies(IServiceCollection services)
        {
            services.AddTransient<IStorageQueueRepositoryFactory, StorageQueueRepositoryFactory>();
            services.AddScoped<IStorageQueueContract>(provider =>
            {
                var serviceFactory = provider.GetRequiredService<IStorageQueueRepositoryFactory>();
                return new StorageQueueService(serviceFactory, StorageQueueNameConstants.GeneralQueue);
            });
        }
    }
}
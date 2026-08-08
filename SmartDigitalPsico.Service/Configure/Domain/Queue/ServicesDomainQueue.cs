using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.Queue;
using SmartDigitalPsico.Domain.Constants;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    /// <summary>
    /// Wrapper host: fila Azure com nome de produto.
    /// </summary>
    public static class ServicesDomainQueue
    {
        public static void AddDependencies(IServiceCollection services)
            => services.AddCoreStorageQueue(StorageQueueNameConstants.GeneralQueue);
    }
}

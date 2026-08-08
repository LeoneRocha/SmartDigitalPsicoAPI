using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Constants;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    /// <summary>
    /// Classe responsável por ServicesDomainQueue.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServicesDomainQueue
    {
        /// <summary>
        /// Método AddDependencies: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddDependencies(IServiceCollection services)
        {
            services.AddTransient<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueRepositoryFactory, SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageQueueRepositoryFactory>();
            services.AddScoped<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueContract>(provider =>
            {
                var serviceFactory = provider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueRepositoryFactory>();
                return new SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageQueueService(serviceFactory, StorageQueueNameConstants.GeneralQueue);
            });
        }
    }
}

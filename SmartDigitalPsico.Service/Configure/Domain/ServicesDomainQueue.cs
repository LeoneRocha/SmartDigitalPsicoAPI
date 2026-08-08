using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Service.Infrastructure;

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
            services.AddTransient<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueRepositoryFactory, SmartDigitalPsicoAPI.Core.SDK.Service.Infrastructure.StorageQueueRepositoryFactory>();
            services.AddScoped<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueContract>(provider =>
            {
                var serviceFactory = provider.GetRequiredService<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueRepositoryFactory>();
                return new SmartDigitalPsicoAPI.Core.SDK.Service.Infrastructure.StorageQueueService(serviceFactory, StorageQueueNameConstants.GeneralQueue);
            });
        }
    }
}

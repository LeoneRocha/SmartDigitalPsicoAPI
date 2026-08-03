using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    /// <summary>
    /// Interface (contrato) responsável por IStorageQueueRepositoryFactory.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IStorageQueueRepositoryFactory
    {
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        IStorageQueueContract Create(EStorageAdapterType eStorageAdapterType, string queueName); 
    }
}

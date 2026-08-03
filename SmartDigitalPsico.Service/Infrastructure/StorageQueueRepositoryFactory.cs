using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Data.Repository.Infrastructure;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    /// <summary>
    /// Classe responsável por StorageQueueRepositoryFactory.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class StorageQueueRepositoryFactory : IStorageQueueRepositoryFactory
    {
        private readonly IConfiguration _configuration;
        /// <summary>
        /// Método StorageQueueRepositoryFactory: executa a operação StorageQueueRepositoryFactory.
        /// </summary>
        public StorageQueueRepositoryFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public IStorageQueueContract Create(EStorageAdapterType eStorageAdapterType, string queueName)
        {
            //Add logic Factory
            var azureStorageQueueAdapter = new AzureStorageQueueAdapter(_configuration, queueName);

            return new GenericStorageQueueRepository(azureStorageQueueAdapter, queueName);
        }
    }
}

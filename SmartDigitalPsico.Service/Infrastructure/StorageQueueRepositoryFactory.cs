using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Data.Repository.Infrastructure;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    public class StorageQueueRepositoryFactory : IStorageQueueRepositoryFactory
    {
        private readonly IConfiguration _configuration;
        public StorageQueueRepositoryFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IStorageQueueContract Create(EStorageAdapterType eStorageAdapterType, string queueName)
        {
            //Add logic Factory
            var azureStorageQueueAdapter = new AzureStorageQueueAdapter(_configuration, queueName);

            return new GenericStorageQueueRepository(azureStorageQueueAdapter, queueName);
        }
    }
}

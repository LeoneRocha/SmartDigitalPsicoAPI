using Azure.Data.Tables;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Data.TableEntityRepository;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsico.Service.Infrastructure
{
    public class StorageTableRepositoryFactory : IStorageTableRepositoryFactory
    {
        private readonly IConfiguration _configuration;
        public StorageTableRepositoryFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IStorageTableEntityRepository<T> Create<T>(EStorageAdapterType eStorageAdapterType, string tableName) where T : BaseEntityTable, new()
        { 
            //Add logic Factory
            var azureStorageTableAdapter = new AzureStorageTableAdapter<T>(_configuration, tableName);
            return new GenericTableEntityRepository<T>(azureStorageTableAdapter, tableName); 
        }
    }
}

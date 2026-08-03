using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Data.TableEntityRepository;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsico.Service.Infrastructure
{
    /// <summary>
    /// Classe responsável por StorageTableRepositoryFactory.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class StorageTableRepositoryFactory : IStorageTableRepositoryFactory 
    {
        private readonly IConfiguration _configuration;
        /// <summary>
        /// Método StorageTableRepositoryFactory: executa a operação StorageTableRepositoryFactory.
        /// </summary>
        public StorageTableRepositoryFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IStorageTableContract<T> Create<T>(EStorageAdapterType eStorageAdapterType, string tableName) where T : BaseEntityTable, new()
        {
            //Add logic Factory
            var azureStorageTableAdapter = new AzureStorageTableAdapter<T>(_configuration, tableName);
            return new GenericTableEntityRepository<T>(azureStorageTableAdapter, tableName);
        }
    }
}

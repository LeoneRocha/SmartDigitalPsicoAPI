using Microsoft.Extensions.Configuration;
using SmartDigitalPsicoAPI.Core.SDK.Data.TableEntityRepository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsicoAPI.Core.SDK.Domain.TableEntityNoSQL;
using SmartDigitalPsicoAPI.Core.SDK.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsicoAPI.Core.SDK.Service.Infrastructure
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

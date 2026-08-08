using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure
{
    /// <summary>
    /// Classe responsável por StorageTableEntityService.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class StorageTableEntityService<T> : IStorageTableContract<T> where T : BaseEntityTable, new()
    {
        private readonly IStorageTableContract<T> _storageTableEntityRepository;

        /// <summary>
        /// Método StorageTableEntityService: executa a operação StorageTableEntityService.
        /// </summary>
        public StorageTableEntityService(IStorageTableRepositoryFactory storageTableRepositoryFactory, string tableName)
        {
            EStorageAdapterType _storageAdapterType = EStorageAdapterType.Azure;
            _storageTableEntityRepository = storageTableRepositoryFactory.Create<T>(_storageAdapterType, tableName);
        }

        /// <summary>
        /// Método DeleteAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task DeleteAsync(string partitionKey, string rowKey)
        {
            await _storageTableEntityRepository.DeleteAsync(partitionKey, rowKey);
        }

        /// <summary>
        /// Método GetByIdAsync: consulta e retorna dados.
        /// </summary>
        public async Task<T> GetByIdAsync(string partitionKey, string rowKey)
        {
            return await _storageTableEntityRepository.GetByIdAsync(partitionKey, rowKey);
        }

        /// <summary>
        /// Método InsertAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task InsertAsync(T entity)
        {
            await _storageTableEntityRepository.InsertAsync(entity);
        }

        /// <summary>
        /// Método UpdateAsync: atualiza um registro/recurso existente.
        /// </summary>
        public async Task UpdateAsync(T entity)
        {
            await _storageTableEntityRepository.UpdateAsync(entity);
        }

        /// <summary>
        /// Método GetAllAsync: consulta e retorna dados.
        /// </summary>
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _storageTableEntityRepository.GetAllAsync();
        }
    }
}

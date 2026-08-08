using SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Core.SDK.Data.TableEntityRepository
{
    /// <summary>
    /// Classe responsável por GenericTableEntityRepository.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class GenericTableEntityRepository<T> : IStorageTableContract<T> where T : BaseEntityTable, new()
    {
        private readonly IStorageTableContract<T> _tableStorageAdapter;

        /// <summary>
        /// Método GenericTableEntityRepository: executa a operação GenericTableEntityRepository.
        /// </summary>
        public GenericTableEntityRepository(IStorageTableContract<T> tableStorageAdapter, string tableName)
        {
            _tableStorageAdapter = tableStorageAdapter;
        }

        /// <summary>
        /// Método GetAllAsync: consulta e retorna dados.
        /// </summary>
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _tableStorageAdapter.GetAllAsync();
        }

        /// <summary>
        /// Método GetByIdAsync: consulta e retorna dados.
        /// </summary>
        public virtual async Task<T> GetByIdAsync(string partitionKey, string rowKey)
        {
            return await _tableStorageAdapter.GetByIdAsync(partitionKey, rowKey);
        }

        /// <summary>
        /// Método InsertAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        public virtual async Task InsertAsync(T entity)
        {
            await _tableStorageAdapter.InsertAsync(entity);
        }

        /// <summary>
        /// Método UpdateAsync: atualiza um registro/recurso existente.
        /// </summary>
        public virtual async Task UpdateAsync(T entity)
        {
            var existingEntity = await _tableStorageAdapter.GetByIdAsync(entity.PartitionKey, entity.RowKey);
            if (string.IsNullOrEmpty(existingEntity.RowKey))
            {
                await _tableStorageAdapter.InsertAsync(entity);
            }
            else
            {
                await _tableStorageAdapter.UpdateAsync(entity);
            }
        }

        /// <summary>
        /// Método DeleteAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public virtual async Task DeleteAsync(string partitionKey, string rowKey)
        {
            await _tableStorageAdapter.DeleteAsync(partitionKey, rowKey);
        }
    }
}

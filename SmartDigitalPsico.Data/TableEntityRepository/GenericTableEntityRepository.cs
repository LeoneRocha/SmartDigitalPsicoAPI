using Azure.Data.Tables;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Data.TableEntityRepository
{
    public class GenericTableEntityRepository<T> : IStorageTableContract<T> where T : BaseEntityTable, new()
    {
        private readonly IStorageTableContract<T> _tableStorageAdapter;

        public GenericTableEntityRepository(IStorageTableContract<T> tableStorageAdapter, string tableName)
        {
            _tableStorageAdapter = tableStorageAdapter;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _tableStorageAdapter.GetAllAsync();
        }

        public virtual async Task<T> GetByIdAsync(string partitionKey, string rowKey)
        {
            return await _tableStorageAdapter.GetByIdAsync(partitionKey, rowKey);
        }

        public virtual async Task InsertAsync(T entity)
        {
            await _tableStorageAdapter.InsertAsync(entity);
        }

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

        public virtual async Task DeleteAsync(string partitionKey, string rowKey)
        {
            await _tableStorageAdapter.DeleteAsync(partitionKey, rowKey);
        }
    }
}
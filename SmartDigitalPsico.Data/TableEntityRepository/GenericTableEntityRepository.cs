using Azure.Data.Tables;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;

namespace SmartDigitalPsico.Data.TableEntityRepository
{
    public abstract class GenericTableEntityRepository<T> : ITableEntityRepository<T> where T : class, ITableEntity, new()
    {
        private readonly IStorageTableAdapter<T> _tableStorageAdapter;

        public GenericTableEntityRepository(IStorageTableServiceFactory tableStorageServiceFactory, string tableName)
        {
            _tableStorageAdapter = tableStorageServiceFactory.Create<T>(tableName);
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
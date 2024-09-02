using Azure.Data.Tables;

namespace SmartDigitalPsico.Domain.Interfaces.TableEntity
{
    public interface ITableEntityRepository<T> where T : class, ITableEntity, new()
    { 

        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(string partitionKey, string rowKey);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(string partitionKey, string rowKey);
    }
}

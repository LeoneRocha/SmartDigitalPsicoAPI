using Azure.Data.Tables;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Domain.Interfaces.TableEntity
{
    public interface IStorageTableAdapter<T> where T : BaseEntityTable, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(string partitionKey, string rowKey);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(string partitionKey, string rowKey);
    }
}

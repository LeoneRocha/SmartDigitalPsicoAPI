namespace SmartDigitalPsico.Domain.Interfaces.TableEntity
{
    public interface IStorageTableService<T> where T : class , new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(string partitionKey, string rowKey);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(string partitionKey, string rowKey);
    }
}

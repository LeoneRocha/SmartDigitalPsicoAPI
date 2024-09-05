using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Service.Infrastructure
{
    public class StorageTableEntityService<T> : IStorageTableService<T> where T : BaseEntityTable, new()
    {
        private readonly IStorageTableRepositoryFactory _storageTableAdapterFactory; 
        private readonly EStorageAdapterType _storageAdapterType;

        private readonly IStorageTableEntityRepository<T>  _storageTableEntityRepository;

        public StorageTableEntityService(IStorageTableRepositoryFactory serviceFactory, string tableName)
        {
            _storageTableAdapterFactory = serviceFactory;
            _storageAdapterType = EStorageAdapterType.Azure;
            _storageTableEntityRepository = _storageTableAdapterFactory.Create<T>(_storageAdapterType, tableName); 
        }

        public async Task DeleteAsync(string partitionKey, string rowKey)
        {
            await _storageTableEntityRepository.DeleteAsync(partitionKey, rowKey);
        }

        public async Task<T> GetByIdAsync(string partitionKey, string rowKey)
        {
            return await _storageTableEntityRepository.GetByIdAsync(partitionKey, rowKey);
        }

        public async Task InsertAsync(T entity)
        {
            await _storageTableEntityRepository.InsertAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await _storageTableEntityRepository.UpdateAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _storageTableEntityRepository.GetAllAsync();
        }
    }
}

using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure;

/// <summary>
/// Casca StorageTableEntityService — espelho SCH com factory SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Infrastructure.StorageTableEntityService`1",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca espelhando StorageTableEntityService; factory SDP na assinatura pública.")]
public class StorageTableEntityService<T> : IStorageTableContract<T>
    where T : BaseEntityTable, new()
{
    private readonly IStorageTableContract<T> _storageTableEntityRepository;

    public StorageTableEntityService(IStorageTableRepositoryFactory storageTableRepositoryFactory, string tableName)
    {
        EStorageAdapterType storageAdapterType = EStorageAdapterType.Azure;
        _storageTableEntityRepository = storageTableRepositoryFactory.Create<T>(storageAdapterType, tableName);
    }

    public async Task DeleteAsync(string partitionKey, string rowKey)
        => await _storageTableEntityRepository.DeleteAsync(partitionKey, rowKey);

    public async Task<T> GetByIdAsync(string partitionKey, string rowKey)
        => await _storageTableEntityRepository.GetByIdAsync(partitionKey, rowKey);

    public async Task InsertAsync(T entity)
        => await _storageTableEntityRepository.InsertAsync(entity);

    public async Task UpdateAsync(T entity)
        => await _storageTableEntityRepository.UpdateAsync(entity);

    public async Task<IEnumerable<T>> GetAllAsync()
        => await _storageTableEntityRepository.GetAllAsync();
}

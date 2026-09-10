using Microsoft.Extensions.Configuration;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Data.TableEntityRepository;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure;

/// <summary>
/// Casca StorageTableRepositoryFactory — espelho SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Infrastructure.StorageTableRepositoryFactory",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca espelhando StorageTableRepositoryFactory do SCH.")]
public class StorageTableRepositoryFactory : IStorageTableRepositoryFactory
{
    private readonly IConfiguration _configuration;

    public StorageTableRepositoryFactory(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IStorageTableContract<T> Create<T>(EStorageAdapterType eStorageAdapterType, string tableName)
        where T : BaseEntityTable, new()
    {
        _ = eStorageAdapterType;
        var azureStorageTableAdapter = new AzureStorageTableAdapter<T>(_configuration, tableName);
        return new GenericTableEntityRepository<T>(azureStorageTableAdapter, tableName);
    }
}

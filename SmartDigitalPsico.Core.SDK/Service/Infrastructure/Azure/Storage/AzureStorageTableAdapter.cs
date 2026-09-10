using Azure.Data.Tables;
using Microsoft.Extensions.Configuration;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage;

/// <summary>
/// Casca AzureStorageTableAdapter — herda SCH (KeepBoth vs Cloud adapters).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageTableAdapter`1",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando AzureStorageTableAdapter do SCH.")]
public class AzureStorageTableAdapter<T>
    : SmartCoreHub.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageTableAdapter<T>,
      IStorageTableContract<T>
    where T : BaseEntityTable, new()
{
    public AzureStorageTableAdapter(IConfiguration configuration, string tableName)
        : base(configuration, tableName)
    {
    }

    public AzureStorageTableAdapter(TableClient tableClient) : base(tableClient)
    {
    }
}

using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage;

/// <summary>
/// Casca AzureStorageBlobAdapter — herda SCH (KeepBoth vs Cloud adapters).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando AzureStorageBlobAdapter do SCH.")]
public class AzureStorageBlobAdapter
    : SmartCoreHub.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter,
      IStorageBlobAdapter
{
    public AzureStorageBlobAdapter(IConfiguration configuration) : base(configuration)
    {
    }

    public AzureStorageBlobAdapter(IConfiguration configuration, BlobServiceClient blobServiceClient)
        : base(configuration, blobServiceClient)
    {
    }
}

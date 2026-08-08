using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;

namespace SmartDigitalPsico.Service.Infrastructure.Azure.Storage
{
    /// <summary>
    /// Classe responsável por AzureStorageBlobAdapter.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_AZURE")]
    public class AzureStorageBlobAdapter : SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter, SmartDigitalPsico.Domain.Interfaces.Infrastructure.IStorageBlobAdapter
    {
        public AzureStorageBlobAdapter(IConfiguration configuration) : base(configuration) { }

        public AzureStorageBlobAdapter(IConfiguration configuration, BlobServiceClient blobServiceClient) : base(configuration, blobServiceClient) { }
    }
}

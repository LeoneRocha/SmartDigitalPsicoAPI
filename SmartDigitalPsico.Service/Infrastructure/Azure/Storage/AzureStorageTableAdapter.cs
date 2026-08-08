using Azure.Data.Tables;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Service.Infrastructure.Azure.Storage
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_AZURE")]
    public class AzureStorageTableAdapter<T> : SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageTableAdapter<T>
        where T : BaseEntityTable, new()
    {
        public AzureStorageTableAdapter(IConfiguration configuration, string tableName) : base(configuration, tableName) { }

        public AzureStorageTableAdapter(TableClient tableClient) : base(tableClient) { }
    }
}

using Azure.Data.Tables;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsicoAPI.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Service.Infrastructure.Azure.Storage
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsicoAPI.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsicoAPI.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_AZURE")]
    public class AzureStorageTableAdapter<T> : SmartDigitalPsicoAPI.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageTableAdapter<T>
        where T : BaseEntityTable, new()
    {
        public AzureStorageTableAdapter(IConfiguration configuration, string tableName) : base(configuration, tableName) { }

        public AzureStorageTableAdapter(TableClient tableClient) : base(tableClient) { }
    }
}

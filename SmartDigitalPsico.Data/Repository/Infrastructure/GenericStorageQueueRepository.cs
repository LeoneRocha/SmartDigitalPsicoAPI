using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.Data.Repository.Infrastructure
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsicoAPI.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsicoAPI.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public class GenericStorageQueueRepository : SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Infrastructure.GenericStorageQueueRepository
    {
        public GenericStorageQueueRepository(IStorageQueueContract storageQueueAdapter, string tableName)
            : base(storageQueueAdapter, tableName)
        {
        }
    }
}

using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.Data.Repository.Infrastructure
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public class GenericStorageQueueRepository : SmartDigitalPsico.Core.SDK.Data.Repository.Infrastructure.GenericStorageQueueRepository
    {
        public GenericStorageQueueRepository(IStorageQueueContract storageQueueAdapter, string tableName)
            : base(storageQueueAdapter, tableName)
        {
        }
    }
}

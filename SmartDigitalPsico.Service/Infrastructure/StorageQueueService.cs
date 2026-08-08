using SmartDigitalPsico.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.Service.Infrastructure
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public class StorageQueueService : SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageQueueService, IStorageQueueContract
    {
        public StorageQueueService(IStorageQueueRepositoryFactory storageQueueRepositoryFactory, string queueName)
            : base(storageQueueRepositoryFactory, queueName) { }
    }
}

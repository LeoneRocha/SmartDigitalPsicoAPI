using Microsoft.Extensions.Configuration;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// Namespace histórico mantido por compatibilidade.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public class StorageQueueRepositoryFactory : SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageQueueRepositoryFactory
    {
        public StorageQueueRepositoryFactory(IConfiguration configuration) : base(configuration) { }
    }
}

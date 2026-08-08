using Microsoft.Extensions.Configuration;

namespace SmartDigitalPsico.Service.Infrastructure
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public class StorageTableRepositoryFactory : SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageTableRepositoryFactory
    {
        public StorageTableRepositoryFactory(IConfiguration configuration) : base(configuration) { }
    }
}

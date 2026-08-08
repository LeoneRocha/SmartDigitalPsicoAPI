using Microsoft.Extensions.Configuration;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Service.Infrastructure
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsicoAPI.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsicoAPI.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public class StorageTableRepositoryFactory : SmartDigitalPsicoAPI.Core.SDK.Service.Infrastructure.StorageTableRepositoryFactory
    {
        public StorageTableRepositoryFactory(IConfiguration configuration) : base(configuration) { }
    }
}

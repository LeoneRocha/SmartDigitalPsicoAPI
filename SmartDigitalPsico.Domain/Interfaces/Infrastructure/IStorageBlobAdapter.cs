using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    /// <summary>
    /// Interface (contrato) responsável por IStorageBlobAdapter.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IStorageBlobAdapter : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter
    {
    }
}

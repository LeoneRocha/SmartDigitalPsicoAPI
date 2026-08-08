using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Security
{
    /// <summary>
    /// Interface (contrato) responsável por ICryptoAdapterFactory.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface ICryptoAdapterFactory
    {
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        ICryptoAdpter Create(SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.ECryptoServiceType cryptoServiceType, string key, string ivOrPublicKey);
    }
}

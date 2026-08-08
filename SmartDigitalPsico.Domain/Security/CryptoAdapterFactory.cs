using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Domain.Security
{
    /// <summary>
    /// Classe responsável por CryptoAdapterFactory.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class CryptoAdapterFactory : ICryptoAdapterFactory
    {
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public ICryptoAdpter Create(SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.ECryptoServiceType cryptoServiceType, string key, string ivOrPublicKey)
        {
            switch (cryptoServiceType)
            {
                case SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.ECryptoServiceType.Aes:
                    return new AesCryptoAdpter(key, ivOrPublicKey);
                case SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.ECryptoServiceType.Rsa:
                    return new RsaCryptoAdpter(ivOrPublicKey, key);
                default:
                    throw new ArgumentException("Invalid crypto service type", nameof(cryptoServiceType));
            }
        }
    }
}

using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Security
{
    /// <summary>
    /// Interface (contrato) responsável por ICryptoAdapterFactory.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface ICryptoAdapterFactory
    {
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        ICryptoAdpter Create(ECryptoServiceType cryptoServiceType, string key, string ivOrPublicKey);
    }
}

namespace SmartDigitalPsico.Domain.Interfaces.Security
{
    /// <summary>
    /// Interface (contrato) responsável por ICryptoService.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface ICryptoService : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Security.ICryptoService
    {
        /// <summary>
        /// Método Encrypt: executa a operação Encrypt.
        /// </summary>
        string Encrypt(string plainText);
        /// <summary>
        /// Método Encrypt: executa a operação Encrypt.
        /// </summary>
        string Encrypt(string keyBase64, string plainText);
        /// <summary>
        /// Método Decrypt: executa a operação Decrypt.
        /// </summary>
        string Decrypt(string cipherTextBase64); 
        /// <summary>
        /// Método Decrypt: executa a operação Decrypt.
        /// </summary>
        string Decrypt(string keyBase64, string cipherTextBase64);
    }
}

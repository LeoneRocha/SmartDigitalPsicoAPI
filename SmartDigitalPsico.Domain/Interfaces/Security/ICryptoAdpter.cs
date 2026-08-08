namespace SmartDigitalPsico.Domain.Interfaces.Security
{
    /// <summary>
    /// Interface (contrato) responsável por ICryptoAdpter.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface ICryptoAdpter
    {
        /// <summary>
        /// Método Encrypt: executa a operação Encrypt.
        /// </summary>
        byte[] Encrypt(string plainText);
        /// <summary>
        /// Método Decrypt: executa a operação Decrypt.
        /// </summary>
        string Decrypt(byte[] cipherText);
    }
}

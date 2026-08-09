namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security
{
    /// <summary>
    /// Interface (contrato) responsável por ICryptoService.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface ICryptoService
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

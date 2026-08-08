namespace SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Security
{
    /// <summary>
    /// Interface (contrato) responsável por ICryptoAdpter.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
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

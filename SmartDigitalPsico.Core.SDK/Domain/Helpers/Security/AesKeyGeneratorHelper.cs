using System.Security.Cryptography;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers.Security
{
    /// <summary>
    /// Classe responsável por AesKeyGeneratorHelper.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class AesKeyGeneratorHelper
    {

        /// <summary>
        /// Método GenerateKey: executa a operação GenerateKey.
        /// </summary>
        public static string GenerateKey()
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] key = new byte[32]; // 256 bits para AES-256
                rng.GetBytes(key);
                return Convert.ToBase64String(key);
            }
        }

        /// <summary>
        /// Método GenerateIV: executa a operação GenerateIV.
        /// </summary>
        public static string GenerateIV()
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] iv = new byte[16]; // 128 bits para o IV do AES
                rng.GetBytes(iv);
                return Convert.ToBase64String(iv);
            }
        }
    }
}

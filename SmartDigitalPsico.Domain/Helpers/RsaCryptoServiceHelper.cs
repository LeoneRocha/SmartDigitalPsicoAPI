using SmartDigitalPsico.Domain.DTO.Security;
using System.Security.Cryptography;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por RsaCryptoServiceHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public static class RsaCryptoServiceHelper
    {
        /// <summary>
        /// Método GenerateKeys: executa a operação GenerateKeys.
        /// </summary>
        public static RsaCryptoDto GenerateKeys(RSAEncryptionPadding rsaSize)
        {
            using (var rsa = RSA.Create())
            {
                // Exportando as chaves
                var publicKey = rsa.ExportParameters(false);
                var privateKey = rsa.ExportParameters(true);
                  
                // Retornando o objeto com as chaves
                return new RsaCryptoDto
                {
                    PrivateKey = privateKey,
                    PrivateKeyBase64 = ConvertToBase64(privateKey),
                    PublicKey = publicKey,
                    PublicKeyBase64 = ConvertToBase64(publicKey),
                };
            }
        }

        /// <summary>
        /// Método ConvertToBase64: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static string ConvertToBase64(RSAParameters rsaParameters)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                using (var writer = new System.IO.BinaryWriter(ms))
                {
                    writer.Write(rsaParameters.Modulus ?? []);
                    writer.Write(rsaParameters.Exponent ?? []);
                }
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        /// <summary>
        /// Método ConvertFromBase64: mapeia ou transforma dados entre modelos.
        /// </summary>
        public static RSAParameters ConvertFromBase64(string base64String, RSAEncryptionPadding rsaSize)
        {
            var bytes = Convert.FromBase64String(base64String);
            using (var ms = new System.IO.MemoryStream(bytes))
            {
                using (var reader = new System.IO.BinaryReader(ms))
                {
                    var rsaParameters = new RSAParameters
                    {
                        Modulus = reader.ReadBytes(getSizeRSA(rsaSize)), // Tamanho típico do módulo RSA
                        Exponent = reader.ReadBytes(3)   // Tamanho típico do expoente RSA
                    };
                    return rsaParameters;
                }
            }
        }

        private static int getSizeRSA(RSAEncryptionPadding rsaSize)
        {
            if (rsaSize == RSAEncryptionPadding.OaepSHA3_256)
            {
                return 256;
            }
            return 256;
        }
    }
}

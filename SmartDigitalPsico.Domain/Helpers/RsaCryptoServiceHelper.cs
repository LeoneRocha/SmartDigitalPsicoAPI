using SmartDigitalPsico.Domain.VO.Security;
using System.Security.Cryptography;

namespace SmartDigitalPsico.Domain.Helpers
{
    public static class RsaCryptoServiceHelper
    {
        public static RsaCryptoVO GenerateKeys(RSAEncryptionPadding rsaSize)
        {
            using (var rsa = RSA.Create())
            {
                // Exportando as chaves
                var publicKey = rsa.ExportParameters(false);
                var privateKey = rsa.ExportParameters(true);
                  
                // Retornando o objeto com as chaves
                return new RsaCryptoVO
                {
                    PrivateKey = privateKey,
                    PrivateKeyBase64 = ConvertToBase64(privateKey),
                    PublicKey = publicKey,
                    PublicKeyBase64 = ConvertToBase64(publicKey),
                };
            }
        }

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

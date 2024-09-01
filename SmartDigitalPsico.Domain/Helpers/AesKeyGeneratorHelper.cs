using System.Security.Cryptography;

namespace SmartDigitalPsico.Domain.Helpers
{
    public static class AesKeyGenerator
    {

        public static string GenerateKey()
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] key = new byte[32]; // 256 bits para AES-256
                rng.GetBytes(key);
                return Convert.ToBase64String(key);
            }
        }

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

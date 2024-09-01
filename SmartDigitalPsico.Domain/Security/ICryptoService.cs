using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Security
{
    public interface ICryptoService
    {
        string Decrypt(byte[] cipherText, ECryptoServiceType cryptoServiceType, string key, string ivOrPublicKey);
        byte[] Encrypt(string plainText, ECryptoServiceType cryptoServiceType, string key, string ivOrPublicKey);
    }
}
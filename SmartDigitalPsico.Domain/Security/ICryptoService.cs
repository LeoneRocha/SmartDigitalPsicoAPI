using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Security
{
    public interface ICryptoService
    {
        string Decrypt(byte[] cipherText);
        byte[] Encrypt(string plainText);
    }
}
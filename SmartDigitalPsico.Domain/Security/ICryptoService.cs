using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Security
{
    public interface ICryptoService
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherTextBase64);
    }
}
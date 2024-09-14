namespace SmartDigitalPsico.Domain.Interfaces.Security
{
    public interface ICryptoService
    {
        string Encrypt(string plainText);
        string Encrypt(string keyBase64, string plainText);
        string Decrypt(string cipherTextBase64); 
        string Decrypt(string keyBase64, string cipherTextBase64);
    }
}
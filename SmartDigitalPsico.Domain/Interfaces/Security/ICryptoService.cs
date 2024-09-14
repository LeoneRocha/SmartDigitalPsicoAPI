namespace SmartDigitalPsico.Domain.Interfaces.Security
{
    public interface ICryptoService
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherTextBase64); 
        string Encrypt(string ivOrPublicKeyBase64, string plainText);
        string Decrypt(string ivOrPublicKeyBase64, string cipherTextBase64);
    }
}
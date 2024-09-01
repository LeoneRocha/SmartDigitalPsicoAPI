namespace SmartDigitalPsico.Domain.Interfaces.Security
{
    public interface ICryptoAdpter
    {
        byte[] Encrypt(string plainText);
        string Decrypt(byte[] cipherText);
    }
}

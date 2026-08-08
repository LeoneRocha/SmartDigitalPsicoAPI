using System.Security.Cryptography;
using Microsoft.Extensions.Configuration;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Core.SDK.Domain.Helpers.Security;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;
using SmartDigitalPsico.Core.SDK.Domain.Security;

namespace SmartDigitalPsico.Core.SDK.Tests.Domain.Security;

[TestFixture]
public class CryptoCoverageTests
{
    [Test]
    public void AesCryptoAdapter_ValidAndInvalidText_ReturnsExpectedResult()
    {
        var adapter = new AesCryptoAdpter(AesKeyGeneratorHelper.GenerateKey(), AesKeyGeneratorHelper.GenerateIV());
        var encrypted = adapter.Encrypt("confidential");
        var decrypted = adapter.Decrypt(encrypted);
        var invalid = adapter.Decrypt([1, 2, 3]);

        using (Assert.EnterMultipleScope())
        {
            encrypted.Should().NotBeEmpty();
            decrypted.Should().Be("confidential");
            invalid.Should().BeEmpty();
            ((Action)(() => adapter.Encrypt(""))).Should().Throw<ArgumentException>();
            ((Action)(() => adapter.Decrypt([]))).Should().Throw<ArgumentException>();
        }
    }

    [Test]
    public void AesCryptoAdapter_ConstructorInputs_InitializesOrThrows()
    {
        var key = AesKeyGeneratorHelper.GenerateKey();
        var iv = AesKeyGeneratorHelper.GenerateIV();
        var binaryKey = Convert.FromBase64String(key);
        var binaryIv = Convert.FromBase64String(iv);

        var base64Adapter = new AesCryptoAdpter(key, iv);
        base64Adapter.Decrypt(base64Adapter.Encrypt("base64")).Should().Be("base64");

        Action nullKey = () => _ = new AesCryptoAdpter(null!, binaryIv);
        Action nullIv = () => _ = new AesCryptoAdpter(binaryKey, null!);
        nullKey.Should().Throw<ArgumentNullException>();
        nullIv.Should().Throw<ArgumentNullException>();
    }

    [Test]
    public void RsaCryptoAdapter_GeneratedKeys_RoundTripsText()
    {
        var keys = RsaCryptoServiceHelper.GenerateKeys(RSAEncryptionPadding.OaepSHA256);
        var adapter = new RsaCryptoAdpter(keys.PublicKey, keys.PrivateKey);
        var encrypted = adapter.Encrypt("rsa text");
        var decrypted = adapter.Decrypt(encrypted);
        var converted = RsaCryptoServiceHelper.ConvertFromBase64(keys.PublicKeyBase64, RSAEncryptionPadding.OaepSHA256);

        using (Assert.EnterMultipleScope())
        {
            decrypted.Should().Be("rsa text");
            converted.Modulus.Should().BeEquivalentTo(keys.PublicKey.Modulus);
            ((Action)(() => adapter.Encrypt(""))).Should().Throw<ArgumentException>();
            ((Action)(() => adapter.Decrypt([]))).Should().Throw<ArgumentException>();
        }

        _ = new RsaCryptoAdpter(keys.PublicKeyBase64, keys.PrivateKeyBase64);
        RsaCryptoServiceHelper.ConvertToBase64(keys.PublicKey).Should().NotBeNullOrWhiteSpace();
        RsaCryptoServiceHelper.ConvertFromBase64(
            RsaCryptoServiceHelper.ConvertToBase64(new RSAParameters { Modulus = new byte[256], Exponent = [1, 0, 1] }),
            RSAEncryptionPadding.OaepSHA3_256).Modulus.Should().HaveCount(256);
    }

    [Test]
    public void CryptoAdapterFactory_ServiceType_ReturnsAdapterOrThrows()
    {
        var factory = new CryptoAdapterFactory();
        var aesKey = AesKeyGeneratorHelper.GenerateKey();
        var aesIv = AesKeyGeneratorHelper.GenerateIV();
        var rsa = RsaCryptoServiceHelper.GenerateKeys(RSAEncryptionPadding.OaepSHA256);

        var aes = factory.Create(ECryptoServiceType.Aes, aesKey, aesIv);
        var rsaAdapter = factory.Create(ECryptoServiceType.Rsa, rsa.PrivateKeyBase64, rsa.PublicKeyBase64);

        using (Assert.EnterMultipleScope())
        {
            aes.Should().BeOfType<AesCryptoAdpter>();
            rsaAdapter.Should().BeOfType<RsaCryptoAdpter>();
            ((Action)(() => factory.Create((ECryptoServiceType)99, "", ""))).Should().Throw<ArgumentException>();
        }
    }

    [Test]
    public void CryptoService_EncryptDecryptAndInvalidCipher_DelegatesToAdapter()
    {
        var encryptedBytes = new byte[] { 1, 2, 3 };
        var adapter = new Mock<ICryptoAdpter>();
        adapter.Setup(x => x.Encrypt("plain")).Returns(encryptedBytes);
        adapter.Setup(x => x.Decrypt(encryptedBytes)).Returns("plain");
        var factory = new Mock<ICryptoAdapterFactory>();
        factory.Setup(x => x.Create(ECryptoServiceType.Aes, It.IsAny<string>(), "iv")).Returns(adapter.Object);
        var configuration = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>
        {
            ["SecuritySettings:AesSettings:AesKey"] = "key",
            ["SecuritySettings:AesSettings:AesIv"] = "iv"
        }).Build();
        var service = new CryptoService(configuration, factory.Object);

        var encryptedFromConfiguredKey = service.Encrypt("plain");
        var encryptedFromProvidedKey = service.Encrypt("override-key", "plain");
        var decrypted = service.Decrypt(encryptedFromConfiguredKey);
        var decryptedWithKey = service.Decrypt("override-key", encryptedFromConfiguredKey);
        var invalid = service.Decrypt("not base64!");
        var blank = service.Decrypt("   ");

        using (Assert.EnterMultipleScope())
        {
            encryptedFromConfiguredKey.Should().Be(Convert.ToBase64String(encryptedBytes));
            encryptedFromProvidedKey.Should().Be(Convert.ToBase64String(encryptedBytes));
            decrypted.Should().Be("plain");
            decryptedWithKey.Should().Be("plain");
            invalid.Should().BeEmpty();
            blank.Should().BeEmpty();
        }
        factory.Verify(x => x.Create(ECryptoServiceType.Aes, "key", "iv"), Times.Exactly(2));
        factory.Verify(x => x.Create(ECryptoServiceType.Aes, "override-key", "iv"), Times.Exactly(2));
    }
}

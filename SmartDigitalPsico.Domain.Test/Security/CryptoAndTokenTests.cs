using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using SmartDigitalPsico.Domain.DTO.Security;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Security;
using SmartDigitalPsico.Core.SDK.Domain.Helpers.Security;
using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Domain.Test.Security;

[TestFixture]
public class CryptoAndTokenTests
{
    private const string Secret = "0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef";

    // Cenário: Dados são criptografados e descriptografados por AES.
    // Objetivo: Preservar o texto e tratar entradas inválidas.
    [Test]
    public void AesCryptoAdapter_ValidAndInvalidText_ReturnsExpectedResult()
    {
        // Arrange
        var adapter = new SmartDigitalPsico.Core.SDK.Domain.Security.AesCryptoAdpter(SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateKey(), SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateIV());
        // Act
        var encrypted = adapter.Encrypt("confidential");
        var decrypted = adapter.Decrypt(encrypted);
        var invalid = adapter.Decrypt([1, 2, 3]);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            encrypted.Should().NotBeEmpty();
            decrypted.Should().Be("confidential");
            invalid.Should().BeEmpty();
            ((Action)(() => adapter.Encrypt(""))).Should().Throw<ArgumentException>();
            ((Action)(() => adapter.Decrypt([]))).Should().Throw<ArgumentException>();
        }
    }

    // Cenário: o adaptador AES recebe chaves binárias e Base64, incluindo argumentos nulos.
    // Objetivo: inicializar as duas sobrecargas e rejeitar chaves obrigatórias ausentes.
    [Test]
    public void AesCryptoAdapter_ConstructorInputs_InitializesOrThrows()
    {
        // Arrange
        var key = SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateKey();
        var iv = SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateIV();
        var binaryKey = Convert.FromBase64String(key);
        var binaryIv = Convert.FromBase64String(iv);

        // Act
        var base64Adapter = new SmartDigitalPsico.Core.SDK.Domain.Security.AesCryptoAdpter(key, iv);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            base64Adapter.Decrypt(base64Adapter.Encrypt("base64")).Should().Be("base64");
            Action nullKey = () => _ = new SmartDigitalPsico.Core.SDK.Domain.Security.AesCryptoAdpter(null!, binaryIv);
            Action nullIv = () => _ = new SmartDigitalPsico.Core.SDK.Domain.Security.AesCryptoAdpter(binaryKey, null!);
            nullKey.Should().Throw<ArgumentNullException>();
            nullIv.Should().Throw<ArgumentNullException>();
        }
    }

    // Cenário: Chaves RSA geradas são usadas em criptografia assimétrica.
    // Objetivo: Recuperar o texto e validar entradas vazias.
    [Test]
    public void RsaCryptoAdapter_GeneratedKeys_RoundTripsText()
    {
        // Arrange
        var keys = SmartDigitalPsico.Core.SDK.Domain.Helpers.RsaCryptoServiceHelper.GenerateKeys(System.Security.Cryptography.RSAEncryptionPadding.OaepSHA256);
        var adapter = new SmartDigitalPsico.Core.SDK.Domain.Security.RsaCryptoAdpter(keys.PublicKey, keys.PrivateKey);
        // Act
        var encrypted = adapter.Encrypt("rsa text");
        var decrypted = adapter.Decrypt(encrypted);
        var converted = SmartDigitalPsico.Core.SDK.Domain.Helpers.RsaCryptoServiceHelper.ConvertFromBase64(keys.PublicKeyBase64, System.Security.Cryptography.RSAEncryptionPadding.OaepSHA256);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            decrypted.Should().Be("rsa text");
            converted.Modulus.Should().BeEquivalentTo(keys.PublicKey.Modulus);
            ((Action)(() => adapter.Encrypt(""))).Should().Throw<ArgumentException>();
            ((Action)(() => adapter.Decrypt([]))).Should().Throw<ArgumentException>();
        }
    }

    // Cenário: A fábrica recebe tipos AES, RSA e tipo inválido.
    // Objetivo: Criar o adaptador correspondente ou rejeitar o tipo.
    [Test]
    public void CryptoAdapterFactory_ServiceType_ReturnsAdapterOrThrows()
    {
        // Arrange
        var factory = new SmartDigitalPsico.Core.SDK.Domain.Security.CryptoAdapterFactory();
        var aesKey = SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateKey();
        var aesIv = SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateIV();
        var rsa = SmartDigitalPsico.Core.SDK.Domain.Helpers.RsaCryptoServiceHelper.GenerateKeys(System.Security.Cryptography.RSAEncryptionPadding.OaepSHA256);
        // Act
        var aes = factory.Create(SmartDigitalPsico.Core.SDK.Domain.Enuns.ECryptoServiceType.Aes, aesKey, aesIv);
        var rsaAdapter = factory.Create(SmartDigitalPsico.Core.SDK.Domain.Enuns.ECryptoServiceType.Rsa, rsa.PrivateKeyBase64, rsa.PublicKeyBase64);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            aes.Should().BeOfType<SmartDigitalPsico.Core.SDK.Domain.Security.AesCryptoAdpter>();
            rsaAdapter.Should().BeOfType<SmartDigitalPsico.Core.SDK.Domain.Security.RsaCryptoAdpter>();
            ((Action)(() => factory.Create((SmartDigitalPsico.Core.SDK.Domain.Enuns.ECryptoServiceType)99, "", ""))).Should().Throw<ArgumentException>();
        }
    }

    // Cenário: Um serviço de token emite acesso e refresh token.
    // Objetivo: Manter claims e recuperar principal de token expirado.
    [Test]
    public void TokenService_ValidConfiguration_GeneratesAndValidatesTokens()
    {
        // Arrange
        var service = new TokenService(new SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto { Secret = Secret, Issuer = "issuer", Audience = "audience", Minutes = 1 });
        var claims = new[] { new Claim(ClaimTypes.NameIdentifier, "123"), new Claim(ClaimTypes.Name, "Ana") };
        // Act
        var token = service.GenerateAccessToken(claims);
        var refresh = service.GenerateRefreshToken();
        var principal = service.GetPrincipalFromExpiredToken(token);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            new JwtSecurityTokenHandler().CanReadToken(token).Should().BeTrue();
            Convert.FromBase64String(refresh).Should().HaveCount(32);
            principal.FindFirstValue(ClaimTypes.NameIdentifier).Should().Be("123");
        }
    }

    // Cenário: token assinado com algoritmo diferente é recebido.
    // Objetivo: rejeitar token que não usa HMAC SHA-512.
    [Test]
    public void GetPrincipalFromExpiredToken_InvalidAlgorithm_ThrowsSecurityTokenException()
    {
        // Arrange
        var configuration = new SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto { Secret = Secret, Issuer = "issuer", Audience = "audience", Minutes = 1 };
        var service = new TokenService(configuration);
        var credentials = new SigningCredentials(new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(Secret)), SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(issuer: configuration.Issuer, audience: configuration.Audience, expires: DateTime.UtcNow.AddMinutes(-1), signingCredentials: credentials);

        // Act
        var action = () => service.GetPrincipalFromExpiredToken(new JwtSecurityTokenHandler().WriteToken(token));

        // Assert
        action.Should().Throw<SecurityTokenException>().WithMessage("Invalid Token");
    }
}

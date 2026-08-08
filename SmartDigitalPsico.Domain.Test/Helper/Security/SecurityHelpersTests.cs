using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers.Security;
using SmartDigitalPsico.Core.SDK.Domain.Helpers.Security;
using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Domain.Test.Helper.Security;

[TestFixture]
public class SecurityHelpersTests
{
    // Cenário: Uma senha é criada e validada com senha correta e incorreta.
    // Objetivo: Garantir hash verificável e rejeição de credencial diferente.
    [Test]
    public void PasswordHash_ValidAndInvalidPassword_ReturnsExpectedValidation()
    {
        // Arrange
        SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreatePasswordHash("secret", out var hash, out var salt);
        // Act
        var valid = SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.VerifyPasswordHash("secret", hash, salt);
        var invalid = SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.VerifyPasswordHash("other", hash, salt);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            hash.Should().HaveCount(64);
            salt.Should().NotBeEmpty();
            valid.Should().BeTrue();
            invalid.Should().BeFalse();
        }
    }

    // Cenário: Valores válidos, inválidos e vazios são verificados como Base64.
    // Objetivo: Reconhecer somente Base64 válido.
    [TestCase("AQID", true)]
    [TestCase("not-base64", false)]
    [TestCase("", false)]
    public void IsBase64String_InputValue_ReturnsExpectedResult(string value, bool expected)
    {
        // Arrange
        // Act
        var result = SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.IsBase64String(value);
        // Assert
        result.Should().Be(expected);
    }

    // Cenário: os dados de segurança de um usuário são convertidos em JWT.
    // Objetivo: preservar as claims de identificação, nome e papel.
    [Test]
    public void CreateToken_ValidSecurityData_ContainsExpectedClaims()
    {
        // Arrange
        var security = new SmartDigitalPsico.Core.SDK.Domain.Security.SecurityDto { Name = "Ana", Role = "Psicóloga", SecurityKeyConfig = new string('a', 64) };
        typeof(SmartDigitalPsico.Core.SDK.Domain.Security.SecurityDto).GetProperty(nameof(SmartDigitalPsico.Core.SDK.Domain.Security.SecurityDto.Id))!.SetValue(security, "42");

        // Act
        var token = SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreateToken(security);
        var jwt = new JwtSecurityTokenHandler().ReadJwtToken(token);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            jwt.Claims.Should().Contain(x => (x.Type == JwtRegisteredClaimNames.NameId || x.Type == ClaimTypes.NameIdentifier) && x.Value == "42");
            jwt.Claims.Should().Contain(x => x.Type == JwtRegisteredClaimNames.UniqueName && x.Value == "Ana");
            jwt.Claims.Should().Contain(x => x.Type == "role" && x.Value == "Psicóloga");
        }
    }

    // Cenário: Chaves AES e IV são gerados criptograficamente.
    // Objetivo: Retornar material Base64 com tamanhos AES-256 e IV-128.
    [Test]
    public void AesKeyGenerator_GeneratedValues_ReturnsExpectedByteLengths()
    {
        // Arrange
        // Act
        var key = Convert.FromBase64String(SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateKey());
        var iv = Convert.FromBase64String(SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateIV());
        // Assert
        using (Assert.EnterMultipleScope())
        {
            key.Should().HaveCount(32);
            iv.Should().HaveCount(16);
        }
    }

    // Cenário: Um usuário JWT tem ou não tem identificador válido.
    // Objetivo: Retornar o identificador somente para credencial JWT válida.
    [Test]
    public void GetUserIdApi_ClaimsAndCredential_ReturnsExpectedIdentifier()
    {
        // Arrange
        var user = new ClaimsPrincipal(new ClaimsIdentity([new Claim(ClaimTypes.NameIdentifier, "42")]));
        // Act
        var jwtId = SecurityHelperApi.GetUserIdApi(user, SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeApiCredential.Jwt);
        var otherId = SecurityHelperApi.GetUserIdApi(user, SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeApiCredential.AzureAD);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            jwtId.Should().Be(42);
            otherId.Should().Be(0);
        }
    }
}

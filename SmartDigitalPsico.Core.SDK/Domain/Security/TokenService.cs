using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Security;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;

namespace SmartDigitalPsico.Core.SDK.Domain.Security;

/// <summary>
/// Serviço genérico de JWT (access/refresh) — API pública SDP preservada
/// (ctor TokenConfigurationDto + TokenHandlerFactoryForTests); equivalente SCH é
/// JwtAccessTokenService via ISecurityTokenAdapterFactory.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Security.JwtAccessTokenService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca marcada; implementação local (TokenConfigurationDto + test hook); SCH usa factory/adapter.")]
public class TokenService : ITokenService
{
    private readonly TokenConfigurationDto _configuration;

    internal static Func<JwtSecurityTokenHandler>? TokenHandlerFactoryForTests { get; set; }

    public TokenService(TokenConfigurationDto configuration)
    {
        _configuration = configuration;
    }

    public string GenerateAccessToken(IEnumerable<Claim> claims)
    {
        string secretKey = _configuration.Secret;

        var signinCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
            SecurityAlgorithms.HmacSha512);

        var options = new JwtSecurityToken(
            issuer: _configuration.Issuer,
            audience: _configuration.Audience,
            claims: claims,
            expires: DateTime.Now.AddMinutes(_configuration.Minutes),
            signingCredentials: signinCredentials);
        return new JwtSecurityTokenHandler().WriteToken(options);
    }

    public string GenerateRefreshToken()
    {
        var randomNumber = new byte[32];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }

    public bool TryGetUserId(string token, out long? userId)
    {
        userId = null;
        try
        {
            var principal = GetPrincipalFromExpiredToken(token);
            var nameId = principal.FindFirst(JwtRegisteredClaimNames.NameId)?.Value
                ?? principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (long.TryParse(nameId, out var id))
            {
                userId = id;
                return true;
            }
        }
        catch
        {
            // invalid/malformed token → false
        }

        return false;
    }

    public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
    {
        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.Secret)),
            ValidateLifetime = false
        };
        var tokenHandler = TokenHandlerFactoryForTests?.Invoke() ?? new JwtSecurityTokenHandler();
        var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
        if (securityToken is not JwtSecurityToken jwtSecurityToken ||
            !jwtSecurityToken.Header.Alg.Equals(
                SecurityAlgorithms.HmacSha512,
                StringComparison.InvariantCulture))
            throw new SecurityTokenException("Invalid Token");

        return principal;
    }
}

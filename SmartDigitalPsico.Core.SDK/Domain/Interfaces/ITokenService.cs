using System.Security.Claims;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces
{
    /// <summary>
    /// Contrato genérico de emissão/validação de JWT.
    /// </summary>
    public interface ITokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}

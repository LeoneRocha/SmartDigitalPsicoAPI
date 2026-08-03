using System.Security.Claims;

namespace SmartDigitalPsico.Domain.Interfaces
{
    /// <summary>
    /// Interface (contrato) responsável por ITokenService.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface ITokenService
    {
        /// <summary>
        /// Método GenerateAccessToken: executa a operação GenerateAccessToken.
        /// </summary>
        string GenerateAccessToken(IEnumerable<Claim> claims);
        /// <summary>
        /// Método GenerateRefreshToken: executa a operação GenerateRefreshToken.
        /// </summary>
        string GenerateRefreshToken();
        /// <summary>
        /// Método GetPrincipalFromExpiredToken: consulta e retorna dados.
        /// </summary>
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}

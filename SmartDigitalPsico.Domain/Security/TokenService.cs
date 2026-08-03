using Microsoft.IdentityModel.Tokens;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.DTO.Security;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace SmartDigitalPsico.Domain.Security
{
    /// <summary>
    /// Classe responsável por TokenService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class TokenService : ITokenService
    {
        private readonly TokenConfigurationDto _configuration;

        /// <summary>
        /// Método TokenService: mapeia ou transforma dados entre modelos.
        /// </summary>
        public TokenService(TokenConfigurationDto configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Método GenerateAccessToken: executa a operação GenerateAccessToken.
        /// </summary>
        public string GenerateAccessToken(IEnumerable<Claim> claims)
        {
            string secretKey = _configuration.Secret;
           
            var signinCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)), SecurityAlgorithms.HmacSha512);
             
            var options = new JwtSecurityToken(
                issuer: _configuration.Issuer,
                audience: _configuration.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_configuration.Minutes),
                signingCredentials: signinCredentials
            );
            string tokenString = new JwtSecurityTokenHandler().WriteToken(options);
            return tokenString;
        }

        /// <summary>
        /// Método GenerateRefreshToken: executa a operação GenerateRefreshToken.
        /// </summary>
        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        /// <summary>
        /// Método GetPrincipalFromExpiredToken: consulta e retorna dados.
        /// </summary>
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
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;

            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null ||
                !jwtSecurityToken.Header.Alg.Equals(
                    SecurityAlgorithms.HmacSha512,
                    StringComparison.InvariantCulture))
                throw new SecurityTokenException("Invalid Token");

            return principal;
        }
    }
}

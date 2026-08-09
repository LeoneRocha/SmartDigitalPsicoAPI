using Microsoft.IdentityModel.Tokens;
using SmartDigitalPsico.Core.SDK.Domain.Security;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers.Security
{
    /// <summary>
    /// Classe responsável por SecurityHelper.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class SecurityHelper
    {
        /// <summary>
        /// Método CreatePasswordHash: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        /// <summary>
        /// Método VerifyPasswordHash: executa a operação VerifyPasswordHash.
        /// </summary>
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// Método CreateToken: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static string CreateToken(SecurityDto secVo)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, secVo.Id),
                new Claim(ClaimTypes.Name, secVo.Name),
                new Claim(ClaimTypes.Role, secVo.Role)
            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(secVo.SecurityKeyConfig));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokendDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateHelper.GetDateTimeNowFromUtc().AddDays(1),
                SigningCredentials = creds
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokendDescriptor);

            return tokenHandler.WriteToken(token);
        }

        /// <summary>
        /// Método IsBase64String: executa a operação IsBase64String.
        /// </summary>
        public static bool IsBase64String(string base64)
        {
            if (string.IsNullOrEmpty(base64))
            {
                return false;
            }

            Span<byte> buffer = new Span<byte>(new byte[base64.Length]);
            return Convert.TryFromBase64String(base64, buffer, out _);
        }
    }
}

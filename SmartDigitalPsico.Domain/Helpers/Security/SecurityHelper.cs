using Microsoft.IdentityModel.Tokens;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Security;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SmartDigitalPsico.Domain.Helpers.Security
{
    public static class SecurityHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
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


        public static string CreateToken(SecurityVO secVo)
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
                Expires = DataHelper.GetDateTimeNow().AddDays(1),
                SigningCredentials = creds
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokendDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}

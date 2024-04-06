using SmartDigitalPsico.Domain.Enuns;
using System.Security.Claims;

namespace SmartDigitalPsico.Domain.Security
{
    public class SecurityHelperApi
    {
        public static long GetUserIdApi(ClaimsPrincipal user, ETypeApiCredential typeApiCredential)
        {
            long idUser = 0;

            if (user != null && typeApiCredential == ETypeApiCredential.Jwt)
            {
                var userApi = user;
                long.TryParse(user.FindFirstValue(ClaimTypes.NameIdentifier), out idUser);
            }
            return idUser;
        }
    }
}

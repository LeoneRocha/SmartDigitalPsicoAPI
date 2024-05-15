using SmartDigitalPsico.Domain.Enuns;
using System.Security.Claims;

namespace SmartDigitalPsico.Domain.Security
{
    public static class SecurityHelperApi
    {
        public static long GetUserIdApi(ClaimsPrincipal user, ETypeApiCredential typeApiCredential)
        {
            long idUserResult = 0;
            long idUser;
            if (user != null && typeApiCredential == ETypeApiCredential.Jwt && long.TryParse(user.FindFirstValue(ClaimTypes.NameIdentifier), out idUser))
            {
                idUserResult = idUser;
            }
            return idUserResult;
        }
    }
}

using System.Security.Claims;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers.Security
{
    /// <summary>
    /// Helper genérico de Claims → user id para APIs.
    /// </summary>
    public static class SecurityHelperApi
    {
        public static long GetUserIdApi(ClaimsPrincipal user, ETypeApiCredential typeApiCredential)
        {
            long idUserResult = 0;
            if (user != null
                && typeApiCredential == ETypeApiCredential.Jwt
                && long.TryParse(user.FindFirstValue(ClaimTypes.NameIdentifier), out long idUser))
            {
                idUserResult = idUser;
            }
            return idUserResult;
        }
    }
}

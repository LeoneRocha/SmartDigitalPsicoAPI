using SmartDigitalPsico.Domain.Enuns;
using System.Security.Claims;

namespace SmartDigitalPsico.Domain.Helpers.Security
{
    /// <summary>
    /// Classe responsável por SecurityHelperApi.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class SecurityHelperApi
    {
        /// <summary>
        /// Método GetUserIdApi: consulta e retorna dados.
        /// </summary>
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

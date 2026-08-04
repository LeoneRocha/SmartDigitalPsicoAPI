using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.Helpers.Security;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using System.Globalization;

namespace SmartDigitalPsico.Domain.API
{
    /// <summary>
    /// Classe responsável por ApiBaseController.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public abstract class ApiBaseController : ControllerBase
    {
        protected AuthConfigurationDto _configurationAuth;

        private IUserRepository? _userRepository
        {
            get
            {
                return HttpContext.RequestServices.GetService(typeof(IUserRepository)) as IUserRepository;
            }
        }

        /// <summary>
        /// Método ApiBaseController: executa a operação ApiBaseController.
        /// </summary>
        protected ApiBaseController(IOptions<AuthConfigurationDto> configurationAuth)
        {
            _configurationAuth = configurationAuth.Value;
        }

        /// <summary>
        /// Método SetCurrentCulture: configura estado ou dependencias.
        /// </summary>
        protected async Task SetCurrentCulture()
        {
            long userId = GetUserIdCurrent();
            if (_userRepository != null)
            {
                User userCurrent = await _userRepository.FindByID(userId);
                if (!string.IsNullOrWhiteSpace(userCurrent.Language))
                {
                    ApplyCulture(new CultureInfo(userCurrent.Language));
                }
            }
        }

        /// <summary>
        /// Aplica a cultura corrente da requisição. Extensível para testes (AsyncLocal não flui ao caller).
        /// </summary>
        protected virtual void ApplyCulture(CultureInfo cultureInfo)
        {
            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;
        }

        /// <summary>
        /// Método GetUserIdCurrent: consulta e retorna dados.
        /// </summary>
        protected long GetUserIdCurrent()
        {
            long idUser = SecurityHelperApi.GetUserIdApi(User, _configurationAuth.TypeApiCredential);
            return idUser;
        }
    }

}

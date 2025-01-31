using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.Helpers.Security;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using System.Globalization;

namespace SmartDigitalPsico.Domain.API
{
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

        public ApiBaseController(IOptions<AuthConfigurationDto> configurationAuth)
        {
            _configurationAuth = configurationAuth.Value;
        }

        protected async Task SetCurrentCulture()
        {
            long userId = GetUserIdCurrent();
            if (_userRepository != null)
            {
                User userCurrent = await _userRepository.FindByID(userId);
                if (!string.IsNullOrWhiteSpace(userCurrent.Language))
                {
                    var cultureInfo = new CultureInfo(userCurrent.Language);
                    CultureInfo.CurrentCulture = cultureInfo;
                    CultureInfo.CurrentUICulture = cultureInfo;
                }
            }
        }

        protected long GetUserIdCurrent()
        {
            long idUser = SecurityHelperApi.GetUserIdApi(User, _configurationAuth.TypeApiCredential);
            return idUser;
        }
    }

}
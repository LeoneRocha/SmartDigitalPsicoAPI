using System.Globalization;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Core.SDK.Domain.Helpers.Security;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Interfaces.User;

namespace SmartDigitalPsico.Domain.API
{
    /// <summary>
    /// Bridge de produto sobre ApiBaseController do Core — aplica cultura via IUserRepository.
    /// Controllers da WebAPI devem herdar este tipo para manter i18n por usuário.
    /// Base canônica: SmartDigitalPsico.Core.SDK.API.ApiBaseController.
    /// </summary>
    public abstract class ApiBaseController : SmartDigitalPsico.Core.SDK.API.ApiBaseController
    {
        private IUserRepository? UserRepository
            => HttpContext?.RequestServices.GetService(typeof(IUserRepository)) as IUserRepository;

        protected ApiBaseController(IOptions<AuthConfigurationDto> configurationAuth)
            : base(configurationAuth)
        {
        }

        protected override async Task SetCurrentCulture()
        {
            long userId = GetUserIdCurrent();
            if (UserRepository != null)
            {
                User userCurrent = await UserRepository.FindByID(userId);
                if (!string.IsNullOrWhiteSpace(userCurrent.Language))
                {
                    ApplyCulture(new CultureInfo(userCurrent.Language));
                }
            }
        }

        protected override long GetUserIdCurrent()
        {
            return SecurityHelperApi.GetUserIdApi(User, _configurationAuth.TypeApiCredential);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Helpers.Security;
using SmartDigitalPsico.Domain.VO.Domains;
using System.Globalization;

namespace SmartDigitalPsico.Domain.API
{
    public class ApiBaseController : ControllerBase
    {
        protected AuthConfigurationVO _configurationAuth;

        public ApiBaseController(IOptions<AuthConfigurationVO> configurationAuth)
        {
            _configurationAuth = configurationAuth.Value;
        }

        protected void SetCurrentCulture()
        {
            var requestedCulture = Request.Headers["X-Culture"].ToString();

            if (!string.IsNullOrWhiteSpace(requestedCulture))
            {
                var cultureInfo = new CultureInfo(requestedCulture);
                CultureInfo.CurrentCulture = cultureInfo;
                CultureInfo.CurrentUICulture = cultureInfo;
            }
        }

        protected long GetUserIdCurrent()
        {
            SetCurrentCulture();
            long idUser = SecurityHelperApi.GetUserIdApi(User, _configurationAuth.TypeApiCredential);
            return idUser;
            
        }
    }
}
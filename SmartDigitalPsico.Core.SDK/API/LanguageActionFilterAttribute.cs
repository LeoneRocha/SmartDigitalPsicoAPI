using System.Globalization;
using Microsoft.AspNetCore.Mvc.Filters;
using SmartCoreHub.Core.SDK.Domain.Interfaces.Common;
using SmartCoreHub.Core.SDK.Infrastructure.Logging;

namespace SmartDigitalPsico.Core.SDK.API
{
    /// <summary>
    /// Define a cultura da thread a partir da rota {culture}.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class LanguageActionFilterAttribute : ActionFilterAttribute
    {
        private readonly IAppLogger _logger;

        public LanguageActionFilterAttribute(IAppLogger logger)
        {
            _logger = logger;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string culture = context.RouteData.Values["culture"]?.ToString() ?? string.Empty;

            if (_logger.IsEnabled(AppLogLevel.Information))
                _logger.Information("Setting the culture from the URL: {Culture}", culture);

            CultureInfo.CurrentCulture = new CultureInfo(culture);
            CultureInfo.CurrentUICulture = new CultureInfo(culture);

            base.OnActionExecuting(context);
        }
    }
}

using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace SmartDigitalPsico.Domain.API
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class LanguageActionFilterAttribute : ActionFilterAttribute
    {
        private readonly ILogger _logger;

        public LanguageActionFilterAttribute(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("LanguageActionFilter");
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string culture = context.RouteData.Values["culture"]?.ToString() ?? string.Empty;
            _logger.LogInformation("Setting the culture from the URL: {culture}", culture);

#if NET451
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
        System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
#elif NET46
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
        System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
#else
            CultureInfo.CurrentCulture = new CultureInfo(culture);
            CultureInfo.CurrentUICulture = new CultureInfo(culture);
#endif
            base.OnActionExecuting(context);
        }
    }

}
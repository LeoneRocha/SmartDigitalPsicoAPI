using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace SmartDigitalPsico.Domain.API
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    /// <summary>
    /// Classe responsável por LanguageActionFilterAttribute.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class LanguageActionFilterAttribute : ActionFilterAttribute
    {
        private readonly ILogger _logger;

        /// <summary>
        /// Método LanguageActionFilterAttribute: executa a operação LanguageActionFilterAttribute.
        /// </summary>
        public LanguageActionFilterAttribute(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger("LanguageActionFilter");
        }

        /// <summary>
        /// Método OnActionExecuting: executa a operação OnActionExecuting.
        /// </summary>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string culture = context.RouteData.Values["culture"]?.ToString() ?? string.Empty;

            // Evita custo de formatação/avaliação quando Information está desabilitado (Sonar/CA logging).
            if (_logger.IsEnabled(LogLevel.Information))
                _logger.LogInformation("Setting the culture from the URL: {Culture}", culture);

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

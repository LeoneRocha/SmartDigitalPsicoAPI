using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por RequestCultureMiddleware.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public class RequestCultureMiddleware
    {
        private readonly RequestDelegate _next;

        /// <summary>
        /// Método RequestCultureMiddleware: operação de agendamento.
        /// </summary>
        public RequestCultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Método Invoke: executa a operação Invoke.
        /// </summary>
        public async Task Invoke(HttpContext context)
        {
            var requestedCulture = context.Request.Headers["X-Culture"].ToString();
            if (!string.IsNullOrWhiteSpace(requestedCulture))
            {
                var cultureInfo = new CultureInfo(requestedCulture);
                CultureInfo.CurrentCulture = cultureInfo;
                CultureInfo.CurrentUICulture = cultureInfo;
            } 
            await _next.Invoke(context);
        }
    } 
}

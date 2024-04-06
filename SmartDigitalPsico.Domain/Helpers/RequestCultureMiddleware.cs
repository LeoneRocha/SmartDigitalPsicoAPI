using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace SmartDigitalPsico.Domain.Helpers
{
    public class RequestCultureMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestCultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }

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

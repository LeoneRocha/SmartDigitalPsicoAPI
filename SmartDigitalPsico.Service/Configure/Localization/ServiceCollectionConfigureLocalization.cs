using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.Localization;
using SmartDigitalPsico.Domain.API;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Wrapper host: cultures via Core.SDK; filtro de idioma permanece no produto.
    /// </summary>
    public static class ServiceCollectionConfigureLocalization
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<LanguageActionFilterAttribute>();
            services.AddCoreRequestLocalization();
        }
    }
}

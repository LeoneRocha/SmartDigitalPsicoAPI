using Microsoft.Extensions.DependencyInjection;
using Microsoft.Net.Http.Headers;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Mvc
{
    public static class MvcControllersServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreMvcControllers(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc(options =>
            {
                options.RespectBrowserAcceptHeader = true;
                options.FormatterMappings.SetMediaTypeMappingForFormat(
                    "json",
                    MediaTypeHeaderValue.Parse("application/json"));
            })
                .AddViewLocalization()
                .AddDataAnnotationsLocalization();
            return services;
        }
    }
}

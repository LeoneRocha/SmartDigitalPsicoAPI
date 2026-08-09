using Microsoft.Extensions.DependencyInjection;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Cors
{
    public static class CorsServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreCors(this IServiceCollection services)
        {
#pragma warning disable S5122
            services.AddCors(options => options.AddDefaultPolicy(builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithExposedHeaders("Content-Disposition");
            }));
#pragma warning restore S5122
            return services;
        }
    }
}

using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi;
using Swashbuckle.AspNetCore.Filters;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Documentation
{
    public static class SwaggerServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreSwagger(
            this IServiceCollection services,
            string title,
            string description,
            string? version = null)
        {
            var resolvedVersion = string.IsNullOrWhiteSpace(version)
                ? Assembly.GetEntryAssembly()?.GetName().Version?.ToString() ?? "1.0.0"
                : version;

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = title,
                    Version = resolvedVersion,
                    Description = description
                });
                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme. Example: \"bearer {token}\"",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.OperationFilter<SecurityRequirementsOperationFilter>();
            });

            return services;
        }
    }
}

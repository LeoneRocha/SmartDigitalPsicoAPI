using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

namespace SmartDigitalPsico.WebAPI.Configure.Services
{
    public static class ApplicationConfigureDocumentation
    {
        public static void Configure(IServiceCollection services)
        {
            addDoc(services);
        }
        private static void addDoc(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SmartDigitalPsico.WebAPI", Version = "v1" });
                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme. Example: \"bearer {token}\"",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.OperationFilter<SecurityRequirementsOperationFilter>();
            });
        }
    }
}

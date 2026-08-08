using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using Swashbuckle.AspNetCore.Filters;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Classe responsável por ServiceCollectionConfigureDocumentation.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServiceCollectionConfigureDocumentation
    {
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public static void Configure(IServiceCollection services)
        {
            addDoc(services);
        }

        private static void addDoc(IServiceCollection services)
        {
            var assemblyVersion = LogAppHelper.GetAssemblyVersion();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "SmartDigitalPsico.WebAPI",
                    Version = assemblyVersion,
                    Description = "API REST do Smart Digital Psico para gestão clínica, agenda, pacientes e configurações do sistema."
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
        }
    }
}

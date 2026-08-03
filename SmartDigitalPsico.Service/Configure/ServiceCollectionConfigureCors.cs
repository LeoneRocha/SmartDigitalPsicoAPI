using Microsoft.Extensions.DependencyInjection;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Classe responsável por ServiceCollectionConfigureCors.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServiceCollectionConfigureCors
    {
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public static void Configure(IServiceCollection services)
        {
            addCors(services);
        }
        private static void addCors(IServiceCollection services)
        {
#pragma warning disable S5122 // Disabling Sonar warning for CORS
            services.AddCors(options => options.AddDefaultPolicy(builder =>
            {
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("Content-Disposition");
            }));
#pragma warning restore S5122

        }
    }
}

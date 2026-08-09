using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Repository;
using SmartDigitalPsico.Domain.Interfaces.Common;
namespace SmartDigitalPsico.Service.DependencyInjection.Authentication
{
    /// <summary>
    /// Classe responsável por ServicesDomainAuthentication.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServicesDomainAuthentication
    {
        /// <summary>
        /// Método AddDependencies: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddDependencies(IServiceCollection services)
        {

            services.AddScoped<IUserTokenSessionRepository, UserTokenSessionRepository>();
            services.AddScoped<ITokenSessionPersistenceFactory, TokenSessionPersistenceFactory>();
            services.AddScoped<ITokenSessionPersistenceService, TokenSessionService>();
        }
    }
}

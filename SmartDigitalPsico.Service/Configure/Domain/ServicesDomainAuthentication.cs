using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Service.Infrastructure.Authentication;

namespace SmartDigitalPsico.Service.Configure.Domain
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

using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Service.Infrastructure.Authentication;

using SmartDigitalPsico.Domain.Interfaces.Common;
namespace SmartDigitalPsico.Service.Configure.Domain
{
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;
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

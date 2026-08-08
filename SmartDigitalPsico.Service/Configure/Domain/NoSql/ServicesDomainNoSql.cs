using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

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
    /// Classe responsável por ServicesDomainNoSql.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServicesDomainNoSql
    {
        /// <summary>
        /// Método AddDependencies: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddDependencies(IServiceCollection services)
        {

            services.AddTransient<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageTableRepositoryFactory, SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageTableRepositoryFactory>();

            services.AddScoped<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<PatientRecordTableEntity>>(provider =>
            {
                var serviceFactory = provider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageTableRepositoryFactory>();
                return new SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageTableEntityService<PatientRecordTableEntity>(serviceFactory, StorageTableConstants.PatientRecordTable);
            });

            services.AddScoped<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<UserTokenSessionTableEntity>>(provider =>
            {
                var serviceFactory = provider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageTableRepositoryFactory>();
                return new SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageTableEntityService<UserTokenSessionTableEntity>(serviceFactory, StorageTableConstants.UserTokenSessionTable);
            });
        }
    }
}

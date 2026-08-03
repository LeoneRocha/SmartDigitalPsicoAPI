using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Service.Infrastructure;

namespace SmartDigitalPsico.Service.Configure.Domain
{
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

            services.AddTransient<IStorageTableRepositoryFactory, StorageTableRepositoryFactory>();

            services.AddScoped<IStorageTableContract<PatientRecordTableEntity>>(provider =>
            {
                var serviceFactory = provider.GetRequiredService<IStorageTableRepositoryFactory>();
                return new StorageTableEntityService<PatientRecordTableEntity>(serviceFactory, StorageTableConstants.PatientRecordTable);
            });

            services.AddScoped<IStorageTableContract<UserTokenSessionTableEntity>>(provider =>
            {
                var serviceFactory = provider.GetRequiredService<IStorageTableRepositoryFactory>();
                return new StorageTableEntityService<UserTokenSessionTableEntity>(serviceFactory, StorageTableConstants.UserTokenSessionTable);
            });
        }
    }
}

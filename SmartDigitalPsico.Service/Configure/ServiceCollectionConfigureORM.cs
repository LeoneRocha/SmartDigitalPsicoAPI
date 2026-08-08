using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Classe responsável por ServiceCollectionConfigureOrm.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServiceCollectionConfigureOrm
    {
        private static IConfiguration? _configuration;
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            _configuration = configuration;

            //ORM API 
            addORM(services, ServiceCollectionConfigureAppSettings.AddAndReturnTypeDataBase(_configuration));
        }

        private static void addORM(IServiceCollection services, ETypeDataBase etypeDataBase)
        {
            var connection = string.Empty;
            switch (etypeDataBase)
            {
                case ETypeDataBase.Mysql:
                    connection = ConfigurationAppSettingsHelper.GetConnectionStringMySQL(_configuration);
                    services.AddDbContext<IEntityDataContext, SmartDigitalPsicoDataContextMySql>((serviceProvider, optionsBuilder) =>
                    {
                        // Fixed server version avoids AutoDetect (requires a live DB at DI resolve time).
                        optionsBuilder.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 36)),
                        optionsMySQL =>
                        {
                            optionsMySQL.MigrationsAssembly("SmartDigitalPsico.Data");
                            optionsMySQL.SchemaBehavior(MySqlSchemaBehavior.Ignore);
                        });

                        var auditInterceptor = serviceProvider.GetRequiredService<AuditContextInterceptor>();
                        optionsBuilder.AddInterceptors(auditInterceptor);
                    }, ServiceLifetime.Scoped, ServiceLifetime.Scoped);
                    break;
                case ETypeDataBase.MSsqlServer:
                    connection = ConfigurationAppSettingsHelper.GetConnectionStringSQL(_configuration);
                    services.AddDbContext<IEntityDataContext, SmartDigitalPsicoDataContextSqlServer>((serviceProvider, optionsBuilder) =>
                    {
                        optionsBuilder.UseSqlServer(connection,
                        optionsSQL => optionsSQL.MigrationsAssembly("SmartDigitalPsico.Data"));
                        var auditInterceptor = serviceProvider.GetRequiredService<AuditContextInterceptor>();
                        optionsBuilder.AddInterceptors(auditInterceptor);
                    }, ServiceLifetime.Scoped, ServiceLifetime.Scoped);
                    break;
                default:
                    break;
            }

            // Compatibilidade: consumidores ainda tipados no shim Obsolete do host.
#pragma warning disable SDP_CORE_SDK_REPO
            services.AddScoped<SmartDigitalPsico.Data.Context.Interface.IEntityDataSmartDigitalPsicoContext>(sp =>
                (SmartDigitalPsico.Data.Context.Interface.IEntityDataSmartDigitalPsicoContext)sp.GetRequiredService<IEntityDataContext>());
#pragma warning restore SDP_CORE_SDK_REPO
        }
    }
}

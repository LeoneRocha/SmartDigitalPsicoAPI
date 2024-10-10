using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.Service.Configure
{
    public static class ServiceCollectionConfigureORM
    {
        private static IConfiguration? _configuration;
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
                        optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection),
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
        }
    }
}

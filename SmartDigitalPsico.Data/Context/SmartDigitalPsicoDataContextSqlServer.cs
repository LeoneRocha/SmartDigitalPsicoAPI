using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Context.Configure;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Data.Context
{
    public class SmartDigitalPsicoDataContextSqlServer : EntityDataContext
    {
        private readonly AuditContextInterceptor? _auditInterceptor;
        public SmartDigitalPsicoDataContextSqlServer()
        {
        }
        public SmartDigitalPsicoDataContextSqlServer(DbContextOptions<SmartDigitalPsicoDataContextSqlServer> options) : base(options)
        {
        }
        public SmartDigitalPsicoDataContextSqlServer(DbContextOptions<SmartDigitalPsicoDataContextSqlServer> options, AuditContextInterceptor auditInterceptor)
            : base(options)
        {
            _auditInterceptor = auditInterceptor;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_auditInterceptor != null)
            {
                optionsBuilder.AddInterceptors(_auditInterceptor);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure FLUENT API 
            ConfigurationEntitiesHelper.AddConfigurationEntitiesManually(modelBuilder, ETypeDataBase.MSsqlServer);
            ConfigurationEntitiesHelper.AddConfigurationEntities(modelBuilder, ETypeDataBase.MSsqlServer);
            base.OnModelCreating(modelBuilder);
        }
    }
}
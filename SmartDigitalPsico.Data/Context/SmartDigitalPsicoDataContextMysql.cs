using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Context.Configure;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Data.Context
{
    public class SmartDigitalPsicoDataContextMySql : EntityDataContext
    {
        private readonly AuditContextInterceptor? _auditInterceptor;
        public SmartDigitalPsicoDataContextMySql()
        {
        }
        public SmartDigitalPsicoDataContextMySql(DbContextOptions<SmartDigitalPsicoDataContextMySql> options) : base(options)
        {
        }
        public SmartDigitalPsicoDataContextMySql(DbContextOptions<SmartDigitalPsicoDataContextMySql> options, AuditContextInterceptor auditInterceptor)
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
            ConfigurationEntitiesHelper.AddConfigurationEntities(modelBuilder, ETypeDataBase.Mysql);

            ConfigurationEntitiesHelper.AddDataMock(modelBuilder, ETypeDataBase.Mysql);

            base.OnModelCreating(modelBuilder);
        }
    }
}
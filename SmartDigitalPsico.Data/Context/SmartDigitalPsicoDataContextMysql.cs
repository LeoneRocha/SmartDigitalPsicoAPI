using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Audit;

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
    }
}
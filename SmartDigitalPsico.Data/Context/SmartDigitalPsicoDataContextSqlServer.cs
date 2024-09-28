using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Audit;

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
    }
}
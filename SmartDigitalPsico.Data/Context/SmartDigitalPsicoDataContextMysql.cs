using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Audit;

namespace SmartDigitalPsico.Data.Context
{

    /// <summary>
    /// arrumar a injecao de dependencia 
    /// </summary>
    public class SmartDigitalPsicoDataContextMysql : EntityDataContext
    {
        private readonly AuditContextInterceptor? _auditInterceptor;
        public SmartDigitalPsicoDataContextMysql()
        { 
        }
        public SmartDigitalPsicoDataContextMysql(DbContextOptions<SmartDigitalPsicoDataContextMysql> options) : base(options)
        {
        }
        public SmartDigitalPsicoDataContextMysql(DbContextOptions<SmartDigitalPsicoDataContextMysql> options, AuditContextInterceptor auditInterceptor)
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
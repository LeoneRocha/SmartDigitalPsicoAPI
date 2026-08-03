using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Context.Configure;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Data.Context
{
    /// <summary>
    /// Classe responsável por SmartDigitalPsicoDataContextMySql.
    /// Responsabilidade: contexto EF Core / configuração de dados.
    /// Relação: usado pelos repositórios da camada Data.
    /// </summary>
    public class SmartDigitalPsicoDataContextMySql : EntityDataContext
    {
        private readonly AuditContextInterceptor? _auditInterceptor;
        /// <summary>
        /// Método SmartDigitalPsicoDataContextMySql: executa a operação SmartDigitalPsicoDataContextMySql.
        /// </summary>
        public SmartDigitalPsicoDataContextMySql()
        {
        }
        /// <summary>
        /// Método SmartDigitalPsicoDataContextMySql: executa a operação SmartDigitalPsicoDataContextMySql.
        /// </summary>
        public SmartDigitalPsicoDataContextMySql(DbContextOptions<SmartDigitalPsicoDataContextMySql> options) : base(options)
        {
        }
        /// <summary>
        /// Método SmartDigitalPsicoDataContextMySql: executa a operação SmartDigitalPsicoDataContextMySql.
        /// </summary>
        public SmartDigitalPsicoDataContextMySql(DbContextOptions<SmartDigitalPsicoDataContextMySql> options, AuditContextInterceptor auditInterceptor)
            : base(options)
        {
            _auditInterceptor = auditInterceptor;
        }
        /// <summary>
        /// Método OnConfiguring: executa a operação OnConfiguring.
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {  
            if (_auditInterceptor != null)
            {
                optionsBuilder.AddInterceptors(_auditInterceptor);
            }
        }

        /// <summary>
        /// Método OnModelCreating: executa a operação OnModelCreating.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure FLUENT API 
            ConfigurationEntitiesHelper.AddConfigurationEntitiesManually(modelBuilder, ETypeDataBase.Mysql);
            ConfigurationEntitiesHelper.AddConfigurationEntities(modelBuilder, ETypeDataBase.Mysql);
             
            base.OnModelCreating(modelBuilder);
        }
    }
}

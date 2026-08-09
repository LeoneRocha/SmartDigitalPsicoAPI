using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Context.Configure;

namespace SmartDigitalPsico.Data.Context
{
    /// <summary>
    /// Classe responsável por SmartDigitalPsicoDataContextSqlServer.
    /// Responsabilidade: contexto EF Core / configuração de dados.
    /// Relação: usado pelos repositórios da camada Data.
    /// </summary>
    public class SmartDigitalPsicoDataContextSqlServer : EntityDataSmartDigitalPsicoContext
    {
        private readonly AuditContextInterceptor? _auditInterceptor;
        /// <summary>
        /// Método SmartDigitalPsicoDataContextSqlServer: executa a operação SmartDigitalPsicoDataContextSqlServer.
        /// </summary>
        public SmartDigitalPsicoDataContextSqlServer()
        {
        }
        /// <summary>
        /// Método SmartDigitalPsicoDataContextSqlServer: executa a operação SmartDigitalPsicoDataContextSqlServer.
        /// </summary>
        public SmartDigitalPsicoDataContextSqlServer(DbContextOptions<SmartDigitalPsicoDataContextSqlServer> options) : base(options)
        {
        }
        /// <summary>
        /// Método SmartDigitalPsicoDataContextSqlServer: executa a operação SmartDigitalPsicoDataContextSqlServer.
        /// </summary>
        public SmartDigitalPsicoDataContextSqlServer(DbContextOptions<SmartDigitalPsicoDataContextSqlServer> options, AuditContextInterceptor auditInterceptor)
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
            ConfigurationEntitiesHelper.AddConfigurationEntitiesManually(modelBuilder, ETypeDataBase.MSsqlServer);
            ConfigurationEntitiesHelper.AddConfigurationEntities(modelBuilder, ETypeDataBase.MSsqlServer);
            base.OnModelCreating(modelBuilder);
        }
    }
}

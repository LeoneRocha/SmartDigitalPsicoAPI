using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    /// <summary>
    /// Classe responsável por AuditDataSelectiveEntityLogRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class AuditDataSelectiveEntityLogRepository : SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<AuditDataSelectiveEntityLog>, IAuditDataSelectiveEntityLogRepository
    {
        /// <summary>
        /// Método AuditDataSelectiveEntityLogRepository: executa a operação AuditDataSelectiveEntityLogRepository.
        /// </summary>
        public AuditDataSelectiveEntityLogRepository(IEntityDataContext context) : base((Microsoft.EntityFrameworkCore.DbContext)context) { }

    }
}

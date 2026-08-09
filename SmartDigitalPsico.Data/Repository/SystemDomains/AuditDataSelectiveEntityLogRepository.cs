using SmartDigitalPsico.Core.SDK.Data.Context.Interface;

using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    /// <summary>
    /// Classe responsável por AuditDataSelectiveEntityLogRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class AuditDataSelectiveEntityLogRepository : SmartDigitalPsico.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<AuditDataSelectiveEntityLog>, IAuditDataSelectiveEntityLogRepository
    {
        /// <summary>
        /// Método AuditDataSelectiveEntityLogRepository: executa a operação AuditDataSelectiveEntityLogRepository.
        /// </summary>
        public AuditDataSelectiveEntityLogRepository(IEntityDataContext context) : base(context) { }

    }
}

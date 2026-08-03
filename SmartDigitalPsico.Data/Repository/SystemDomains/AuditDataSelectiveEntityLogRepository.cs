using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    /// <summary>
    /// Classe responsável por AuditDataSelectiveEntityLogRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class AuditDataSelectiveEntityLogRepository : GenericRepositoryEntityBase<AuditDataSelectiveEntityLog>, IAuditDataSelectiveEntityLogRepository
    {
        /// <summary>
        /// Método AuditDataSelectiveEntityLogRepository: executa a operação AuditDataSelectiveEntityLogRepository.
        /// </summary>
        public AuditDataSelectiveEntityLogRepository(IEntityDataContext context) : base(context) { }

    }
}

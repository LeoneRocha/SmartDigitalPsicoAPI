using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Audit
{
    /// <summary>
    /// Interface (contrato) responsável por IAuditDataSelectiveEntityLogRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IAuditDataSelectiveEntityLogRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<AuditDataSelectiveEntityLog>
    {
    }
}

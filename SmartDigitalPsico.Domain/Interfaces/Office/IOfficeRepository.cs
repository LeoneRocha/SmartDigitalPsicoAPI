using SmartDigitalPsico.Domain.ModelEntity;

using OfficeEntity = SmartDigitalPsico.Domain.ModelEntity.Office;

namespace SmartDigitalPsico.Domain.Interfaces.Office
{
    /// <summary>
    /// Interface (contrato) responsável por IOfficeRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IOfficeRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<OfficeEntity>
    {

    }
}

using SmartDigitalPsico.Domain.ModelEntity;

using GenderEntity = SmartDigitalPsico.Domain.ModelEntity.Gender;

namespace SmartDigitalPsico.Domain.Interfaces.Gender
{
    /// <summary>
    /// Interface (contrato) responsável por IGenderRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IGenderRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<GenderEntity>
    {

    }
}

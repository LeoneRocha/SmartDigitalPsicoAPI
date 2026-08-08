using SmartDigitalPsico.Domain.EntityModels.Schedule;

using GenderEntity = SmartDigitalPsico.Domain.EntityModels.Gender;

using SmartDigitalPsico.Domain.EntityModels;

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

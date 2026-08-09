using SmartDigitalPsico.Domain.DTO.Gender.GET;

using GenderEntity = SmartDigitalPsico.Domain.EntityModels.Gender;

namespace SmartDigitalPsico.Domain.Interfaces.Gender
{
    /// <summary>
    /// Interface (contrato) responsável por IGenderService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IGenderService
        : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<GenderEntity, GetGenderDto>
    {

    }
}

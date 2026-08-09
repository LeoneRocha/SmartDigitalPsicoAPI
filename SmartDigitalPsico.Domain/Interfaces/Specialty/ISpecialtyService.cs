using SmartDigitalPsico.Domain.DTO.Specialty.GET;

using SpecialtyEntity = SmartDigitalPsico.Domain.EntityModels.Specialty;

namespace SmartDigitalPsico.Domain.Interfaces.Specialty
{
    /// <summary>
    /// Interface (contrato) responsável por ISpecialtyService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface ISpecialtyService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<SpecialtyEntity, GetSpecialtyDto>
    {

    }
}

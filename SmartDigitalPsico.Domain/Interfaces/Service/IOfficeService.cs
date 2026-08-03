using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por IOfficeService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IOfficeService : IEntityBaseService<Office, GetOfficeDto>
    {

    }
}

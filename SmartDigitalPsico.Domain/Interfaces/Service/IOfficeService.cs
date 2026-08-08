using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por IOfficeService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IOfficeService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<Office, GetOfficeDto>
    {

    }
}

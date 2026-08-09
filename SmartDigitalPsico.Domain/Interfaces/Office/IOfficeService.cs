using SmartDigitalPsico.Domain.DTO.Office.GET;

using OfficeEntity = SmartDigitalPsico.Domain.EntityModels.Office;

namespace SmartDigitalPsico.Domain.Interfaces.Office
{
    /// <summary>
    /// Interface (contrato) responsável por IOfficeService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IOfficeService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<OfficeEntity, GetOfficeDto>
    {

    }
}

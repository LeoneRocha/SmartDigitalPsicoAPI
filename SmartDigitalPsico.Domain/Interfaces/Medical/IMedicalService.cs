using SmartDigitalPsico.Domain.DTO.Medical.GET;

using MedicalEntity = SmartDigitalPsico.Domain.EntityModels.Medical;

namespace SmartDigitalPsico.Domain.Interfaces.Medical
{
    /// <summary>
    /// Interface (contrato) responsável por IMedicalService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IMedicalService
        : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<MedicalEntity, GetMedicalDto>
    {

    }
}

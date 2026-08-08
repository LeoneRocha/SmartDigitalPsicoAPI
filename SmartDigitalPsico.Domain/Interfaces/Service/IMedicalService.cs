using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Medical.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.GET;
using SmartDigitalPsico.Domain.DTO.Medical.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.Common;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por IMedicalService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IMedicalService
        : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<Medical, GetMedicalDto>
    {

    }
}

using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por IGenderService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IGenderService 
        : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<Gender, GetGenderDto>
    {

    }
}

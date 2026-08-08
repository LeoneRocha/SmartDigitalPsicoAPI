using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;

using SpecialtyEntity = SmartDigitalPsico.Domain.EntityModels.Specialty;

using SmartDigitalPsico.Domain.EntityModels;

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

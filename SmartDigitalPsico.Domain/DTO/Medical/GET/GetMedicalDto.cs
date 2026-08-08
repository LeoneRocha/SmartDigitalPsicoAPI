using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.DTO.Patient.ADD;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Domain.DTO.Patient.UPDATE;
using SmartDigitalPsico.Domain.DTO.Patient.Common;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;

using SmartDigitalPsico.Domain.DTO.Medical.Common;
namespace SmartDigitalPsico.Domain.DTO.Medical.GET
{
    /// <summary>
    /// Classe responsável por GetMedicalDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetMedicalDto : ActionMedicalDtoBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDto, ISupportsHyperMedia
    {   
        #region Relationship
        public GetOfficeDto Office { get; set; } = new GetOfficeDto();
        public List<GetSpecialtyDto> Specialties { get; set; } = new List<GetSpecialtyDto>();
        public List<GetPatientDto> Patients { get; set; } = new List<GetPatientDto>();
        #endregion Relationship 
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>(); 
    }
}

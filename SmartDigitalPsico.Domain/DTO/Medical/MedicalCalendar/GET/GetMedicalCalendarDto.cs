using SmartDigitalPsico.Domain.DTO.Patient.ADD;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Domain.DTO.Patient.UPDATE;
using SmartDigitalPsico.Domain.DTO.Patient.Common;
using SmartDigitalPsico.Domain.DTO.User.ADD;
using SmartDigitalPsico.Domain.DTO.User.GET;
using SmartDigitalPsico.Domain.DTO.User.UPDATE;
using SmartDigitalPsico.Domain.DTO.User.Common;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;

using SmartDigitalPsico.Domain.DTO.Medical.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;
namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET
{
    /// <summary>
    /// Classe responsável por GetMedicalCalendarDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetMedicalCalendarDto : ActionMedicalCalendarDtoBase, ISupportsHyperMedia
    {
        #region Relationship 
        public GetMedicalDto Medical { get; set; } = new GetMedicalDto();
        public GetPatientDto? Patient { get; set; } = new GetPatientDto();
        public GetUserDto? CreatedUser { get; set; } = new GetUserDto();
        public GetUserDto? ModifyUser { get; set; } = new GetUserDto();
        #endregion Relationship
         
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>(); 
    }
}

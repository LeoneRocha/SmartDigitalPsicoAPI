using SmartDigitalPsico.Domain.DTO.Patient;
using SmartDigitalPsico.Domain.DTO.User;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar
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
         
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>(); 
    }
}

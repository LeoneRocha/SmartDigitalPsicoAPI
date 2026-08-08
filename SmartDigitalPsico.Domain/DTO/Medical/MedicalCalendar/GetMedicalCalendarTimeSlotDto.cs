using AutoMapper.Configuration.Annotations;
using SmartDigitalPsico.Domain.DTO.Patient;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;
using System.Text.Json.Serialization;


namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar
{
    /// <summary>
    /// Classe responsável por GetMedicalCalendarTimeSlotDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetMedicalCalendarTimeSlotDto : GetMedicalCalendarDtoBase, ISupportsHyperMedia
    {  
        #region Relationship  
        public long? PatientId { get; set; }
          
        public string PatientName { get { return Patient?.Name ?? string.Empty; } }

        [JsonIgnore]
        public GetMedicalDto Medical { get; set; } = new GetMedicalDto();
        
        [JsonIgnore]
        public GetPatientDto? Patient { get; set; } = new GetPatientDto();
         
        #endregion Relationship

        [JsonIgnore]
        [Ignore]
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
    }
}

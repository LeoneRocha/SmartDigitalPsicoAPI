using AutoMapper.Configuration.Annotations;
using SmartDigitalPsico.Domain.DTO.Patient;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using System.Text.Json.Serialization;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar
{
    public class GetMedicalCalendarTimeSlotDto : GetMedicalCalendarDtoBase, ISupportsHyperMedia
    { 
        public string TokenRecurrence { get; set; } = string.Empty;
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
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
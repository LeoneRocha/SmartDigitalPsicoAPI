using AutoMapper.Configuration.Annotations;
using SmartDigitalPsico.Domain.DTO.Patient;
using SmartDigitalPsico.Domain.DTO.User;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using System.Text.Json.Serialization;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar
{
    public class GetMedicalCalendarTimeSlotDto : UpdateMedicalCalendarDtoBase, ISupportsHyperMedia
    {
        #region Relationship 

        public string MedicalName { get { return Medical.Name; } }

        public string PatientName { get { return Patient?.Name ?? string.Empty; } }

        [JsonIgnore]
        public GetMedicalDto Medical { get; set; } = new GetMedicalDto();
        [JsonIgnore]
        public GetPatientDto? Patient { get; set; } = new GetPatientDto();
        [JsonIgnore]
        public GetUserDto? CreatedUser { get; set; } = new GetUserDto();

        [JsonIgnore]
        public GetUserDto? ModifyUser { get; set; } = new GetUserDto();
        #endregion Relationship

        [JsonIgnore]
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
using AutoMapper.Configuration.Annotations;
using SmartDigitalPsico.Domain.Enuns;
using System.Text.Json.Serialization;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    public class ScheduleCriteriaDto
    {
        public DateTime AppointmentDateTime { get; set; }
        public string Reason { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
        public EScheduleCalendarType ScheduleType { get; set; }

        public long PatientId { get; set; }
        public long MedicalId { get; set; }

        [JsonIgnore]
        [Ignore]
        public long UserIdLogged { get; set; }
    }
}

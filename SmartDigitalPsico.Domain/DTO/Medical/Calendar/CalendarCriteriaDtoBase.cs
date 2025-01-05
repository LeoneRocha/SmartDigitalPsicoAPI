using AutoMapper.Configuration.Annotations;
using System.Text.Json.Serialization;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    public abstract class CalendarCriteriaDtoBase
    {
        public long MedicalId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        [JsonIgnore]
        [Ignore]
        public long UserIdLogged { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}

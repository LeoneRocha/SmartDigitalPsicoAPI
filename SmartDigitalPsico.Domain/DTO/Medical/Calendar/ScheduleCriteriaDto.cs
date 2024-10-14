using AutoMapper.Configuration.Annotations;
using System.Text.Json.Serialization;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    public class ScheduleCriteriaDto
    {
        public long MedicalId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int IntervalInMinutes { get; set; } // Intervalo em minutos (ex: 30 para 30 minutos, 60 para 1 hora)

        [JsonIgnore]
        [Ignore]
        public long UserIdLogged { get; set; }
        public bool FilterDaysAndTimesWithAppointments { get; set; } // Filtro para dias com compromissos
        public DateTime? FilterByDate { get; set; } // Filtrar por data específica
    }
}

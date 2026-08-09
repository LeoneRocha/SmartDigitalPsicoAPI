using System.Text.Json.Serialization;
using AutoMapper.Configuration.Annotations;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    /// <summary>
    /// Classe responsável por CalendarCriteriaDtoBase.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
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

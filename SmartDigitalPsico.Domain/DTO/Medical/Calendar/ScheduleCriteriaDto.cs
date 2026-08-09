using System.Text.Json.Serialization;
using AutoMapper.Configuration.Annotations;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    /// <summary>
    /// Classe responsável por ScheduleCriteriaDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
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

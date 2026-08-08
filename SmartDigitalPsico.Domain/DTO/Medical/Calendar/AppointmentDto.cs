using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    /// <summary>
    /// Classe responsável por AppointmentDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AppointmentDto
    {
        public string MedicalName { get; set; } = string.Empty;
        public long MedicalId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public EStatusCalendar Status { get; set; }
        public string TimeZone { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsPast { get; set; }
    }
}

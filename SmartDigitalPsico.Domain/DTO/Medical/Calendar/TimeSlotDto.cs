using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{ 
    /// <summary>
    /// Classe responsável por TimeSlotDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class TimeSlotDto
    {
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsAvailable { get; set; } 
        public GetMedicalCalendarTimeSlotDto? MedicalCalendar { get; set; }
        public bool IsPast { get; set; }
    }
}

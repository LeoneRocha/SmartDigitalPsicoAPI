using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class ScheduleBatchBaseDto : EntityDtoBase
    {
        public long MedicalId { get; set; }
        public long? PatientId { get; set; }
        public string BatchToken { get; set; } = string.Empty;
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; } 
    }
}

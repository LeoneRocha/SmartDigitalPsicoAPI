namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class ScheduleBatchSummaryDto
    {
        public long Id { get; set; }
        public string BatchToken { get; set; } = string.Empty;
        public long MedicalId { get; set; }
        public long? PatientId { get; set; }
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        public int ItemCount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

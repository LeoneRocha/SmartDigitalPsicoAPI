namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class ScheduleBatchCriteriaDto
    {
        public long MedicalId { get; set; }
        public long? PatientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string BatchToken { get; set; } = string.Empty;
        public bool IncludeDisabled { get; set; } = false;
        public long? UserIdLogged { get; set; }
    }
}

namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class DeleteScheduleBatchDto
    {
        public long Id { get; set; }
        public string BatchToken { get; set; } = string.Empty;
        public bool DeleteAllItems { get; set; } = false;
        public long MedicalId { get; set; }
        public long? PatientId { get; set; }
    }
}

namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class GetScheduleBatchDto : ScheduleBatchBaseDto
    {    
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public long? CreatedUserId { get; set; }
        public long? ModifyUserId { get; set; }
        public GetScheduleItemDto[] ScheduleItems { get; set; } = [];

        // Informações relacionadas
        public string MedicalName { get; set; } = string.Empty;
        public string PatientName { get; set; } = string.Empty;
    }
}

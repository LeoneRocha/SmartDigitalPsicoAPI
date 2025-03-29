namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class GetScheduleBatchDto : ScheduleBatchBaseDto
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public long? CreatedUserId { get; set; }
        public long? ModifyUserId { get; set; }
        public GetScheduleItemDto[] ScheduleItems { get; set; } = Array.Empty<GetScheduleItemDto>();

        // Informações relacionadas
        public string MedicalName { get; set; } = string.Empty;
        public string PatientName { get; set; } = string.Empty;
    }
}

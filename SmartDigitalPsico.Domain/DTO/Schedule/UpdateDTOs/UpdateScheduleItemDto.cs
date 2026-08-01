namespace SmartDigitalPsico.Domain.DTO.Schedule.UpdateDTOs
{
    public class UpdateScheduleItemDto : ScheduleItemBaseDto
    {
        // ID é necessário para atualização
        public long Id { get; set; }
    }
}

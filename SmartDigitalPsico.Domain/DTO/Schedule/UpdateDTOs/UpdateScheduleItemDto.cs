namespace SmartDigitalPsico.Domain.DTO.Schedule.UpdateDTOs
{
    /// <summary>
    /// Classe responsável por UpdateScheduleItemDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdateScheduleItemDto : ScheduleItemBaseDto
    {
        // ID é necessário para atualização
        public long Id { get; set; }
    }
}

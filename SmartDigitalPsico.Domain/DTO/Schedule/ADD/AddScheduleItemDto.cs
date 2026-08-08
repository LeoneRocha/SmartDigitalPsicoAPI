using SmartDigitalPsico.Domain.DTO.Schedule.Common;

namespace SmartDigitalPsico.Domain.DTO.Schedule.ADD
{
    /// <summary>
    /// Classe responsável por AddScheduleItemDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddScheduleItemDto : ScheduleItemBaseDto
    {
        // Campos específicos para adição, se necessário
        public bool IsNew { get; set; }
    }
}

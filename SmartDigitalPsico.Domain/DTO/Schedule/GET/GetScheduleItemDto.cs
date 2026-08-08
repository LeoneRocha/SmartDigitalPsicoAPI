using SmartDigitalPsico.Domain.DTO.Schedule.Common;

namespace SmartDigitalPsico.Domain.DTO.Schedule.GET
{
    /// <summary>
    /// Classe responsável por GetScheduleItemDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetScheduleItemDto : ScheduleItemBaseDto
    {
        public long Id { get; set; }
        public string TokenRecurrence { get; set; } = string.Empty;
        public bool IsPast { get; set; } // Indica se o evento já passou
    }
}

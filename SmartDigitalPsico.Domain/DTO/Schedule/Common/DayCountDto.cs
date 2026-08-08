namespace SmartDigitalPsico.Domain.DTO.Schedule.Common
{
    /// <summary>
    /// Classe responsável por DayCountDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class DayCountDto
    {
        public DayOfWeek Day { get; set; }
        public int Count { get; set; }
    }
}

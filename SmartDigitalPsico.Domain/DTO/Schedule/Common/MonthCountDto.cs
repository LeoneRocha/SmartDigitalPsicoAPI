namespace SmartDigitalPsico.Domain.DTO.Schedule.Common
{
    /// <summary>
    /// Classe responsável por MonthCountDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class MonthCountDto
    {
        public int Month { get; set; }
        public int Count { get; set; }
    }
}

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar.Common
{
    /// <summary>
    /// Classe responsável por DeleteMedicalCalendarDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class DeleteMedicalCalendarDto
    {
        public long Id { get; set; }
        public bool DeleteSeries { get; set; }
        public string TokenRecurrence { get; set; } = string.Empty;
        public long MedicalId { get; set; }
        public long PatientId { get; set; }
    }
}

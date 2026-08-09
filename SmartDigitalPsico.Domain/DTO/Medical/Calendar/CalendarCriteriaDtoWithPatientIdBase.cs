namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    /// <summary>
    /// Classe responsável por CalendarCriteriaDtoWithPatientIdBase.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public abstract class CalendarCriteriaDtoWithPatientIdBase : CalendarCriteriaDtoBase
    {
        public long PatientId { get; set; }
    }
}

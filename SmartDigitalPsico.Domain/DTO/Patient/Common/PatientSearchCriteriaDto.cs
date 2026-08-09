namespace SmartDigitalPsico.Domain.DTO.Patient.Common
{
    /// <summary>
    /// Classe responsável por PatientSearchCriteriaDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class PatientSearchCriteriaDto
    {
        public long MedicalId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}

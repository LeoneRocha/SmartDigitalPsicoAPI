using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientMedicationInformation
{
    /// <summary>
    /// Classe responsável por UpdatePatientMedicationInformationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdatePatientMedicationInformationDto : EntityDtoBase
    {
        #region Columns 
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Dosage { get; set; } = string.Empty;  
        public string Posology { get; set; } = string.Empty;
        public string MainDrug { get; set; } = string.Empty;
        #endregion Columns 
    }
}

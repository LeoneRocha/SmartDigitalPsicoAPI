using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientMedicationInformation
{
    /// <summary>
    /// Classe responsável por AddPatientMedicationInformationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddPatientMedicationInformationDto : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityDtoAdd
    {
        #region Relationship  
        public long PatientId { get; set; }
        #endregion Relationship

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

using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientMedicationInformation
{
    public class AddPatientMedicationInformationDto : IEntityDtoAdd
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

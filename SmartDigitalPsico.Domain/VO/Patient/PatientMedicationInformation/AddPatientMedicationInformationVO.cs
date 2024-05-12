using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientMedicationInformation
{
    public class AddPatientMedicationInformationVO : IEntityVOAdd
    {
        #region Relationship 
        [Required]
        public long PatientId { get; set; }

        #endregion Relationship

        #region Columns 

        [MaxLength(255)]
        [Required]
        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [MaxLength(255)]
        public string Dosage { get; set; } = string.Empty;

        [MaxLength(255)]
        public string Posology { get; set; } = string.Empty;

        [MaxLength(255)]
        public string MainDrug { get; set; } = string.Empty;

        #endregion Columns  
    }
}

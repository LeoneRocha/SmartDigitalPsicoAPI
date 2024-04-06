using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientRecord
{
    public class AddPatientRecordVO : IEntityVOAdd
    {
        #region Relationship 
        [Required]
        public long PatientId { get; set; }

        #endregion Relationship

        #region Columns 

        [MaxLength(255)]
        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Annotation { get; set; } = string.Empty;
        [Required]
        public DateTime AnnotationDate { get; set; }

        #endregion Columns  
    }
}
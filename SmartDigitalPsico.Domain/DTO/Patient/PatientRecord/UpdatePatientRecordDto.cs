using SmartDigitalPsico.Domain.DTO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientRecord
{
    public class UpdatePatientRecordDto : EntityDtoBase
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
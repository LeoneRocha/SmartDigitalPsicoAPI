using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientRecord
{
    public class AddPatientRecordDto : IEntityDtoAdd
    {
        #region Relationship  
        public long PatientId { get; set; }

        #endregion Relationship

        #region Columns  
        public string Description { get; set; } = string.Empty; 
        public string Annotation { get; set; } = string.Empty; 
        public DateTime AnnotationDate { get; set; }
        #endregion Columns  
    }
}
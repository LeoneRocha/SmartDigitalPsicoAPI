using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientRecord
{
    /// <summary>
    /// Classe responsável por UpdatePatientRecordDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdatePatientRecordDto : EntityDtoBase
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

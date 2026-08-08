namespace SmartDigitalPsico.Domain.DTO.Patient.ADD
{
    /// <summary>
    /// Classe responsável por AddPatientRecordDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddPatientRecordDto : SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd
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

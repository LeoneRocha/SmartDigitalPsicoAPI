using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;


namespace SmartDigitalPsico.Domain.DTO.Patient.PatientRecord
{
    /// <summary>
    /// Classe responsável por GetPatientRecordDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetPatientRecordDto : SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Contracts.EntityDtoBase, ISupportsHyperMedia
    { 
        #region Relationship  
        public GetPatientDto Patient { get; set; } = new GetPatientDto();
        #endregion Relationship

        #region Columns 
        public string Description { get; set; } = string.Empty;
        public string Annotation { get; set; } = string.Empty;
        public DateTime AnnotationDate { get; set; }
        #endregion Columns  
        public List<SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
    }
}

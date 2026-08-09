using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Domain.DTO.Patient.GET
{
    /// <summary>
    /// Classe responsável por GetPatientRecordDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetPatientRecordDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBase, ISupportsHyperMedia
    {
        #region Relationship  
        public GetPatientDto Patient { get; set; } = new GetPatientDto();
        #endregion Relationship

        #region Columns 
        public string Description { get; set; } = string.Empty;
        public string Annotation { get; set; } = string.Empty;
        public DateTime AnnotationDate { get; set; }
        #endregion Columns  
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
    }
}

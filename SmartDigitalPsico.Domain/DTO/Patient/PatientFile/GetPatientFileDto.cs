using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;


namespace SmartDigitalPsico.Domain.DTO.Patient.PatientFile
{
    /// <summary>
    /// Classe responsável por GetPatientFileDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetPatientFileDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBase, ISupportsHyperMedia
    {
        #region Relationship  
        public GetPatientDto Patient { get; set; } = new GetPatientDto();
        #endregion Relationship

        #region Columns  
        public string Description { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
        public string FileName { get; set; } = string.Empty;
        #endregion Columns  
    }
}

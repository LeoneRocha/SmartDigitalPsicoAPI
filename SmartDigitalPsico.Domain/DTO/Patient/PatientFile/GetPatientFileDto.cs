using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;


namespace SmartDigitalPsico.Domain.DTO.Patient.PatientFile
{
    /// <summary>
    /// Classe responsável por GetPatientFileDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetPatientFileDto : SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Contracts.EntityDtoBase, ISupportsHyperMedia
    {
        #region Relationship  
        public GetPatientDto Patient { get; set; } = new GetPatientDto();
        #endregion Relationship

        #region Columns  
        public string Description { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public List<SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
        public string FileName { get; set; } = string.Empty;
        #endregion Columns  
    }
}

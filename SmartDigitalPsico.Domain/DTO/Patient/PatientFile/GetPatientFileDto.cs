using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientFile
{
    /// <summary>
    /// Classe responsável por GetPatientFileDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetPatientFileDto : EntityDtoBase, ISupportsHyperMedia
    {
        #region Relationship  
        public GetPatientDto Patient { get; set; } = new GetPatientDto();
        #endregion Relationship

        #region Columns  
        public string Description { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
        public string FileName { get; set; } = string.Empty;
        #endregion Columns  
    }
}

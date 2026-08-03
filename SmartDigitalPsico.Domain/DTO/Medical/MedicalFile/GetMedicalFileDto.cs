using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalFile
{
    /// <summary>
    /// Classe responsável por GetMedicalFileDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetMedicalFileDto : FileBaseIdDto, ISupportsHyperMedia
    {
        #region Relationship  
        public GetMedicalDto Medical { get; set; } = new GetMedicalDto();

        #endregion Relationship
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>(); 
        public FileStream? DataFileStream { get; set; }
        public string FileUrl { get; set; } = string.Empty;
    }
}

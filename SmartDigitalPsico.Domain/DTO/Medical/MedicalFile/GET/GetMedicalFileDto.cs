using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;

using SmartDigitalPsico.Domain.DTO.Common;
using SmartDigitalPsico.Domain.DTO.Medical.GET;
namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.GET
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
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>(); 
        public FileStream? DataFileStream { get; set; }
        public string FileUrl { get; set; } = string.Empty;
    }
}

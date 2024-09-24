using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalFile
{
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
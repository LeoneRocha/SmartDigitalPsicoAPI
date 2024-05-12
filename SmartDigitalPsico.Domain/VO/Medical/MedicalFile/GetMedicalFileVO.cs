using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Domain.VO.Medical.MedicalFile
{
    public class GetMedicalFileVO : FileBaseIdVO, ISupportsHyperMedia
    {
        #region Relationship  
        public GetMedicalVO Medical { get; set; } = new GetMedicalVO();

        #endregion Relationship
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

        public FileStream? DataFileStream { get; set; }
        public string FileUrl { get; set; } = string.Empty;
    }
}
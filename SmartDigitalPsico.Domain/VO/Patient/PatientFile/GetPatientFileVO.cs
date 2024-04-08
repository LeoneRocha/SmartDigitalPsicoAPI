using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientFile
{
    public class GetPatientFileVO : EntityVOBase, ISupportsHyperMedia
    {
        #region Relationship  
        public GetPatientVO Patient { get; set; } = new GetPatientVO();

        #endregion Relationship

        #region Columns  

        public string Description { get; set; } = string.Empty;

        public string FilePath { get; set; } = string.Empty;

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

        public string FileName { get; set; } = string.Empty;

        #endregion Columns  

    }
}
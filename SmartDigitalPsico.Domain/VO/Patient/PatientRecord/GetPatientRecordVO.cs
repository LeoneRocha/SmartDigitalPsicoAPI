using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientRecord
{
    public class GetPatientRecordVO : EntityVOBase, ISupportsHyperMedia
    {
         
        #region Relationship  
        public GetPatientVO Patient { get; set; }

        #endregion Relationship

        #region Columns 

        public string Description { get; set; } = string.Empty;

        public string Annotation { get; set; } = string.Empty;
        public DateTime AnnotationDate { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
        #endregion Columns  

    }
}
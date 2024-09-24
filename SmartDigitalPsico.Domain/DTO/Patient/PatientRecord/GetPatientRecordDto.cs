using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientRecord
{
    public class GetPatientRecordDto : EntityDtoBase, ISupportsHyperMedia
    { 
        #region Relationship  
        public GetPatientDto Patient { get; set; } = new GetPatientDto();
        #endregion Relationship

        #region Columns 
        public string Description { get; set; } = string.Empty;
        public string Annotation { get; set; } = string.Empty;
        public DateTime AnnotationDate { get; set; }
        #endregion Columns  
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
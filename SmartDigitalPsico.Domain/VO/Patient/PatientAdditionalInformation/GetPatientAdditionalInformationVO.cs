using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientAdditionalInformation
{
    public class GetPatientAdditionalInformationVO : EntityVOBase, ISupportsHyperMedia
    { 
        #region Relationship  
        public GetPatientVO Patient { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
        #endregion Relationship

        #region Columns 

        public string FollowUp_Psychiatric { get; set; } = string.Empty;

        public string FollowUp_Neurological { get; set; } = string.Empty;

        #endregion Columns 
    }
}
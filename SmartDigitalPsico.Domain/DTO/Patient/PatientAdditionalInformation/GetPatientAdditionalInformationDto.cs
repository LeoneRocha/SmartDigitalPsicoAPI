using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientAdditionalInformation
{
    public class GetPatientAdditionalInformationDto : EntityDtoBase, ISupportsHyperMedia
    { 
        #region Relationship  
        public GetPatientDto Patient { get; set; } = new GetPatientDto(); 

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
        #endregion Relationship

        #region Columns 

        public string FollowUp_Psychiatric { get; set; } = string.Empty;

        public string FollowUp_Neurological { get; set; } = string.Empty;

        #endregion Columns 
    }
}
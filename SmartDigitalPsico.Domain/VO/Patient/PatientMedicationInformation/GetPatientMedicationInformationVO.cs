using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientMedicationInformation
{
    public class GetPatientMedicationInformationVO : EntityVOBase, ISupportsHyperMedia
    { 
          
        #region Relationship  
        public GetPatientVO Patient { get; set; } = new GetPatientVO();

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
        #endregion Relationship

        #region Columns 

        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string? Dosage { get; set; }

        public string? Posology { get; set; }

        public string? MainDrug { get; set; }

        #endregion Columns   
    }
}
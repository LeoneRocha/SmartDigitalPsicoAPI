using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientMedicationInformation
{
    public class GetPatientMedicationInformationDto : EntityDtoBase, ISupportsHyperMedia
    {           
        #region Relationship  
        public GetPatientDto Patient { get; set; } = new GetPatientDto();
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
        #endregion Relationship

        #region Columns 
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Dosage { get; set; } = string.Empty;
        public string Posology { get; set; } = string.Empty;
        public string MainDrug { get; set; } = string.Empty;
        #endregion Columns   
    }
}
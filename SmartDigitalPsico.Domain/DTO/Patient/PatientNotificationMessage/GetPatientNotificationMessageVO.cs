using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientNotificationMessage
{
    public class GetPatientNotificationMessageVO : EntityDtoBase, ISupportsHyperMedia
    { 
         
        #region Relationship  
        public GetPatientDto Patient { get; set; } = new GetPatientDto();

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
        #endregion Relationship

        #region Columns 

        public string Message { get; set; } = string.Empty;

        public bool IsReaded { get; set; }

        public DateTime ReadingDate { get; set; }

        public bool Notified { get; set; }

        public DateTime NotifiedDate { get; set; }

        #endregion Columns 


    }
}
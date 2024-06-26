using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientNotificationMessage
{
    public class GetPatientNotificationMessageVO : EntityVOBase, ISupportsHyperMedia
    { 
         
        #region Relationship  
        public GetPatientVO Patient { get; set; } = new GetPatientVO();

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
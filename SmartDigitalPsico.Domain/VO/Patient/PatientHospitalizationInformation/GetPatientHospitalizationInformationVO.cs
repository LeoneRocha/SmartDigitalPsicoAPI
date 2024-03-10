using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientHospitalizationInformation
{
    public class GetPatientHospitalizationInformationVO : EntityVOBase, ISupportsHyperMedia
    {
        public long Id { get; set; }
        //MUDAR AS RELACOES PARA OBJETOS  
        #region Relationship  
        public GetPatientVO Patient { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
        #endregion Relationship

        #region Columns 

        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string CID { get; set; } = string.Empty;

        public string Observation { get; set; } = string.Empty;

        #endregion Columns 
    }
}
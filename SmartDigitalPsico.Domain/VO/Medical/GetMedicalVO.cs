using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.VO.Contracts;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.Patient;

namespace SmartDigitalPsico.Domain.VO.Medical
{
    public class GetMedicalVO : EntityVOBase, ISupportsHyperMedia
    {
        public string Name { get; set; } = string.Empty;

        #region Relationship

        public GetOfficeVO Office { get; set; }

        public List<GetSpecialtyVO> Specialties { get; set; }

        public List<GetPatientVO> Patients { get; set; }

        #endregion Relationship

        #region Columns

        public string Email { get; set; } = string.Empty;
        public string Accreditation { get; set; } = string.Empty;
        public ETypeAccreditation TypeAccreditation { get; set; }

        #endregion Columns  

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
         

    }
}
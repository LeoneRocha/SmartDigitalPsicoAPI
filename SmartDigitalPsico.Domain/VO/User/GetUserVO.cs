using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.VO.Contracts;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.Medical;

namespace SmartDigitalPsico.Domain.VO.User
{
    public class GetUserVO : EntityVOBaseName, ISupportsHyperMedia
    {
        #region Relationship
        public List<GetRoleGroupVO> RoleGroups { get; set; } = new List<GetRoleGroupVO>();

        public long? MedicalId { get; set; }

        public GetMedicalVO Medical { get; set; } = new GetMedicalVO();

        #endregion Relationship


        public string Login { get; set; } = string.Empty;

        #region Columns  

        public string? Role { get; set; }

        public bool? Admin { get; set; }

        public string? Language { get; set; }

        public string? TimeZone { get; set; }

        #endregion Columns 

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}
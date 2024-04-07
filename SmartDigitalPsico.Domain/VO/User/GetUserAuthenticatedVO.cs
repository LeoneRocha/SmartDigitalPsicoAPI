using SmartDigitalPsico.Domain.VO.Contracts;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.Utils;

namespace SmartDigitalPsico.Domain.VO.User
{
    public class GetUserAuthenticatedVO : EntityVOBase
    {
        public GetUserAuthenticatedVO()
        {
            TokenAuth = new TokenVO();
        }
        public string Name { get; set; } = string.Empty;

        public string Language { get; set; } = string.Empty;

        public TokenVO? TokenAuth { get; set; }
        public List<GetRoleGroupVO> RoleGroups { get; set; } = new List<GetRoleGroupVO>();

        public long? MedicalId { get; set; }
    }
}
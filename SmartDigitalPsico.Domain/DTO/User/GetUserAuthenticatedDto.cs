using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.DTO.User
{
    public class GetUserAuthenticatedDto : EntityDtoBase
    {
        public GetUserAuthenticatedDto()
        {
            TokenAuth = new TokenVO();
        }
        public string Name { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public TokenVO? TokenAuth { get; set; }
        public List<GetRoleGroupDto> RoleGroups { get; set; } = new List<GetRoleGroupDto>();
        public long? MedicalId { get; set; }
    }
}
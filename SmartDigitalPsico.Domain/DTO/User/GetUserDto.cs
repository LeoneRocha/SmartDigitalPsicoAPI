using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Medical;

namespace SmartDigitalPsico.Domain.DTO.User
{
    public class GetUserDto : EntityDtoBaseName, ISupportsHyperMedia
    {
        #region Relationship
        public List<GetRoleGroupDto> RoleGroups { get; set; } = new List<GetRoleGroupDto>();

        public long? MedicalId { get; set; }

        public GetMedicalDto Medical { get; set; } = new GetMedicalDto();

        #endregion Relationship

        public string Login { get; set; } = string.Empty;

        #region Columns  

        public string Role { get; set; } = string.Empty;

        public bool Admin { get; set; }

        public string Language { get; set; } = string.Empty;

        public string TimeZone { get; set; } = string.Empty;

        #endregion Columns 

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}
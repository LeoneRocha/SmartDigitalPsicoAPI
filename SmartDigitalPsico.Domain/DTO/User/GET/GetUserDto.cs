using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.DTO.Medical.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.GET;
using SmartDigitalPsico.Domain.DTO.Medical.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.Common;


namespace SmartDigitalPsico.Domain.DTO.User.GET
{
    /// <summary>
    /// Classe responsável por GetUserDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetUserDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseName, ISupportsHyperMedia
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
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>();

    }
}

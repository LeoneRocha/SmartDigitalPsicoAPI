using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.DTO.User
{
    /// <summary>
    /// Classe responsÃ¡vel por GetUserAuthenticatedDto.
    /// Responsabilidade: DTO de transferÃªncia de dados entre camadas da API.
    /// RelaÃ§Ã£o: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetUserAuthenticatedDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBase
    {
        /// <summary>
        /// MÃ©todo GetUserAuthenticatedDto: consulta e retorna dados.
        /// </summary>
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

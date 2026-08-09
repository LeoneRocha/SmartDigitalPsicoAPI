using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.DTO.User.Common
{
    /// <summary>
    /// Classe responsável por GetUserAuthenticatedDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetUserAuthenticatedDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBase
    {
        /// <summary>
        /// Operação GetUserAuthenticatedDto: consulta e retorna dados.
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

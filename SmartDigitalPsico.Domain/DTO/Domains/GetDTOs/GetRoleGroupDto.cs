using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Domains.GetDTOs
{
    /// <summary>
    /// Classe responsável por GetRoleGroupDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetRoleGroupDto : EntityDtoBaseDomain, ISupportsHyperMedia
    {
        public string RolePolicyClaimCode { get; set; } = string.Empty;
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}

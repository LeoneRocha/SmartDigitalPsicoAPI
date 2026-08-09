using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;

using SmartDigitalPsico.Domain.DTO.Leaves.Common;
namespace SmartDigitalPsico.Domain.DTO.Leaves.GET
{
    /// <summary>
    /// Classe responsável por GetLeavesDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class GetLeavesDto : LeavesBaseDto, ISupportsHyperMedia
    {
        public List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink> Links { get; set; } = new List<SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink>();
    }
}

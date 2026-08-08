using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Filters
{
    /// <summary>
    /// Classe responsável por HyperMediaFilterOptions.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// Relação: usado pelos Controllers na serialização.
    /// </summary>
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}

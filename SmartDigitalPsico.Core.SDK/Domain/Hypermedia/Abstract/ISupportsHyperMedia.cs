namespace SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract
{
    /// <summary>
    /// Interface (contrato) responsável por ISupportsHyperMedia.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// Relação: usado pelos Controllers na serialização.
    /// </summary>
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}

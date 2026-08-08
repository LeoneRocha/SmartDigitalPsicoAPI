using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Domain.Hypermedia.Filters
{
    /// <summary>
    /// Classe responsável por SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaFilterOptions.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// Relação: usado pelos Controllers na serialização.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}

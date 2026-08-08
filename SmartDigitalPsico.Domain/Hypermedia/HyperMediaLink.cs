using System.Text;

namespace SmartDigitalPsico.Domain.Hypermedia
{
    /// <summary>
    /// Classe responsável por SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.HyperMediaLink.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// Relação: usado pelos Controllers na serialização.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class HyperMediaLink
    {
        public string Rel { get; set; } = string.Empty;

        private string href = string.Empty; 
        public string Href
        {
            get
            {
                object _lock = new object();
                lock (_lock)
                {
                    StringBuilder sb = new StringBuilder(href);
                    return sb.Replace("%2F", "/").ToString();
                }
            }
            set
            {
                href = value;
            }
        }
        public string Type { get; set; } = string.Empty;
        public string Method { get; set; } = string.Empty;
    }
}

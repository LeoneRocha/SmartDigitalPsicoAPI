using System.Text;

namespace SmartDigitalPsico.Domain.Hypermedia
{
    /// <summary>
    /// Classe responsável por SmartDigitalPsico.Core.SDK.Domain.Hypermedia.HyperMediaLink.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// Relação: usado pelos Controllers na serialização.
    /// </summary>
        // Movido para SmartDigitalPsico.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
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

namespace SmartDigitalPsico.Domain.Helpers
{
    [AttributeUsage(AttributeTargets.Property)]
    /// <summary>
    /// Classe responsável por OrderAttribute.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
        // Movido para SmartDigitalPsico.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class OrderAttribute : SmartDigitalPsico.Core.SDK.Domain.Helpers.OrderAttribute
    {
        /// <summary>
        /// Método OrderAttribute: executa a operação OrderAttribute.
        /// </summary>
        public OrderAttribute(int order) : base(order)
        {
        }
    }
}

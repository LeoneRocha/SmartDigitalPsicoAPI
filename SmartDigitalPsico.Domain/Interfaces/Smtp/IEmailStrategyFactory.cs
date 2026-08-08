using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;


namespace SmartDigitalPsico.Domain.Interfaces.Smtp
{
    /// <summary>
    /// Interface (contrato) responsável por IEmailStrategyFactory.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IEmailStrategyFactory
    {
        /// <summary>
        /// Método CreateStrategy: cria ou persiste um novo registro/recurso.
        /// </summary>
        IEmailStrategy CreateStrategy(SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.EEmailStrategyType strategyType);
    }
}

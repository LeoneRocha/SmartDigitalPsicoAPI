using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp
{
    /// <summary>
    /// Interface (contrato) responsável por IEmailStrategyFactory.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IEmailStrategyFactory
    {
        /// <summary>
        /// Método CreateStrategy: cria ou persiste um novo registro/recurso.
        /// </summary>
        IEmailStrategy CreateStrategy(EEmailStrategyType strategyType);
    }
}

using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.DTO.SMTP;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{
    /// <summary>
    /// Classe responsável por EmailContext.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class EmailContext
    {
        private readonly IEmailStrategyFactory _emailStrategyFactory;

        /// <summary>
        /// Método EmailContext: executa a operação EmailContext.
        /// </summary>
        public EmailContext(IEmailStrategyFactory emailStrategyFactory)
        {
            _emailStrategyFactory = emailStrategyFactory;
        }

        /// <summary>
        /// Método SendEmailAsync: dispara notificação ou comunicação.
        /// </summary>
        public async Task SendEmailAsync(EEmailStrategyType strategyType, EmailMessageDto emailMessage)
        {
            var strategy = _emailStrategyFactory.CreateStrategy(strategyType);
            await strategy.SendEmailAsync(emailMessage);
        }
    }
}

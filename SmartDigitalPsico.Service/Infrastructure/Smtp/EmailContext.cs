using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.DTO.SMTP;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{
    public class EmailContext
    {
        private readonly IEmailStrategyFactory _emailStrategyFactory;

        public EmailContext(IEmailStrategyFactory emailStrategyFactory)
        {
            _emailStrategyFactory = emailStrategyFactory;
        }

        public async Task SendEmailAsync(EEmailStrategyType strategyType, EmailMessageDto emailMessage)
        {
            var strategy = _emailStrategyFactory.CreateStrategy(strategyType);
            await strategy.SendEmailAsync(emailMessage);
        }
    }
}

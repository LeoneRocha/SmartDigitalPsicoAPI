using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.VO.SMTP;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{
    public class EmailContext
    {
        private readonly IEmailStrategyFactory _emailStrategyFactory;

        public EmailContext(IEmailStrategyFactory emailStrategyFactory)
        {
            _emailStrategyFactory = emailStrategyFactory;
        }

        public async Task SendEmailAsync(EEmailStrategyType strategyType, EmailMessageVO emailMessage)
        {
            var strategy = _emailStrategyFactory.CreateStrategy(strategyType);
            await strategy.SendEmailAsync(emailMessage);
        }
    }
}

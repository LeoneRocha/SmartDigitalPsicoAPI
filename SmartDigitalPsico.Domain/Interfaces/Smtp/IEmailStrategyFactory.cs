using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Smtp
{
    public interface IEmailStrategyFactory
    {
        IEmailStrategy CreateStrategy(EEmailStrategyType strategyType);
    }
}

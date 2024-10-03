using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    public interface ITokenSessionAdapterFactory
    {
        ITokenSessionAdapter Create(string adapterType);
    }
}

using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    public interface ITokenSessionPersistenceFactory
    {
        ITokenSessionAdapter Create(string adapterType);
    }
}

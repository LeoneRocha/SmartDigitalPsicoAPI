using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    public interface ITokenSessionFactory
    {
        ITokenSessionAdapter Create(string adapterType);
    }
}

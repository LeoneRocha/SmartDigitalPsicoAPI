using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    public interface ITokenSessionPersistenceFactory
    {
        ITokenSessionPersistenceAdapter Create(ETokenSessionPersistenceType tokenSessionPersistenceType);
    }
}

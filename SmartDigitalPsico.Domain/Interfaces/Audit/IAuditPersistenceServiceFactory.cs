using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Audit
{ 
    public interface IAuditPersistenceServiceFactory
    {
        IAuditPersistenceService CreateService(EAuditServiceType serviceType);
    }
}

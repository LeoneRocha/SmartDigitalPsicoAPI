using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Audit
{ 
    /// <summary>
    /// Interface (contrato) responsável por IAuditPersistenceServiceFactory.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IAuditPersistenceServiceFactory
    {
        /// <summary>
        /// Método CreateService: cria ou persiste um novo registro/recurso.
        /// </summary>
        IAuditPersistenceService CreateService(EAuditServiceType serviceType);
    }
}

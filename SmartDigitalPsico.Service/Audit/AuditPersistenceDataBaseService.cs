using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Audit
{
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;
    /// <summary>
    /// Classe responsável por AuditPersistenceDataBaseService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class AuditPersistenceDataBaseService : IAuditPersistenceService
    { 
        /// <summary>
        /// Método AuditPersistenceDataBaseService: executa a operação AuditPersistenceDataBaseService.
        /// </summary>
        public AuditPersistenceDataBaseService()
        {            
        }
        /// <summary>
        /// Método SaveAuditEntries: cria ou persiste um novo registro/recurso.
        /// </summary>
        public void SaveAuditEntries(IEnumerable<AuditDataEntityLog> auditEntries)
        {
        }
        /// <summary>
        /// Método SaveAuditEntry: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task SaveAuditEntry(AuditDataSelectiveEntityLog auditEntry)
        {
            await Task.Run(() =>
            { 
            });
        }
    }
}

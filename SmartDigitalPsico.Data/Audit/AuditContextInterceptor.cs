using Microsoft.EntityFrameworkCore.Diagnostics;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Audit
{
    /// <summary>
    /// Classe responsável por AuditContextInterceptor.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class AuditContextInterceptor : SaveChangesInterceptor, IAuditContextInterceptor
    {
        private readonly IAuditContextService _auditService;
        private readonly IAuditPersistenceService _auditPersistenceService;
        private readonly EAuditServiceType _serviceType;

        /// <summary>
        /// Método AuditContextInterceptor: executa a operação AuditContextInterceptor.
        /// </summary>
        public AuditContextInterceptor(IAuditContextService auditService, IAuditPersistenceServiceFactory auditPersistenceServiceFactory)
        {
            _serviceType = EAuditServiceType.Database;
            _auditService = auditService;
            _auditPersistenceService = auditPersistenceServiceFactory.CreateService(_serviceType);
        }
        /// <summary>
        /// Método SavedChanges: cria ou persiste um novo registro/recurso.
        /// </summary>
        public override int SavedChanges(SaveChangesCompletedEventData eventData, int result)
        {
            var auditEntries = _auditService.OnBeforeSaveChanges(eventData.Context!);

            if (auditEntries.Count > 0)
            {
                if (_serviceType == EAuditServiceType.Database)
                {
                    var context = eventData.Context!;
                    var newEntries = _auditService.GetNewEntries(context, auditEntries);

                    if (newEntries.Count > 0)
                    {
                        context.Set<AuditDataEntityLog>().AddRange(newEntries);
                        return base.SavedChanges(eventData, result);
                    }
                }
                else
                {
                    _auditPersistenceService.SaveAuditEntries(auditEntries);
                }
            }
            return result;
        }

        /// <summary>
        /// Método SavingChangesAsync: executa a operação SavingChangesAsync.
        /// </summary>
        public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            var auditEntries = _auditService.OnBeforeSaveChanges(eventData.Context!);
            if (auditEntries.Count > 0)
            {
                if (_serviceType == EAuditServiceType.Database)
                {
                    var context = eventData.Context!;
                    var newEntries = _auditService.GetNewEntries(context, auditEntries);

                    if (newEntries.Count > 0)
                    {
                        context.Set<AuditDataEntityLog>().AddRange(newEntries);
                        return await base.SavingChangesAsync(eventData, result, cancellationToken);
                    }
                }
                else
                {
                    _auditPersistenceService.SaveAuditEntries(auditEntries);
                }
            }
            return result;
        }
    }
}

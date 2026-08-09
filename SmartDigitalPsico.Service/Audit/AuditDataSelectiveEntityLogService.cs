using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.DTO.Gender.ADD;
using SmartDigitalPsico.Domain.DTO.Office.ADD;
using SmartDigitalPsico.Domain.DTO.RoleGroup.ADD;
using SmartDigitalPsico.Domain.DTO.Leaves.ADD;
using SmartDigitalPsico.Domain.DTO.Specialty.ADD;
using SmartDigitalPsico.Domain.DTO.Notification.ADD;
using SmartDigitalPsico.Domain.DTO.Application.ADD;
using SmartDigitalPsico.Domain.DTO.Audit.ADD;

using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service
{
                                    /// <summary>
    /// Classe responsável por AuditDataSelectiveEntityLogService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class AuditDataSelectiveEntityLogService
        : SmartDigitalPsico.Service.EntityBaseService<AuditDataSelectiveEntityLog, GetAuditDataSelectiveEntityLogDto>, IAuditDataSelectiveEntityLogService
    {
        private readonly ISharedDependenciesConfig _sharedDependenciesConfig;

        /// <summary>
        /// Operação AuditDataSelectiveEntityLogService: executa a operação AuditDataSelectiveEntityLogService.
        /// </summary>
        public AuditDataSelectiveEntityLogService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IAuditDataSelectiveEntityLogRepository entityRepository,
            IValidator<AuditDataSelectiveEntityLog> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {

            _sharedDependenciesConfig = sharedDependenciesConfig;
        }
        /// <summary>
        /// Operação Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public override Task<ServiceResponse<GetAuditDataSelectiveEntityLogDto>> Create(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Operação Save: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task Save(object entryOld, object entryNew, string operation, string[] propertiesToIgnore)
        {
            AddAuditDataSelectiveEntityLogDto? auditEntry = null;
            try
            {
                auditEntry = AuditLogHelper.CreateAuditEntry(entryOld, entryNew, operation, propertiesToIgnore);
                await Create(auditEntry);
            }
            catch (Exception ex)
            {
                if (auditEntry != null)
                {
                    _logger.Information(" Entity Edited | Table: {Table} | Operation: {Operation} | KeyValue: {KeyValues} | UserID: {UserID}| User Name: {UserAuditedLogin} | Date: {Date}",
                      auditEntry.TableName, auditEntry.Operation, auditEntry.KeyValue, auditEntry.UserAuditedId ?? 0, auditEntry.UserAuditedLogin, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeCustomFormat(auditEntry.AuditDate));
                }
                _sharedDependenciesConfig.Logger.Error(ex, "Error writing log");
            }
        }
    }
}


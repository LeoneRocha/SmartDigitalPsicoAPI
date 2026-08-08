using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;

using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    /// <summary>
    /// Classe responsÃ¡vel por AuditDataSelectiveEntityLogService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// RelaÃ§Ã£o: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class AuditDataSelectiveEntityLogService
        : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<AuditDataSelectiveEntityLog, GetAuditDataSelectiveEntityLogDto>, IAuditDataSelectiveEntityLogService
    {
        private readonly ISharedDependenciesConfig _sharedDependenciesConfig;

        /// <summary>
        /// MÃ©todo AuditDataSelectiveEntityLogService: executa a operaÃ§Ã£o AuditDataSelectiveEntityLogService.
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
        /// MÃ©todo Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public override Task<ServiceResponse<GetAuditDataSelectiveEntityLogDto>> Create(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// MÃ©todo Save: cria ou persiste um novo registro/recurso.
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


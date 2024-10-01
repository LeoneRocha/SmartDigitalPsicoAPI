using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    public class AuditDataSelectiveEntityLogService
        : EntityBaseService<AuditDataSelectiveEntityLog, AddAuditDataSelectiveEntityLogDto, UpdateAuditDataSelectiveEntityLogDto, GetAuditDataSelectiveEntityLogDto, IAuditDataSelectiveEntityLogRepository>, IAuditDataSelectiveEntityLogService
    {
        private readonly ISharedDependenciesConfig _sharedDependenciesConfig;

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
        public override Task<ServiceResponse<GetAuditDataSelectiveEntityLogDto>> Create(AddAuditDataSelectiveEntityLogDto item)
        {
            throw new NotImplementedException();
        }

        public async Task Save(object entryOld, object entryNew, string operation, string[] propertiesToIgnore)
        {
            try
            {
                var auditEntry = AuditLogHelper.CreateAuditEntry(entryOld, entryNew, operation, propertiesToIgnore);
                await base.Create(auditEntry);
            }
            catch (Exception ex)
            {
                _sharedDependenciesConfig.Logger.Error(ex, "Erro ao gerar PDF");
            }
        }
    }
}
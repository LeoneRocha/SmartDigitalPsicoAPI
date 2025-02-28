using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    public class NotificationRulesService
      : EntityBaseService<NotificationRules, AddNotificationRulesDto, UpdateNotificationRulesDto, GetNotificationRulesDto, INotificationRulesRepository>, INotificationRulesService
    {
        public NotificationRulesService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            INotificationRulesRepository entityRepository,
            IApplicationLanguageRepository applicationLanguageRepository,
            IValidator<NotificationRules> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        { 
        }
    }
}
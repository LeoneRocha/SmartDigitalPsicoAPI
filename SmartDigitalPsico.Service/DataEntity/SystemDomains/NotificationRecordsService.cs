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
    public class NotificationRecordsService
      : EntityBaseService<NotificationRecords, AddNotificationRecordsDto, UpdateNotificationRecordsDto, GetNotificationRecordsDto, INotificationRecordsRepository>, INotificationRecordsService
    {
        public NotificationRecordsService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            INotificationRecordsRepository entityRepository,
            IApplicationLanguageRepository applicationLanguageRepository,
            IValidator<NotificationRecords> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
        }
    }
}
using AutoMapper;
using SmartDigitalPsico.Domain.DTO.Notification.ADD;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Notification.UPDATE;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class NotificationProfile : Profile
    {
        public NotificationProfile()
        {
            #region NotificationTemplate
            CreateMap<NotificationTemplate, GetNotificationTemplateDto>();
            CreateMap<GetNotificationTemplateDto, NotificationTemplate>();

            CreateMap<AddNotificationTemplateDto, NotificationTemplate>();
            CreateMap<UpdateNotificationTemplateDto, NotificationTemplate>();
            #endregion NotificationTemplate

            #region NotificationRules
            CreateMap<NotificationRule, GetNotificationRulesDto>();
            CreateMap<GetNotificationRulesDto, NotificationRule>();

            CreateMap<AddNotificationRulesDto, NotificationRule>();
            CreateMap<UpdateNotificationRulesDto, NotificationRule>();
            #endregion NotificationRules

            #region NotificationRecords
            CreateMap<NotificationRecord, GetNotificationRecordsDto>();
            CreateMap<GetNotificationRecordsDto, NotificationRecord>();

            CreateMap<AddNotificationRecordsDto, NotificationRecord>();
            CreateMap<UpdateNotificationRecordsDto, NotificationRecord>();
            #endregion NotificationRecords
        }
    }
}

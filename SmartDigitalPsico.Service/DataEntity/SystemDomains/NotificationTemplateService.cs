using FluentValidation;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;
using System.Globalization;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    public class NotificationTemplateService
      : EntityBaseService<Domain.ModelEntity.NotificationTemplate, AddNotificationTemplateDto, UpdateNotificationTemplateDto, GetNotificationTemplateDto, INotificationTemplateRepository>, INotificationTemplateService
    {
        public NotificationTemplateService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            INotificationTemplateRepository entityRepository,
            IApplicationLanguageRepository applicationLanguageRepository,
            IValidator<Domain.ModelEntity.NotificationTemplate> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {

        }
        public override async Task<ServiceResponse<GetNotificationTemplateDto>> Update(UpdateNotificationTemplateDto item)
        {
            item.Body = HtmlSanitizerHelper.Sanitize(item.Body);

            return await base.Update(item);
        }
        public override async Task<ServiceResponse<GetNotificationTemplateDto>> Create(AddNotificationTemplateDto item)
        {
            item.Body = HtmlSanitizerHelper.Sanitize(item.Body);
            return await base.Create(item);
        }

        public async Task<ServiceResponse<GetNotificationTemplateDto>> GetNotificationTemplatesAsync(string tagApi)
        {
            ServiceResponse<GetNotificationTemplateDto> response = new ServiceResponse<GetNotificationTemplateDto>();

            var culturenameCurrent = CultureInfo.CurrentCulture;
            string language = culturenameCurrent.Name;

            Domain.ModelEntity.NotificationTemplate entityResponse = await _entityRepository.GetNotificationTemplateAsync(tagApi, language);

            if (entityResponse != null)
            {
                response.Data = _mapper.Map<GetNotificationTemplateDto>(entityResponse);
                response.Success = true;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);
            }
            else
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
            }
            return response;
        }
    }
}
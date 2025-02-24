using FluentValidation;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
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
using System.Globalization;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    public class EmailTemplateService
      : EntityBaseService<EmailTemplate, AddEmailTemplateDto, UpdateEmailTemplateDto, GetEmailTemplateDto, IEmailTemplateRepository>, IEmailTemplateService
    {
        public EmailTemplateService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IEmailTemplateRepository entityRepository,
            IApplicationLanguageRepository applicationLanguageRepository,
            IValidator<EmailTemplate> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {

        }
        public override async Task<ServiceResponse<GetEmailTemplateDto>> Update(UpdateEmailTemplateDto item)
        {
            item.Body = HtmlSanitizerHelper.Sanitize(item.Body);

            return await base.Update(item);
        }
        public override async Task<ServiceResponse<GetEmailTemplateDto>> Create(AddEmailTemplateDto item)
        {
            item.Body = HtmlSanitizerHelper.Sanitize(item.Body);
            return await base.Create(item);
        }

        public async Task<ServiceResponse<GetEmailTemplateDto>> GetEmailTemplateAsync(string tagApi)
        {
            ServiceResponse<GetEmailTemplateDto> response = new ServiceResponse<GetEmailTemplateDto>();

            var culturenameCurrent = CultureInfo.CurrentCulture;
            string language = culturenameCurrent.Name;

            EmailTemplate entityResponse = await _entityRepository.GetEmailTemplateAsync(tagApi, language);

            if (entityResponse != null)
            {
                response.Data = _mapper.Map<GetEmailTemplateDto>(entityResponse);
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
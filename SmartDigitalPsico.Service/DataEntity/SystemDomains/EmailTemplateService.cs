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
        public override Task<ServiceResponse<GetEmailTemplateDto>> Update(UpdateEmailTemplateDto item)
        {
            item.Body = HtmlSanitizerHelper.Sanitize(item.Body);

            return base.Update(item);   
        }
        public override Task<ServiceResponse<GetEmailTemplateDto>> Create(AddEmailTemplateDto item)
        {
            item.Body = HtmlSanitizerHelper.Sanitize(item.Body);
            return base.Create(item);   
        }
    }
}
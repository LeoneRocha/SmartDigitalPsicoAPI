using FluentValidation;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;
using System.Globalization;

using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    /// <summary>
    /// Classe responsÃ¡vel por NotificationTemplateService.
    /// Responsabilidade: serviÃ§o de entidade de negÃ³cio.
    /// RelaÃ§Ã£o: orquestra repositÃ³rios, validators e mapeamentos.
    /// </summary>
    public class NotificationTemplateService
      : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<Domain.ModelEntity.NotificationTemplate, GetNotificationTemplateDto>, INotificationTemplateService
    {
        /// <summary>
        /// MÃ©todo NotificationTemplateService: executa a operaÃ§Ã£o NotificationTemplateService.
        /// </summary>
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
        /// <summary>
        /// MÃ©todo Update: atualiza um registro/recurso existente.
        /// </summary>
        public override async Task<ServiceResponse<GetNotificationTemplateDto>> Update(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityDto item)
        {
            var dto = (UpdateNotificationTemplateDto)item;
            dto.Body = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.HtmlSanitizerHelper.Sanitize(dto.Body);

            return await base.Update(dto);
        }
        /// <summary>
        /// MÃ©todo Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public override async Task<ServiceResponse<GetNotificationTemplateDto>> Create(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
        {
            var dto = (AddNotificationTemplateDto)item;
            dto.Body = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.HtmlSanitizerHelper.Sanitize(dto.Body);
            return await base.Create(dto);
        }

        /// <summary>
        /// MÃ©todo GetNotificationTemplatesAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<GetNotificationTemplateDto>> GetNotificationTemplatesAsync(string templateKey)
        {
            ServiceResponse<GetNotificationTemplateDto> response = new ServiceResponse<GetNotificationTemplateDto>();

            var culturenameCurrent = CultureInfo.CurrentCulture;
            string language = culturenameCurrent.Name;

            Domain.ModelEntity.NotificationTemplate? entityResponse = await ((INotificationTemplateRepository)_entityRepository).GetNotificationTemplateAsync(templateKey, language);

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


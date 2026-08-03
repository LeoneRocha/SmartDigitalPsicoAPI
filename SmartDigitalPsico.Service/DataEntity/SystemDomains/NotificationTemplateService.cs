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
    /// <summary>
    /// Classe responsável por NotificationTemplateService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class NotificationTemplateService
      : EntityBaseService<Domain.ModelEntity.NotificationTemplate, AddNotificationTemplateDto, UpdateNotificationTemplateDto, GetNotificationTemplateDto, INotificationTemplateRepository>, INotificationTemplateService
    {
        /// <summary>
        /// Método NotificationTemplateService: executa a operação NotificationTemplateService.
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
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public override async Task<ServiceResponse<GetNotificationTemplateDto>> Update(UpdateNotificationTemplateDto item)
        {
            item.Body = HtmlSanitizerHelper.Sanitize(item.Body);

            return await base.Update(item);
        }
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public override async Task<ServiceResponse<GetNotificationTemplateDto>> Create(AddNotificationTemplateDto item)
        {
            item.Body = HtmlSanitizerHelper.Sanitize(item.Body);
            return await base.Create(item);
        }

        /// <summary>
        /// Método GetNotificationTemplatesAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<GetNotificationTemplateDto>> GetNotificationTemplatesAsync(string templateKey)
        {
            ServiceResponse<GetNotificationTemplateDto> response = new ServiceResponse<GetNotificationTemplateDto>();

            var culturenameCurrent = CultureInfo.CurrentCulture;
            string language = culturenameCurrent.Name;

            Domain.ModelEntity.NotificationTemplate? entityResponse = await _entityRepository.GetNotificationTemplateAsync(templateKey, language);

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

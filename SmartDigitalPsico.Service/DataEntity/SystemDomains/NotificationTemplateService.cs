using FluentValidation;
using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.DTO.Gender.UPDATE;
using SmartDigitalPsico.Domain.DTO.Office.UPDATE;
using SmartDigitalPsico.Domain.DTO.RoleGroup.UPDATE;
using SmartDigitalPsico.Domain.DTO.Leaves.UPDATE;
using SmartDigitalPsico.Domain.DTO.Specialty.UPDATE;
using SmartDigitalPsico.Domain.DTO.Notification.UPDATE;
using SmartDigitalPsico.Domain.DTO.Application.UPDATE;
using SmartDigitalPsico.Domain.DTO.Audit.UPDATE;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using System.Globalization;
using SmartDigitalPsico.Domain.DTO.Gender.ADD;
using SmartDigitalPsico.Domain.DTO.Office.ADD;
using SmartDigitalPsico.Domain.DTO.RoleGroup.ADD;
using SmartDigitalPsico.Domain.DTO.Leaves.ADD;
using SmartDigitalPsico.Domain.DTO.Specialty.ADD;
using SmartDigitalPsico.Domain.DTO.Notification.ADD;
using SmartDigitalPsico.Domain.DTO.Application.ADD;
using SmartDigitalPsico.Domain.DTO.Audit.ADD;

using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Notification;
namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    /// <summary>
    /// Classe responsável por NotificationTemplateService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class NotificationTemplateService
      : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<Domain.EntityModels.NotificationTemplate, GetNotificationTemplateDto>, INotificationTemplateService
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
            IValidator<Domain.EntityModels.NotificationTemplate> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {

        }
        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public override async Task<ServiceResponse<GetNotificationTemplateDto>> Update(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDto item)
        {
            var dto = (UpdateNotificationTemplateDto)item;
            dto.Body = SmartDigitalPsico.Core.SDK.Domain.Helpers.HtmlSanitizerHelper.Sanitize(dto.Body);

            return await base.Update(dto);
        }
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public override async Task<ServiceResponse<GetNotificationTemplateDto>> Create(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
        {
            var dto = (AddNotificationTemplateDto)item;
            dto.Body = SmartDigitalPsico.Core.SDK.Domain.Helpers.HtmlSanitizerHelper.Sanitize(dto.Body);
            return await base.Create(dto);
        }

        /// <summary>
        /// Método GetNotificationTemplatesAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<GetNotificationTemplateDto>> GetNotificationTemplatesAsync(string templateKey)
        {
            ServiceResponse<GetNotificationTemplateDto> response = new ServiceResponse<GetNotificationTemplateDto>();

            var culturenameCurrent = CultureInfo.CurrentCulture;
            string language = culturenameCurrent.Name;

            Domain.EntityModels.NotificationTemplate? entityResponse = await ((INotificationTemplateRepository)_entityRepository).GetNotificationTemplateAsync(templateKey, language);

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


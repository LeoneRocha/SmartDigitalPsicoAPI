using FluentValidation;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.DTO.Medical.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.GET;
using SmartDigitalPsico.Domain.DTO.Medical.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.Common;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation.PatientValidations.CustomValidator;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Specialty;
using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    /// <summary>
    /// Classe responsável por MedicalService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class MedicalService
        : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<Medical, GetMedicalDto>, IMedicalService

    {
        private readonly IUserRepository _userRepository;
        private readonly ISpecialtyRepository _specialtyRepository;
        private readonly ISharedServices _sharedServices;

        /// <summary>
        /// Método MedicalService: executa a operação MedicalService.
        /// </summary>
        public MedicalService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IMedicalRepository entityRepository,
            ISpecialtyRepository specialtyRepository,
            IValidator<Medical> entityValidator)
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
            _userRepository = sharedRepositories.UserRepository;
            _specialtyRepository = specialtyRepository;
            _sharedServices = sharedServices;
        }
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public override async Task<ServiceResponse<GetMedicalDto>> Create(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
        {
            var dto = (AddMedicalDto)item;
            Medical entityAdd = _mapper.Map<Medical>(dto);

            #region Relationship

            entityAdd.OfficeId = dto.OfficeId;

            List<Specialty> specialtiesAdd = await _specialtyRepository.FindByIDs(dto.SpecialtiesIds);

            #endregion Relationship

            entityAdd.CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.CreatedUserId = UserId;
            entityAdd.Enable = true;

            entityAdd.Email = entityAdd.Email.ToLower();
            entityAdd.Accreditation = entityAdd.Accreditation.ToLower();

            ServiceResponse<GetMedicalDto> response = await base.Validate(entityAdd);

            if (response.Success)
            {

                entityAdd.SecurityKey = SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateKey();
                Medical entityResponse = await ((IMedicalRepository)_entityRepository).Create(entityAdd);

                entityResponse.MedicalSpecialties = new List<MedicalSpecialty>();
                foreach (var specialty in specialtiesAdd)
                {
                    entityResponse.MedicalSpecialties.Add(new MedicalSpecialty { Medical = entityAdd, Specialty = specialty });
                }
                entityResponse = await ((IMedicalRepository)_entityRepository).Update(entityResponse);
                entityResponse = await ((IMedicalRepository)_entityRepository).FindByID(entityResponse.Id);

                response.Data = _mapper.Map<GetMedicalDto>(entityResponse);

                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCreated, GeneralLanguageMenssageConstants.RegisterCreated);
            }
            return response;
        }

        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public override async Task<ServiceResponse<GetMedicalDto>> Update(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDto item)
        {
            var dto = (UpdateMedicalDto)item;
            ServiceResponse<GetMedicalDto> response = new ServiceResponse<GetMedicalDto>();

            Medical? entityUpdate = await ((IMedicalRepository)_entityRepository).FindByID(dto.Id);
            if (entityUpdate != null)
            {
                #region Relationship
                entityUpdate.OfficeId = dto.OfficeId;

                List<Specialty> specialtiesAdd = await _specialtyRepository.FindByIDs(dto.SpecialtiesIds);

                entityUpdate.MedicalSpecialties.Clear();

                foreach (var specialty in specialtiesAdd)
                {
                    entityUpdate.MedicalSpecialties.Add(new MedicalSpecialty { MedicalId = entityUpdate.Id, SpecialtyId = specialty.Id });
                }

                #endregion Relationship

                entityUpdate.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entityUpdate.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entityUpdate.ModifyUserId = UserId;

                #region Columns
                entityUpdate.Enable = dto.Enable;
                entityUpdate.Accreditation = dto.Accreditation;
                entityUpdate.Name = dto.Name;
                entityUpdate.Email = dto.Email.ToLower();
                entityUpdate.Accreditation = dto.Accreditation.ToLower();

                entityUpdate.StartWorkingTime = dto.StartWorkingTime;
                entityUpdate.EndWorkingTime = dto.EndWorkingTime;
                entityUpdate.PatientIntervalTimeMinutes = dto.PatientIntervalTimeMinutes;
                entityUpdate.WorkingDays = dto.WorkingDays;

                #endregion Columns

                response = await base.Validate(entityUpdate);

                if (response.Success)
                {
                    if (string.IsNullOrEmpty(entityUpdate.SecurityKey))
                        entityUpdate.SecurityKey = SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper.GenerateKey();

                    Medical entityResponse = await ((IMedicalRepository)_entityRepository).Update(entityUpdate);

                    response.Data = _mapper.Map<GetMedicalDto>(entityResponse);

                    response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
                    await notifyAsync(entityResponse);
                }
            }

            return response;
        }

        /// <summary>
        /// Método Delete: remove ou cancela um registro/recurso.
        /// </summary>
        public override Task<ServiceResponse<bool>> Delete(long id)
        {
            return base.EnableOrDisable(id);
        }

        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<List<GetMedicalDto>>> FindAll()
        {
            ServiceResponse<List<GetMedicalDto>> response = await validAccessdmin();

            if (!response.Success)
                return response;

            return await base.FindAll();
        }
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<GetMedicalDto>> FindByID(long id)
        {
            ServiceResponse<GetMedicalDto> response = new ServiceResponse<GetMedicalDto>();

            var validResult = await validAccessdmin();
            response.Success = validResult.Success;
            response.Errors = validResult.Errors;
            response.Message = validResult.Message;

            if (!response.Success)
                return response;

            Medical? entityResponse = await ((IMedicalRepository)_entityRepository).FindByID(id);
            if (entityResponse != null)
            {
                response.Data = _mapper.Map<GetMedicalDto>(entityResponse);

                if (response.Data != null)
                {
                    response.Data.Specialties = entityResponse.MedicalSpecialties
                        .Select(x => x.Specialty)
                        .Where(s => s != null)
                        .Select(s => new GetSpecialtyDto
                        {
                            Description = s!.Description,
                            Id = s.Id,
                            Enable = s.Enable,
                            Language = s.Language,
                        })
                        .ToList();
                }
            }
            response.Success = true;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterFind, GeneralLanguageMenssageConstants.RegisterFind);
            return response;
        }

        private async Task<ServiceResponse<List<GetMedicalDto>>> validAccessdmin()
        {
            ServiceResponse<List<GetMedicalDto>> response = new ServiceResponse<List<GetMedicalDto>>();
            response.Success = true;

            User? userAction = await _userRepository.FindByID(UserId);
            response.Success = userAction != null;
            if (userAction == null)
            {
                return response;
            }
            var validateResult = PatientPermissionMedicalValidator.ValidatePermissionAdmin(userAction);
            if (!string.IsNullOrEmpty(validateResult.ErrorCode))
            {
                response.Success = false;

                response.Message = await GetLocalization(GeneralLanguageKeyConstants.PermissionDenied, GeneralLanguageMenssageConstants.PermissionDenied);

                response.Errors = new List<ErrorResponse>();
                response.Unauthorized = true;
                response.Errors.Add(validateResult);
                return response;
            }
            return response;
        }
        private async Task notifyAsync(Medical entityResponse)
        {
            try
            {
                var templateResult = await _sharedServices.NotificationTemplateService.GetNotificationTemplatesAsync(EmailTemplateTagConstants.MedicalUpdateEmail);

                if (templateResult != null && templateResult.Success && templateResult.Data != null)
                {
                    var template = templateResult.Data;
                    User userAction = await _userRepository.FindByID(UserId);
                    var tokens = new Dictionary<string, string>                {
                        { "UserName", userAction.Name },
                        { "MedicalName", entityResponse.Name },
                        { "MedicalId", entityResponse.Id.ToString() }
                    };

                    var notificationMessageVO = new DataNotificationTemplateVO()
                    {
                        Subject = template.Subject,
                        Body = template.Body,
                        ToEmails = new List<string>() { "leocr_lem@yahoo.com.br" }
                    };
                    await _sharedServices.SendNotificationService.SendNotificationAsync(notificationMessageVO, ENotificationServiceType.Email, tokens);
                }
                else { await fallBackEmail(entityResponse); }
            }
            catch (Exception)
            {
                await fallBackEmail(entityResponse);
            }
        }

        private async Task fallBackEmail(Medical entityResponse)
        {
            DataNotificationTemplateVO fallbackEmail = new DataNotificationTemplateVO()
            {
                Subject = await GetLocalization(GeneralLanguageKeyConstants.MedicalUpdateTitle, GeneralLanguageMenssageConstants.MedicalUpdateTitle),
                Body = $"Médico {entityResponse.Name} ({entityResponse.Id}) atualizado.",
                ToEmails = new List<string>() { "leocr_lem@yahoo.com.br" }
            };
            await _sharedServices.SendNotificationService.SendNotificationAsync(fallbackEmail, ENotificationServiceType.Email, []);
        }
    }
}


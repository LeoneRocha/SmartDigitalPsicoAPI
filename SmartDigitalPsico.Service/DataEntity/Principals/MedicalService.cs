using FluentValidation;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Medical;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Security;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.CustomValidator;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class MedicalService
        : EntityBaseService<Medical, AddMedicalDto, UpdateMedicalDto, GetMedicalDto, IMedicalRepository>, IMedicalService

    {
        private readonly IUserRepository _userRepository;
        private readonly ISpecialtyRepository _specialtyRepository;
        private readonly ISharedServices _sharedServices;

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
        public override async Task<ServiceResponse<GetMedicalDto>> Create(AddMedicalDto item)
        {
            Medical entityAdd = _mapper.Map<Medical>(item);

            #region Relationship

            entityAdd.OfficeId = item.OfficeId;

            List<Specialty> specialtiesAdd = await _specialtyRepository.FindByIDs(item.SpecialtiesIds);

            #endregion Relationship

            entityAdd.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
            entityAdd.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
            entityAdd.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();
            entityAdd.CreatedUserId = UserId;
            entityAdd.Enable = true;

            entityAdd.Email = entityAdd.Email.ToLower();
            entityAdd.Accreditation = entityAdd.Accreditation.ToLower();

            ServiceResponse<GetMedicalDto> response = await base.Validate(entityAdd);

            if (response.Success)
            {

                entityAdd.SecurityKey = AesKeyGeneratorHelper.GenerateKey();
                Medical entityResponse = await _entityRepository.Create(entityAdd);

                entityResponse.MedicalSpecialties = new List<MedicalSpecialty>();
                foreach (var specialty in specialtiesAdd)
                {
                    entityResponse.MedicalSpecialties.Add(new MedicalSpecialty { Medical = entityAdd, Specialty = specialty });
                }
                entityResponse = await _entityRepository.Update(entityResponse);
                entityResponse = await _entityRepository.FindByID(entityResponse.Id);

                response.Data = _mapper.Map<GetMedicalDto>(entityResponse);

                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCreated, GeneralLanguageMenssageConstants.RegisterCreated);
            }
            return response;
        }

        public override async Task<ServiceResponse<GetMedicalDto>> Update(UpdateMedicalDto item)
        {
            ServiceResponse<GetMedicalDto> response = new ServiceResponse<GetMedicalDto>();

            Medical? entityUpdate = await _entityRepository.FindByID(item.Id);
            if (entityUpdate != null)
            {
                #region Relationship
                entityUpdate.OfficeId = item.OfficeId;

                List<Specialty> specialtiesAdd = await _specialtyRepository.FindByIDs(item.SpecialtiesIds);

                entityUpdate.MedicalSpecialties.Clear();

                foreach (var specialty in specialtiesAdd)
                {
                    entityUpdate.MedicalSpecialties.Add(new MedicalSpecialty { MedicalId = entityUpdate.Id, SpecialtyId = specialty.Id });
                }

                #endregion Relationship

                entityUpdate.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                entityUpdate.LastAccessDate = DateHelper.GetDateTimeNowFromUtc();
                entityUpdate.ModifyUserId = UserId;

                #region Columns
                entityUpdate.Enable = item.Enable;
                entityUpdate.Accreditation = item.Accreditation;
                entityUpdate.Name = item.Name;
                entityUpdate.Email = item.Email.ToLower();
                entityUpdate.Accreditation = item.Accreditation.ToLower();

                entityUpdate.StartWorkingTime = item.StartWorkingTime;
                entityUpdate.EndWorkingTime = item.EndWorkingTime;
                entityUpdate.PatientIntervalTimeMinutes = item.PatientIntervalTimeMinutes;
                entityUpdate.WorkingDays = item.WorkingDays;

                #endregion Columns

                response = await base.Validate(entityUpdate);

                if (response.Success)
                {
                    if (string.IsNullOrEmpty(entityUpdate.SecurityKey))
                        entityUpdate.SecurityKey = AesKeyGeneratorHelper.GenerateKey();

                    Medical entityResponse = await _entityRepository.Update(entityUpdate);

                    response.Data = _mapper.Map<GetMedicalDto>(entityResponse);

                    response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
                    await notifyAsync(entityResponse);
                }
            }

            return response;
        }


        public override Task<ServiceResponse<bool>> Delete(long id)
        {
            return base.EnableOrDisable(id);
        }

        public override async Task<ServiceResponse<List<GetMedicalDto>>> FindAll()
        {
            ServiceResponse<List<GetMedicalDto>> response = await validAccessdmin();

            if (!response.Success)
                return response;

            return await base.FindAll();
        }
        public override async Task<ServiceResponse<GetMedicalDto>> FindByID(long id)
        {
            ServiceResponse<GetMedicalDto> response = new ServiceResponse<GetMedicalDto>();

            var validResult = await validAccessdmin();
            response.Success = validResult.Success;
            response.Errors = validResult.Errors;
            response.Message = validResult.Message;

            if (!response.Success)
                return response;

            Medical? entityResponse = await _entityRepository.FindByID(id);
            if (entityResponse != null)
            {
                response.Data = _mapper.Map<GetMedicalDto>(entityResponse);

                if (response.Data != null)
                {
                    response.Data.Specialties = new List<GetSpecialtyDto>();
                    foreach (var item in entityResponse.MedicalSpecialties.Select(x => x.Specialty))
                    {
                        if (item != null)
                        {
                            response.Data.Specialties.Add(new GetSpecialtyDto()
                            {
                                Description = item.Description,
                                Id = item.Id,
                                Enable = item.Enable,
                                Language = item.Language,
                            });
                        }

                    }
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
                Body = $"M�dico {entityResponse.Name} ({entityResponse.Id}) atualizado.",
                ToEmails = new List<string>() { "leocr_lem@yahoo.com.br" }
            };
            await _sharedServices.SendNotificationService.SendNotificationAsync(fallbackEmail, ENotificationServiceType.Email, []);
        }
    }
}
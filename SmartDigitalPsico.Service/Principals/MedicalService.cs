using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.CustomValidator;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.Medical;
using SmartDigitalPsico.Service.Generic;
using SmartDigitalPsico.Service.SystemDomains;

namespace SmartDigitalPsico.Service.Principals
{
    public class MedicalService
        : EntityBaseService<Medical, AddMedicalVO, UpdateMedicalVO, GetMedicalVO, IMedicalRepository>, IMedicalService

    {
        private readonly IMapper _mapper;
        private readonly IMedicalRepository _entityRepository;
        private readonly IUserRepository _userRepository;
        private readonly ISpecialtyRepository _specialtyRepository;
        public MedicalService(IMapper mapper, IMedicalRepository entityRepository,
            IUserRepository userRepository
            , ISpecialtyRepository specialtyRepository
            , IValidator<Medical> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _entityRepository = entityRepository;
            _userRepository = userRepository;
            _specialtyRepository = specialtyRepository;
        }
        public override async Task<ServiceResponse<GetMedicalVO>> Create(AddMedicalVO item)
        {
            Medical entityAdd = _mapper.Map<Medical>(item);

            #region Relationship

            entityAdd.OfficeId = item.OfficeId;

            List<Specialty> specialtiesAdd = await _specialtyRepository.FindByIDs(item.SpecialtiesIds);

            #endregion Relationship

            entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();
            entityAdd.CreatedUserId = this.UserId;
            entityAdd.Enable = true;

            ServiceResponse<GetMedicalVO> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                Medical entityResponse = await _entityRepository.Create(entityAdd);


                entityResponse.MedicalSpecialties = new List<MedicalSpecialty>();
                foreach (var specialty in specialtiesAdd)
                {
                    entityResponse.MedicalSpecialties.Add(new MedicalSpecialty { Medical = entityAdd, Specialty = specialty });
                }
                entityResponse = await _entityRepository.Update(entityResponse);
                entityResponse = await _entityRepository.FindByID(entityResponse.Id) ?? entityResponse;

                response.Data = _mapper.Map<GetMedicalVO>(entityResponse);
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("MedicalRegistred", base._applicationLanguageRepository, base._cacheService);
            }
            return response;
        }

        public override async Task<ServiceResponse<GetMedicalVO>> Update(UpdateMedicalVO item)
        {
            ServiceResponse<GetMedicalVO> response = new ServiceResponse<GetMedicalVO>();

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

                entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();
                entityUpdate.LastAccessDate = DataHelper.GetDateTimeNow();
                entityUpdate.ModifyUserId = this.UserId;

                #region Columns
                entityUpdate.Enable = item.Enable;
                entityUpdate.Accreditation = item.Accreditation;
                entityUpdate.Name = item.Name;
                entityUpdate.Email = item.Email;

                #endregion Columns

                response = await base.Validate(entityUpdate);

                if (response.Success)
                {
                    Medical entityResponse = await _entityRepository.Update(entityUpdate);

                    response.Data = _mapper.Map<GetMedicalVO>(entityResponse);
                    response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("MedicalUpdated", base._applicationLanguageRepository, base._cacheService);
                }
            }

            return response;
        }

        public override Task<ServiceResponse<bool>> Delete(long id)
        {
            return base.EnableOrDisable(id);
        }

        public override async Task<ServiceResponse<List<GetMedicalVO>>> FindAll()
        {
            ServiceResponse<List<GetMedicalVO>> response = await validAccessdmin();

            if (!response.Success)
                return response;

            return await base.FindAll();
        }
        public override async Task<ServiceResponse<GetMedicalVO>> FindByID(long id)
        {
            ServiceResponse<GetMedicalVO> response = new ServiceResponse<GetMedicalVO>();

            var validResult = await validAccessdmin();
            response.Success = validResult.Success;
            response.Errors = validResult.Errors;
            response.Message = validResult.Message;

            if (!response.Success)
                return response;

            Medical? entityResponse = await _entityRepository.FindByID(id);
            if (entityResponse != null)
            {
                response.Data = _mapper.Map<GetMedicalVO>(entityResponse);

                if (response.Data != null)
                {
                    response.Data.Specialties = new List<GetSpecialtyVO>();
                    foreach (var item in entityResponse.MedicalSpecialties.Select(x => x.Specialty))
                    {
                        response.Data.Specialties.Add(new GetSpecialtyVO()
                        {
                            Description = item.Description,
                            Id = item.Id,
                            Enable = item.Enable,
                            Language = item.Language,
                        });
                    }
                }
            }
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterFind", base._applicationLanguageRepository, base._cacheService);

            return response;
        }

        private async Task<ServiceResponse<List<GetMedicalVO>>> validAccessdmin()
        {
            ServiceResponse<List<GetMedicalVO>> response = new ServiceResponse<List<GetMedicalVO>>();
            response.Success = true;

            User? userAction = await _userRepository.FindByID(this.UserId);
            response.Success = userAction != null;
            if (userAction == null)
            {
                return response;
            }
            var validateResult = PatientPermissionMedicalValidator.ValidatePermissionAdmin(userAction);          
            if (!string.IsNullOrEmpty(validateResult.ErrorCode))
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("PermissionDenied", base._applicationLanguageRepository, base._cacheService);

                response.Errors = new List<ErrorResponse>();
                response.Unauthorized = true;
                if (validateResult != null)
                {
                    response.Errors.Add(validateResult);
                }
                return response;
            }
            return response;

        }
    }
}
using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Medical;
using SmartDigitalPsico.Service.Generic;
using SmartDigitalPsico.Service.SystemDomains;
using SmartDigitalPsico.Domain.Validation.PatientValidations.CustomValidator;

namespace SmartDigitalPsico.Service.Principals
{
    public class MedicalService
        : EntityBaseService<Medical, AddMedicalVO, UpdateMedicalVO, GetMedicalVO, IMedicalRepository>, IMedicalService

    {
        private readonly IMapper _mapper;
        private readonly IMedicalRepository _entityRepository;
        private readonly IUserRepository _userRepository;
        private readonly IOfficeRepository _officeRepository;
        private readonly ISpecialtyRepository _specialtyRepository;
        IConfiguration _configuration;
        public MedicalService(IMapper mapper, IMedicalRepository entityRepository, IConfiguration configuration,
            IUserRepository userRepository, IOfficeRepository officeRepository
            , ISpecialtyRepository specialtyRepository
            , IValidator<Medical> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _configuration = configuration;
            _entityRepository = entityRepository;
            _userRepository = userRepository;
            _officeRepository = officeRepository;
            _specialtyRepository = specialtyRepository;
        }
        public override async Task<ServiceResponse<GetMedicalVO>> Create(AddMedicalVO item)
        {
            ServiceResponse<GetMedicalVO> response = new ServiceResponse<GetMedicalVO>();
            try
            {
                Medical entityAdd = _mapper.Map<Medical>(item);

                #region Relationship

                entityAdd.Office = await _officeRepository.FindByID(item.OfficeId);

                List<Specialty> specialtiesAdd = await _specialtyRepository.FindByIDs(item.SpecialtiesIds);
                entityAdd.Specialties = specialtiesAdd;

                #endregion Relationship

                entityAdd.CreatedDate = DateTime.Now;
                entityAdd.ModifyDate = DateTime.Now;
                entityAdd.LastAccessDate = DateTime.Now;

                User userAction = await _userRepository.FindByID(this.UserId);
                entityAdd.CreatedUser = userAction;
                entityAdd.CreatedUserId = this.UserId;

                response = await base.Validate(entityAdd);

                if (response.Success)
                {
                    Medical entityResponse = await _entityRepository.Create(entityAdd);

                    response.Data = _mapper.Map<GetMedicalVO>(entityResponse);
                    response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("MedicalRegistred", base._applicationLanguageRepository, base._cacheService);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        public override async Task<ServiceResponse<GetMedicalVO>> Update(UpdateMedicalVO item)
        {
            ServiceResponse<GetMedicalVO> response = new ServiceResponse<GetMedicalVO>();
            try
            {
                Medical entityUpdate = await _entityRepository.FindByID(item.Id);

                #region Relationship

                entityUpdate.Office = await _officeRepository.FindByID(item.OfficeId);

                List<Specialty> specialtiesAdd = await _specialtyRepository.FindByIDs(item.SpecialtiesIds);
                entityUpdate.Specialties = specialtiesAdd;

                #endregion Relationship

                entityUpdate.ModifyDate = DateTime.Now;
                entityUpdate.LastAccessDate = DateTime.Now;

                User userAction = await _userRepository.FindByID(this.UserId);
                entityUpdate.ModifyUser = userAction;
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
                    response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("MedicalUpdated", base._applicationLanguageRepository, base._cacheService);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }

        private async Task<bool> Exists(string accreditation, ETypeAccreditation typeAccreditation)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            bool entityResponse = await _entityRepository.Exists(accreditation);

            return entityResponse;
        }

        public override Task<ServiceResponse<bool>> Delete(long id)
        {
            return base.EnableOrDisable(id);
        }

        public override async Task<ServiceResponse<List<GetMedicalVO>>> FindAll()
        {
            ServiceResponse<List<GetMedicalVO>> response = new ServiceResponse<List<GetMedicalVO>>();

            response = await validAccessdmin();


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

            response = await base.FindByID(id);

            return response;
        }

        private async Task<ServiceResponse<List<GetMedicalVO>>> validAccessdmin()
        {
            ServiceResponse<List<GetMedicalVO>> response = new ServiceResponse<List<GetMedicalVO>>();
            response.Success = true;

            User userAction = await _userRepository.FindByID(this.UserId);
            var validateResult
                = PatientPermissionMedicalValidator.ValidatePermissionAdmin(userAction);
            bool invalidAccess = validateResult != null;
            if (invalidAccess)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("PermissionDenied", base._applicationLanguageRepository, base._cacheService);
                
                response.Errors = new List<ErrorResponse>();
                response.Unauthorized = true;
                response.Errors.Add(validateResult);
                return response;
            }
            return response;

        }
    }
}
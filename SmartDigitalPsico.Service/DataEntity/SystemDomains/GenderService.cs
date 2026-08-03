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

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    /// <summary>
    /// Classe responsável por GenderService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class GenderService : EntityBaseService<Gender, AddGenderDto, UpdateGenderDto, GetGenderDto, IGenderRepository>, IGenderService
    {
        /// <summary>
        /// Método GenderService: executa a operação GenderService.
        /// </summary>
        public GenderService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IGenderRepository entityRepository,
            IValidator<Gender> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
        }

        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<List<GetGenderDto>>> FindAll()
        {
            string keyCache = "FindAll_GetGenderVO";

            ServiceResponse<List<GetGenderDto>> result = new ServiceResponse<List<GetGenderDto>>();

            if (_cacheService.IsEnable())
            {
                bool existsCache = _cacheService.TryGet(keyCache, out ServiceResponseCacheVO<List<GetGenderDto>> cachedResult);
                if (!existsCache)
                {
                    result = await base.FindAll();
                    ServiceResponseCacheVO<List<GetGenderDto>> cacheSave = new ServiceResponseCacheVO<List<GetGenderDto>>(result, keyCache, _cacheService.GetSlidingExpiration());

                    result.Success = _cacheService.Set(keyCache, cacheSave);
                }
                else
                {
                    result.Data = cachedResult.Data;
                }
            }
            else
            {
                result = await base.FindAll();
            }

            return result;
        }
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<GetGenderDto>> FindByID(long id)
        {
            ServiceResponse<GetGenderDto> response = new ServiceResponse<GetGenderDto>();

            Gender entityResponse = await _entityRepository.FindByID(id);

            if (entityResponse != null)
            {
                response.Data = _mapper.Map<GetGenderDto>(entityResponse);
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

        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public override async Task<ServiceResponse<GetGenderDto>> Update(UpdateGenderDto item)
        {
            ServiceResponse<GetGenderDto> response = new ServiceResponse<GetGenderDto>();

            bool entityExists = await _entityRepository.Exists(item.Id);

            if (!entityExists)
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                 
                return response;
            }
            Gender entityUpdate = await _entityRepository.FindByID(item.Id);
            entityUpdate.Description = item.Description;
            entityUpdate.Enable = item.Enable;
            entityUpdate.Language = item.Language;

            response = await Validate(entityUpdate);
            entityUpdate.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
            if (response.Success)
            {
                Gender entityResponse = await _entityRepository.Update(entityUpdate);

                response.Data = _mapper.Map<GetGenderDto>(entityResponse);
                response.Success = true;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);                
            }
            return response;
        }
    }
}

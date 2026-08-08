using FluentValidation;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    /// <summary>
    /// Classe responsÃ¡vel por GenderService.
    /// Responsabilidade: serviÃ§o de entidade de negÃ³cio.
    /// RelaÃ§Ã£o: orquestra repositÃ³rios, validators e mapeamentos.
    /// </summary>
    public class GenderService : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<Gender, GetGenderDto>, IGenderService
    {
        /// <summary>
        /// MÃ©todo GenderService: executa a operaÃ§Ã£o GenderService.
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
        /// MÃ©todo FindAll: consulta e retorna dados.
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
        /// MÃ©todo FindByID: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<GetGenderDto>> FindByID(long id)
        {
            ServiceResponse<GetGenderDto> response = new ServiceResponse<GetGenderDto>();

            Gender entityResponse = await ((IGenderRepository)_entityRepository).FindByID(id);

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
        /// MÃ©todo Update: atualiza um registro/recurso existente.
        /// </summary>
        public override async Task<ServiceResponse<GetGenderDto>> Update(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDto item)
        {
            var dto = (UpdateGenderDto)item;
            ServiceResponse<GetGenderDto> response = new ServiceResponse<GetGenderDto>();

            bool entityExists = await ((IGenderRepository)_entityRepository).Exists(dto.Id);

            if (!entityExists)
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                 
                return response;
            }
            Gender entityUpdate = await ((IGenderRepository)_entityRepository).FindByID(dto.Id);
            entityUpdate.Description = dto.Description;
            entityUpdate.Enable = dto.Enable;
            entityUpdate.Language = dto.Language;

            response = await Validate(entityUpdate);
            entityUpdate.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            if (response.Success)
            {
                Gender entityResponse = await ((IGenderRepository)_entityRepository).Update(entityUpdate);

                response.Data = _mapper.Map<GetGenderDto>(entityResponse);
                response.Success = true;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);                
            }
            return response;
        }
    }
}


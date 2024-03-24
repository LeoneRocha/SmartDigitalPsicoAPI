﻿using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Service.SystemDomains;
using SmartDigitalPsico.Domain.Validation.Helper;

namespace SmartDigitalPsico.Service.Generic
{
    public class EntityBaseService<TEntity, TEntityAdd, TEntityUpdate, TEntityResult, Repo>
        : IEntityBaseService<TEntity, TEntityAdd, TEntityUpdate, TEntityResult>
        where TEntity : EntityBase
        where TEntityAdd : IEntityVOAdd
        where TEntityUpdate : IEntityVO
        where TEntityResult : class
        where Repo : IEntityBaseRepository<TEntity>

    {
        private readonly IMapper _mapper;
        private readonly Repo _genericRepository;
        private readonly IValidator<TEntity> _entityValidator;
        protected long UserId { get; private set; }
        protected readonly IApplicationLanguageRepository _applicationLanguageRepository;
        protected readonly ICacheService _cacheService;

        public EntityBaseService(IMapper mapper, Repo UserRepository, IValidator<TEntity> entityValidator, IApplicationLanguageRepository applicationLanguageRepository, ICacheService cacheService)
        {
            _mapper = mapper;
            _genericRepository = UserRepository;
            _entityValidator = entityValidator;
            _applicationLanguageRepository = applicationLanguageRepository;
            _cacheService = cacheService;
        }
        public virtual async Task<ServiceResponse<TEntityResult>> Create(TEntityAdd item)
        {
            ServiceResponse<TEntityResult> response = new ServiceResponse<TEntityResult>();
            try
            {
                TEntity entityAdd = _mapper.Map<TEntity>(item);

                response = await Validate(entityAdd);
                if (response.Success)
                {
                    TEntity entityResponse = await _genericRepository.Create(entityAdd);
                    response.Data = _mapper.Map<TEntityResult>(entityResponse);
                    response.Message = await getMessageFromLocalization("RegisterCreated");

                }
            }
            catch (Exception ex)
            {
                //TODO: GENARATE LOGS
                throw ex;
            }

            return response;
        }

        private async Task<string> getMessageFromLocalization(string key)
        {
            try
            {
                return await ApplicationLanguageService.GetLocalization<SharedResource>
                                   (key, this._applicationLanguageRepository, this._cacheService);
            }
            catch (Exception)
            {

            }
            return "Erro get Message";
        }

        public virtual async Task<ServiceResponse<bool>> Delete(long id)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                bool exists = await _genericRepository.Exists(id);
                if (!exists)
                {
                    response.Success = false;
                    response.Message = await getMessageFromLocalization("RegisterIsNotFound");
                    return response;
                }
                else
                {
                    response.Success = await _genericRepository.Delete(id);
                    if (response.Success)
                    {
                        response.Message = await getMessageFromLocalization("RegisterDeleted");
                        response.Success = true;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return response;
        }
        public virtual async Task<ServiceResponse<TEntityResult>> Update(TEntityUpdate item)
        {
            ServiceResponse<TEntityResult> response = new ServiceResponse<TEntityResult>();
            try
            {
                bool entityExists = await _genericRepository.Exists(item.Id);
                if (!entityExists)
                {
                    response.Success = false;
                    response.Message = await getMessageFromLocalization("RegisterIsNotFound");

                    return response;
                }
                var entityUpdate = _mapper.Map<TEntity>(item);
                response = await Validate(entityUpdate);
                entityUpdate.ModifyDate = DateTime.Now;
                if (response.Success)
                {
                    TEntity entityResponse = await _genericRepository.Update(entityUpdate);
                    response.Data = _mapper.Map<TEntityResult>(entityResponse);
                    response.Message = await getMessageFromLocalization("RegisterUpdated");
                }
            }
            catch (Exception ex)
            {
                //TODO: GENARATE LOGS
                throw ex;
            }
            return response;
        }
        public async Task<ServiceResponse<bool>> Exists(long id)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                bool entityResponse = await _genericRepository.Exists(id);

                response.Data = entityResponse;
                response.Success = true;
                response.Message = await getMessageFromLocalization("RegisterExist");

            }
            catch (Exception ex)
            {
                //TODO: GENARATE LOGS
                throw ex;
            }
            return response;
        }
        public virtual async Task<ServiceResponse<List<TEntityResult>>> FindAll()
        {
            ServiceResponse<List<TEntityResult>> response = new ServiceResponse<List<TEntityResult>>();
            try
            {
                List<TEntity> entityResponse = await _genericRepository.FindAll();

                response.Data = entityResponse.Select(c => _mapper.Map<TEntityResult>(c)).ToList();

                response.Success = true;
                response.Message = await getMessageFromLocalization("RegisterExist");
            }
            catch (Exception ex)
            {
                //TODO: GENARATE LOGS
                throw ex;
            }
            return response;
        }
        public virtual async Task<ServiceResponse<TEntityResult>> FindByID(long id)
        {
            ServiceResponse<TEntityResult> response = new ServiceResponse<TEntityResult>();
            try
            {
                TEntity entityResponse = await _genericRepository.FindByID(id);
                response.Data = _mapper.Map<TEntityResult>(entityResponse);
                response.Success = true;
                response.Message = await getMessageFromLocalization("RegisterFind");
            }
            catch (Exception ex)
            {
                //TODO: GENARATE LOGS
                throw ex;
            }


            return response;
        }
        public virtual async Task<ServiceResponse<List<TEntityResult>>> FindWithPagedSearch(string query)
        {
            ServiceResponse<List<TEntityResult>> response = new ServiceResponse<List<TEntityResult>>();
            try
            {
                List<TEntity> entityResponse = await _genericRepository.FindWithPagedSearch(query);
                response.Data = entityResponse.Select(c => _mapper.Map<TEntityResult>(c)).ToList();
                response.Success = true;
                response.Message = await getMessageFromLocalization("RegisterFind");
            }
            catch (Exception ex)
            {
                //TODO: GENARATE LOGS
                throw ex;
            }
            return response;
        }
        public async Task<ServiceResponse<int>> GetCount(string query)
        {
            ServiceResponse<int> response = new ServiceResponse<int>();
            try
            {
                int entityResponse = await _genericRepository.GetCount(query);

                response.Data = entityResponse;
                response.Success = true;
                response.Message = await getMessageFromLocalization("RegisterCounted");
            }
            catch (Exception ex)
            {
                //TODO: GENARATE LOGS
                throw ex;
            }

            return response;
        }

        public virtual async Task<ServiceResponse<bool>> EnableOrDisable(long id)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
            try
            {
                bool exists = await _genericRepository.Exists(id);
                if (!exists)
                {
                    response.Success = false;
                    response.Message = await getMessageFromLocalization("RegisterIsNotFound");
                    return response;
                }
                else
                {
                    response.Success = await _genericRepository.EnableOrDisable(id);
                    if (response.Success)
                    {
                        response.Message = await getMessageFromLocalization("RegisterUpdated");
                        response.Success = true;
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: GENARATE LOGS
                throw ex;
            }
            return response;
        }
        public void SetUserId(long id)
        {
            this.UserId = id;
        }
        public virtual async Task<ServiceResponse<TEntityResult>> Validate(TEntity item)
        {
            ServiceResponse<TEntityResult> response = new ServiceResponse<TEntityResult>();
            try
            {
                var validationResult = await _entityValidator.ValidateAsync(item);

                response.Success = validationResult.IsValid;
                response.Errors = HelperValidation.GetErrosMap(validationResult);
                string validationMsg = HelperValidation.GetMessage(validationResult.IsValid);
                //TODO: IMPLANTAR DO LANGUAGE
                response.Message = validationMsg;
            }
            catch (Exception ex)
            {
                //TODO: GENARATE LOGS
                throw ex;
            }
            return response;
        }
    }
}
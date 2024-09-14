using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Security;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Domains;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.User;
using SmartDigitalPsico.Domain.VO.Utils;
using SmartDigitalPsico.Service.DataEntity.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    public class UserService : EntityBaseService<User, AddUserVO, UpdateUserVO, GetUserVO, IUserRepository>, IUserService
    {
        private readonly IRoleGroupRepository _roleGroupRepository;
        private readonly ITokenConfigurationVO _configurationToken;
        private readonly ITokenService _tokenService;
        private readonly AuthConfigurationVO _configurationAuth;
        public UserService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IRoleGroupRepository roleGroupRepository,
            ITokenConfigurationVO configurationToken,
            ITokenService tokenService,
            IOptions<AuthConfigurationVO> configurationAuth,
            IValidator<User> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, sharedRepositories.UserRepository, entityValidator)
        {
            _roleGroupRepository = roleGroupRepository;
            _configurationToken = configurationToken;
            _configurationAuth = configurationAuth.Value;
            _tokenService = tokenService;
        }

        public async Task<ServiceResponse<GetUserAuthenticatedVO>> Login(string login, string password)
        {
            var response = new ServiceResponse<GetUserAuthenticatedVO>();

            var user = await _entityRepository.FindByLogin(login);
            if (user == null)
            {
                response.Success = false;
                response.Message = ValidatorConstants.Validade_UserNotFound;
                return response;
            }
            else if (!SecurityHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                response.Success = false;
                response.Message = "Wrong password.";
                return response;
            }

            if (_configurationAuth.TypeApiCredential == ETypeApiCredential.Jwt)
            {
                response.Data = await executeLoginJwt(user);
            }
            response.Success = true;
            response.Message = "User Logged.";
            return response;
        }

        public async Task<ServiceResponse<GetUserVO>> Register(UserRegisterVO userRegisterVO)
        {
            SecurityHelper.CreatePasswordHash(userRegisterVO.Password, out byte[] passwordHash, out byte[] passwordSalt);

            User entityAdd = _mapper.Map<User>(userRegisterVO);

            entityAdd.PasswordHash = passwordHash;
            entityAdd.PasswordSalt = passwordSalt;
            entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();
            entityAdd.Role = "Pending";
            entityAdd.Admin = false;

            ServiceResponse<GetUserVO> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                User entityResponse = await _entityRepository.Create(entityAdd);
                response.Data = _mapper.Map<GetUserVO>(entityResponse);
                response.Message = "User registred.";
            }

            return response;
        }

        public override async Task<ServiceResponse<GetUserVO>> Update(UpdateUserVO updateUser)
        {
            ServiceResponse<GetUserVO> response = new ServiceResponse<GetUserVO>();

            try
            {
                User entityUpdate = await _entityRepository.FindByID(updateUser.Id);

                if (entityUpdate == null || entityUpdate.Id == 0)
                {
                    response.Success = false;
                    response.Message = ValidatorConstants.Validade_UserNotFound;
                    return response;
                }
                entityUpdate.Name = updateUser.Name;
                entityUpdate.Enable = updateUser.Enable;
                entityUpdate.Email = updateUser.Email;
                entityUpdate.Language = updateUser.Language;
                entityUpdate.TimeZone = updateUser.TimeZone;
                if (!string.IsNullOrEmpty(updateUser.Password))
                {
                    SecurityHelper.CreatePasswordHash(updateUser.Password, out byte[] passwordHash, out byte[] passwordSalt);
                    entityUpdate.PasswordHash = passwordHash;
                    entityUpdate.PasswordSalt = passwordSalt;
                }
                entityUpdate.Role = updateUser.Role;

                entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();

                if (updateUser.MedicalId > 0)
                    entityUpdate.MedicalId = updateUser.MedicalId;

                List<RoleGroup> roleGroups = await _roleGroupRepository.FindByIDs(updateUser.RoleGroupsIds);
                if (roleGroups.Count > 0)
                {
                    entityUpdate.UserRoleGroups.Clear();
                    foreach (var rg in roleGroups)
                    {
                        entityUpdate.UserRoleGroups.Add(new RoleGroupUser { UserId = entityUpdate.Id, RoleGroupId = rg.Id });
                    }
                }
                response = await base.Validate(entityUpdate);

                if (response.Success)
                {

                    User entityResponse = await _entityRepository.Update(entityUpdate);
                    response.Success = true;
                    response.Data = _mapper.Map<GetUserVO>(entityResponse);

                    if (response.Success)
                        response.Message = "User Updated.";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Errors = ExceptionHandler.GerateListErrorResponse(ex);
                response.Message = ExceptionHandler.GetMessage(ex);
            }

            return response;
        }
        public override async Task<ServiceResponse<GetUserVO>> Create(AddUserVO userRegisterVO)
        {
            SecurityHelper.CreatePasswordHash(userRegisterVO.Password, out byte[] passwordHash, out byte[] passwordSalt);

            User entityAdd = _mapper.Map<User>(userRegisterVO);

            entityAdd.PasswordHash = passwordHash;
            entityAdd.PasswordSalt = passwordSalt;
            entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();
            entityAdd.Role = userRegisterVO.Role;

            List<RoleGroup> roleGroups = await _roleGroupRepository.FindByIDs(userRegisterVO.RoleGroupsIds.ToList());

            ServiceResponse<GetUserVO> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                User entityResponse = await _entityRepository.Create(entityAdd);
                entityResponse.UserRoleGroups = new List<RoleGroupUser>();
                if (roleGroups.Count > 0)
                {
                    foreach (var rg in roleGroups)
                    {
                        entityResponse.UserRoleGroups.Add(new RoleGroupUser { User = entityResponse, RoleGroup = rg });
                    }
                    response = await base.Validate(entityResponse);
                    if (response.Success)
                    {
                        entityResponse = await _entityRepository.Update(entityResponse);
                        entityResponse = await _entityRepository.FindByID(entityResponse.Id);
                    }
                }
                response.Data = _mapper.Map<GetUserVO>(entityResponse);
                response.Message = "User registred.";
            }

            return response;
        }

        public async Task<bool> UserExists(string login)
        {
            bool response = await _entityRepository.UserExists(login);

            return response;
        }

        public async Task<ServiceResponse<bool>> Logout(string login)
        {
            var response = new ServiceResponse<bool>();
            bool user = await _entityRepository.UserExists(login);
            if (!user)
            {
                response.Success = false;
                response.Message = ValidatorConstants.Validade_UserNotFound;
            }
            else
            {
                response.Success = false;
                response.Message = "User logout.";
            }
            return response;
        }

        private async Task<GetUserAuthenticatedVO> executeLoginJwt(User user)
        {
            TokenVO token = await validateCredentials(user);
            GetUserAuthenticatedVO response = _mapper.Map<GetUserAuthenticatedVO>(user);

            fillRoleGroupsAuthenticate(response, user);

            response.MedicalId = user.Medical?.Id;
            response.TokenAuth = token;
            return response;
        }

        private async Task<TokenVO> validateCredentials(User user)
        {
            if (user == null) return new TokenVO();
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                new Claim(JwtRegisteredClaimNames.NameId, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Name, user.Name),
            };

            var accessToken = _tokenService.GenerateAccessToken(claims);
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DataHelper.GetDateTimeNow().AddDays(_configurationToken.DaysToExpiry);

            await _entityRepository.RefreshUserInfo(user);

            DateTime createDate = DataHelper.GetDateTimeNow();
            DateTime expirationDate = createDate.AddMinutes(_configurationToken.Minutes);
            return new TokenVO(true,
                createDate.ToString(AppConfigConstants.DATE_FORMAT),
                expirationDate.ToString(AppConfigConstants.DATE_FORMAT),
                accessToken,
                refreshToken
                );
        }

        public async Task<TokenVO> validateCredentials(TokenVO token)
        {
            string accessToken = token.AccessToken ?? string.Empty;
            string refreshToken = token.RefreshToken ?? string.Empty;

            var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);

            if (principal != null && principal.Identity != null)
            {
                var username = principal.Identity.Name;

                long idUser;
                if (long.TryParse(username, out idUser))
                {
                    var user = await _entityRepository.FindByID(idUser);

                    if (user.RefreshToken != refreshToken ||
                        user.RefreshTokenExpiryTime <= DataHelper.GetDateTimeNow()) return new TokenVO();

                    accessToken = _tokenService.GenerateAccessToken(principal.Claims);
                    refreshToken = _tokenService.GenerateRefreshToken();

                    user.RefreshToken = refreshToken;
                    await _entityRepository.RefreshUserInfo(user);
                }
            }

            DateTime createDate = DataHelper.GetDateTimeNow();
            DateTime expirationDate = createDate.AddMinutes(_configurationToken.Minutes);

            return new TokenVO(
            true,
                createDate.ToString(AppConfigConstants.DATE_FORMAT),
                expirationDate.ToString(AppConfigConstants.DATE_FORMAT),
                accessToken,
                refreshToken
                );
        }

        public async Task<ServiceResponse<GetUserVO>> UpdateProfile(UpdateUserProfileVO userUpdateProfileVO)
        {
            ServiceResponse<GetUserVO> response = new ServiceResponse<GetUserVO>();

            User entityUpdate = await _entityRepository.FindByID(userUpdateProfileVO.Id);

            if (entityUpdate == null || entityUpdate.Id == 0)
            {
                response.Success = false;
                response.Message = ValidatorConstants.Validade_UserNotFound;
                return response;
            }
            entityUpdate.Name = userUpdateProfileVO.Name;
            entityUpdate.Email = userUpdateProfileVO.Email;
            entityUpdate.Language = userUpdateProfileVO.Language;
            entityUpdate.TimeZone = userUpdateProfileVO.TimeZone;

            if (!string.IsNullOrEmpty(userUpdateProfileVO.Password))
            {
                SecurityHelper.CreatePasswordHash(userUpdateProfileVO.Password, out byte[] passwordHash, out byte[] passwordSalt);
                entityUpdate.PasswordHash = passwordHash;
                entityUpdate.PasswordSalt = passwordSalt;
            }

            entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();

            response = await base.Validate(entityUpdate);

            if (response.Success)
            {
                User entityResponse = await _entityRepository.Update(entityUpdate);
                response.Success = true;
                response.Data = _mapper.Map<GetUserVO>(entityResponse);

                if (response.Success)
                    response.Message = "User Updated.";
            }


            return response;
        }

        public override async Task<ServiceResponse<GetUserVO>> FindByID(long id)
        {
            ServiceResponse<GetUserVO> response = new ServiceResponse<GetUserVO>();

            User? entityResponse = await _entityRepository.FindByID(id);
            if (entityResponse != null)
            {
                response.Data = _mapper.Map<GetUserVO>(entityResponse);

                fillRoleGroups(response, entityResponse);
            }
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterFind", _applicationLanguageRepository, _cacheService);

            return response;
        }

        private static void fillRoleGroups(ServiceResponse<GetUserVO> response, User entityResponse)
        {
            if (response.Data != null)
            {
                response.Data.RoleGroups = getRolesGroups(entityResponse);
            }
        }
        private static void fillRoleGroupsAuthenticate(GetUserAuthenticatedVO response, User entityResponse)
        {
            if (response != null)
            {
                response.RoleGroups = getRolesGroups(entityResponse);
            }
        }
        private static List<GetRoleGroupVO> getRolesGroups(User entityResponse)
        {
            List<GetRoleGroupVO> result = new List<GetRoleGroupVO>();

            foreach (var item in entityResponse.UserRoleGroups.Select(x => x.RoleGroup))
            {
                if (item != null)
                {
                    result.Add(new GetRoleGroupVO()
                    {
                        RolePolicyClaimCode = item.RolePolicyClaimCode,
                        Description = item.Description,
                        Id = item.Id,
                        Enable = item.Enable,
                        Language = item.Language,
                    });
                }
            }
            return result;
        }
    }
}
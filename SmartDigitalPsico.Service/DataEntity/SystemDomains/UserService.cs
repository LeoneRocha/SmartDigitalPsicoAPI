using FluentValidation;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.SMTP;
using SmartDigitalPsico.Domain.DTO.User;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Security;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    public class UserService : EntityBaseService<User, AddUserDto, UpdateUserDto, GetUserDto, IUserRepository>, IUserService
    {
        private readonly IRoleGroupRepository _roleGroupRepository;
        private readonly ITokenConfigurationDto _configurationToken;
        private readonly ITokenService _tokenService;
        private readonly ISharedServices _sharedServices;
        private readonly ISharedRepositories _sharedRepositories; 
        private readonly ITokenSessionPersistenceService _tokenSessionService;
         
        private readonly AuthConfigurationDto _configurationAuth;
        public UserService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IRoleGroupRepository roleGroupRepository,
            ITokenConfigurationDto configurationToken,
            ITokenService tokenService,
            IOptions<AuthConfigurationDto> configurationAuth,
            IValidator<User> entityValidator,
            ITokenSessionPersistenceService tokenSessionService 
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, sharedRepositories.UserRepository, entityValidator)
        {
            _roleGroupRepository = roleGroupRepository;
            _configurationToken = configurationToken;
            _configurationAuth = configurationAuth.Value;
            _tokenService = tokenService;
            _sharedServices = sharedServices;
            _sharedRepositories = sharedRepositories;
            _tokenSessionService = tokenSessionService;              
        }

        public async Task<ServiceResponse<GetUserAuthenticatedDto>> Login(string login, string password)
        {
            var response = new ServiceResponse<GetUserAuthenticatedDto>();

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

        public async Task<ServiceResponse<GetUserDto>> Register(UserRegisterDto userRegisterVO)
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

            ServiceResponse<GetUserDto> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                User entityResponse = await _entityRepository.Create(entityAdd);
                response.Data = _mapper.Map<GetUserDto>(entityResponse);
                response.Message = "User registred.";
            }

            return response;
        }

        public override async Task<ServiceResponse<GetUserDto>> Update(UpdateUserDto updateUser)
        {
            ServiceResponse<GetUserDto> response = new ServiceResponse<GetUserDto>();

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
                    response.Data = _mapper.Map<GetUserDto>(entityResponse);

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
        public override async Task<ServiceResponse<GetUserDto>> Create(AddUserDto userRegisterVO)
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

            ServiceResponse<GetUserDto> response = await base.Validate(entityAdd);

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
                response.Data = _mapper.Map<GetUserDto>(entityResponse);
                response.Message = "User registred.";

                var configApp = (await _sharedRepositories.ApplicationConfigSettingRepository.FindAll())[0];
                await SendEmailCreateAcessAsync(userRegisterVO, configApp.UrlRootManager);
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

        private async Task<GetUserAuthenticatedDto> executeLoginJwt(User user)
        {
            TokenVO token = await validateCredentials(user);
            GetUserAuthenticatedDto response = _mapper.Map<GetUserAuthenticatedDto>(user);

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

            DateTime refreshTokenExpiryTime = DataHelper.GetDateTimeNow().AddDays(_configurationToken.DaysToExpiry);

            user.RefreshTokenExpiryTime = refreshTokenExpiryTime;

            await _entityRepository.RefreshUserInfo(user);

            DateTime createDate = DataHelper.GetDateTimeNow();
            DateTime expirationDate = createDate.AddMinutes(_configurationToken.Minutes);

            UserTokenSession? tokenSession = await _tokenSessionService.GetSessionAsync(user.Id);
           
            if (tokenSession == null || tokenSession.ExpiresAt <= createDate)
            {
                tokenSession = new UserTokenSession
                {
                    UserId = user.Id,
                    AccessToken = accessToken,
                    RefreshToken = refreshToken,
                    RefreshTokenExpiryTime = refreshTokenExpiryTime,
                    LastAccessDate = createDate,
                    CreatedDate = createDate,
                    ModifyDate = createDate,
                    ExpiresAt = expirationDate,
                    Enable = true
                };

                await _tokenSessionService.SaveSessionAsync(tokenSession);
            }
            else 
            {
                tokenSession.AccessToken = accessToken;
                tokenSession.RefreshToken = refreshToken;
                tokenSession.RefreshTokenExpiryTime = refreshTokenExpiryTime;
                tokenSession.LastAccessDate = createDate;
                tokenSession.ModifyDate = createDate;
                tokenSession.ExpiresAt = expirationDate;
            }  
            var tokenResult = new TokenVO(true,
                 tokenSession.CreatedDate.ToString(AppConfigConstants.DATE_FORMAT2),
                 tokenSession.ExpiresAt.ToString(AppConfigConstants.DATE_FORMAT2),
                 tokenSession.AccessToken,
                 tokenSession.RefreshToken
                 ); 
            return tokenResult;

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

        public async Task<ServiceResponse<GetUserDto>> UpdateProfile(UpdateUserProfileDto userUpdateProfileVO)
        {
            ServiceResponse<GetUserDto> response = new ServiceResponse<GetUserDto>();

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
                response.Data = _mapper.Map<GetUserDto>(entityResponse);

                if (response.Success)
                    response.Message = "User Updated.";
            }


            return response;
        }

        public override async Task<ServiceResponse<GetUserDto>> FindByID(long id)
        {
            ServiceResponse<GetUserDto> response = new ServiceResponse<GetUserDto>();

            User? entityResponse = await _entityRepository.FindByID(id);
            if (entityResponse != null)
            {
                response.Data = _mapper.Map<GetUserDto>(entityResponse);

                fillRoleGroups(response, entityResponse);
            }
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterFind", _applicationLanguageRepository, _cacheService);

            return response;
        }

        private static void fillRoleGroups(ServiceResponse<GetUserDto> response, User entityResponse)
        {
            if (response.Data != null)
            {
                response.Data.RoleGroups = getRolesGroups(entityResponse);
            }
        }
        private static void fillRoleGroupsAuthenticate(GetUserAuthenticatedDto response, User entityResponse)
        {
            if (response != null)
            {
                response.RoleGroups = getRolesGroups(entityResponse);
            }
        }
        private static List<GetRoleGroupDto> getRolesGroups(User entityResponse)
        {
            List<GetRoleGroupDto> result = new List<GetRoleGroupDto>();

            foreach (var item in entityResponse.UserRoleGroups.Select(x => x.RoleGroup))
            {
                if (item != null)
                {
                    result.Add(new GetRoleGroupDto()
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
        private async Task SendEmailCreateAcessAsync(AddUserDto user, string accessUrl)
        {
            var template = await _sharedRepositories.EmailTemplateRepository.GetEmailTemplateAsync("Welcome Email");

            var tokens = new Dictionary<string, string>
            {
                { "AccessUrl", accessUrl},
                { "Email", user.Email },
                { "Password", user.Password }
            };
            var body = EmailHelper.ReplaceTokens(template.Body, tokens);

            EmailMessageDto emailMessageVO = new EmailMessageDto()
            {
                Subject = template.Subject,
                Message = body,
                ToEmails = new List<string>() { "leocr_lem@yahoo.com.br" }
            };
            await _sharedServices.EmailService.SendEmailAsync(emailMessageVO);
        }
    }
}
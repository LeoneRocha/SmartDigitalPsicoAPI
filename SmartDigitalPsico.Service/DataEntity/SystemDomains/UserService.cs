using FluentValidation;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.Domain.AppException;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.DTO.User.ADD;
using SmartDigitalPsico.Domain.DTO.User.GET;
using SmartDigitalPsico.Domain.DTO.User.UPDATE;
using SmartDigitalPsico.Domain.DTO.User.Common;
using ENotificationServiceType = SmartDigitalPsico.Core.SDK.Domain.Enuns.ENotificationServiceType;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.RoleGroup;
using SmartDigitalPsico.Domain.Interfaces.User;
namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    /// <summary>
    /// Classe responsável por UserService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class UserService : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<User, GetUserDto>, IUserService
    {
        private readonly IRoleGroupRepository _roleGroupRepository;
        private readonly SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ITokenConfigurationDto _configurationToken;
        private readonly ITokenService _tokenService;
        private readonly ISharedServices _sharedServices;
        private readonly ISharedRepositories _sharedRepositories;
        private readonly ITokenSessionPersistenceService _tokenSessionService;

        private readonly SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.AuthConfigurationDto _configurationAuth;
        /// <summary>
        /// Método UserService: executa a operação UserService.
        /// </summary>
        public UserService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IRoleGroupRepository roleGroupRepository,
            SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ITokenConfigurationDto configurationToken,
            ITokenService tokenService,
            IOptions<SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.AuthConfigurationDto> configurationAuth,
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

        /// <summary>
        /// Método Login: executa a operação Login.
        /// </summary>
        public async Task<ServiceResponse<GetUserAuthenticatedDto>> Login(string login, string password)
        {
            var response = new ServiceResponse<GetUserAuthenticatedDto>();

            var user = await ((IUserRepository)_entityRepository).FindByLogin(login);
            if (user == null)
            {
                response.Success = false;
                response.Message = ValidatorConstants.Validade_UserNotFound;
                return response;
            }
            else if (!SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.WrongPassword, GeneralLanguageMenssageConstants.WrongPassword);
                return response;
            }

            if (_configurationAuth.TypeApiCredential == SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeApiCredential.Jwt)
            {
                response.Data = await executeLoginJwt(user);
            }
            response.Success = true;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.UserLogged, GeneralLanguageMenssageConstants.UserLogged);
            return response;
        }

        /// <summary>
        /// Método Register: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task<ServiceResponse<GetUserDto>> Register(UserRegisterDto userRegisterVO)
        {
            SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreatePasswordHash(userRegisterVO.Password, out byte[] passwordHash, out byte[] passwordSalt);

            User entityAdd = _mapper.Map<User>(userRegisterVO);

            entityAdd.PasswordHash = passwordHash;
            entityAdd.PasswordSalt = passwordSalt;
            entityAdd.CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.Role = "Pending";
            entityAdd.Admin = false;

            ServiceResponse<GetUserDto> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                User entityResponse = await ((IUserRepository)_entityRepository).Create(entityAdd);
                response.Data = _mapper.Map<GetUserDto>(entityResponse);
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCreated, GeneralLanguageMenssageConstants.RegisterCreated);
            }

            return response;
        }

        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public override async Task<ServiceResponse<GetUserDto>> Update(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDto item)
        {
            var updateUser = (UpdateUserDto)item;
            ServiceResponse<GetUserDto> response = new ServiceResponse<GetUserDto>();

            try
            {
                User entityUpdate = await ((IUserRepository)_entityRepository).FindByID(updateUser.Id);

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
                    SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreatePasswordHash(updateUser.Password, out byte[] passwordHash, out byte[] passwordSalt);
                    entityUpdate.PasswordHash = passwordHash;
                    entityUpdate.PasswordSalt = passwordSalt;
                }
                entityUpdate.Role = updateUser.Role;

                entityUpdate.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

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

                    User entityResponse = await ((IUserRepository)_entityRepository).Update(entityUpdate);
                    response.Success = true;
                    response.Data = _mapper.Map<GetUserDto>(entityResponse);

                    if (response.Success)
                        response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
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
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public override async Task<ServiceResponse<GetUserDto>> Create(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd item)
        {
            var userRegisterVO = (AddUserDto)item;
            SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreatePasswordHash(userRegisterVO.Password, out byte[] passwordHash, out byte[] passwordSalt);

            User entityAdd = _mapper.Map<User>(userRegisterVO);

            entityAdd.PasswordHash = passwordHash;
            entityAdd.PasswordSalt = passwordSalt;
            entityAdd.CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            entityAdd.Role = userRegisterVO.Role;

            List<RoleGroup> roleGroups = await _roleGroupRepository.FindByIDs(userRegisterVO.RoleGroupsIds.ToList());

            ServiceResponse<GetUserDto> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                User entityResponse = await ((IUserRepository)_entityRepository).Create(entityAdd);
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
                        entityResponse = await ((IUserRepository)_entityRepository).Update(entityResponse);
                        entityResponse = await ((IUserRepository)_entityRepository).FindByID(entityResponse.Id);
                    }
                }
                response.Data = _mapper.Map<GetUserDto>(entityResponse);
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterCreated, GeneralLanguageMenssageConstants.RegisterCreated);

                var configApp = (await _sharedRepositories.ApplicationConfigSettingRepository.FindAll())[0];
                await SendEmailCreateAcessAsync(userRegisterVO, configApp.UrlRootManager);
            }

            return response;
        }

        /// <summary>
        /// Método UserExists: executa a operação UserExists.
        /// </summary>
        public async Task<bool> UserExists(string login)
        {
            bool response = await ((IUserRepository)_entityRepository).UserExists(login);

            return response;
        }

        /// <summary>
        /// Método Logout: executa a operação Logout.
        /// </summary>
        public async Task<ServiceResponse<bool>> Logout(string login)
        {
            var response = new ServiceResponse<bool>();
            bool user = await ((IUserRepository)_entityRepository).UserExists(login);
            if (!user)
            {
                response.Success = false;
                response.Message = ValidatorConstants.Validade_UserNotFound;
            }
            else
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.UserLogout, GeneralLanguageMenssageConstants.UserLogout);
            }
            return response;
        }

        private async Task<GetUserAuthenticatedDto> executeLoginJwt(User user)
        {
            SmartDigitalPsico.Domain.VO.TokenVO token = await validateCredentials(user);
            GetUserAuthenticatedDto response = _mapper.Map<GetUserAuthenticatedDto>(user);

            fillRoleGroupsAuthenticate(response, user);

            response.MedicalId = user.Medical?.Id;
            response.TokenAuth = token;
            return response;
        }

        private async Task<SmartDigitalPsico.Domain.VO.TokenVO> validateCredentials(User user)
        {
            if (user == null) return new SmartDigitalPsico.Domain.VO.TokenVO();
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                new Claim(JwtRegisteredClaimNames.NameId, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Name, user.Name),
            };

            var accessToken = _tokenService.GenerateAccessToken(claims);
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;

            DateTime refreshTokenExpiryTime = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc().AddDays(_configurationToken.DaysToExpiry);

            user.RefreshTokenExpiryTime = refreshTokenExpiryTime;

            await ((IUserRepository)_entityRepository).RefreshUserInfo(user);

            DateTime createDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
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
            var tokenResult = new SmartDigitalPsico.Domain.VO.TokenVO(true,
                 tokenSession.CreatedDate.ToString(AppConfigConstants.DATE_FORMAT2),
                 tokenSession.ExpiresAt.ToString(AppConfigConstants.DATE_FORMAT2),
                 tokenSession.AccessToken,
                 tokenSession.RefreshToken
                 );
            return tokenResult;

        }

        /// <summary>
        /// Método validateCredentials: valida regras ou verifica existência.
        /// </summary>
        public async Task<SmartDigitalPsico.Domain.VO.TokenVO> validateCredentials(SmartDigitalPsico.Domain.VO.TokenVO token)
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
                    var user = await ((IUserRepository)_entityRepository).FindByID(idUser);

                    if (user.RefreshToken != refreshToken ||
                        !user.RefreshTokenExpiryTime.HasValue ||
                        user.RefreshTokenExpiryTime.Value <= SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc())
                        return new SmartDigitalPsico.Domain.VO.TokenVO();

                    accessToken = _tokenService.GenerateAccessToken(principal.Claims);
                    refreshToken = _tokenService.GenerateRefreshToken();

                    user.RefreshToken = refreshToken;
                    await ((IUserRepository)_entityRepository).RefreshUserInfo(user);
                }
            }

            DateTime createDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
            DateTime expirationDate = createDate.AddMinutes(_configurationToken.Minutes);

            return new SmartDigitalPsico.Domain.VO.TokenVO(
            true,
                createDate.ToString(AppConfigConstants.DATE_FORMAT),
                expirationDate.ToString(AppConfigConstants.DATE_FORMAT),
                accessToken,
                refreshToken
                );
        }

        /// <summary>
        /// Método UpdateProfile: atualiza um registro/recurso existente.
        /// </summary>
        public async Task<ServiceResponse<GetUserDto>> UpdateProfile(UpdateUserProfileDto userUpdateProfileVO)
        {
            ServiceResponse<GetUserDto> response = new ServiceResponse<GetUserDto>();

            User entityUpdate = await ((IUserRepository)_entityRepository).FindByID(userUpdateProfileVO.Id);

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
                SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreatePasswordHash(userUpdateProfileVO.Password, out byte[] passwordHash, out byte[] passwordSalt);
                entityUpdate.PasswordHash = passwordHash;
                entityUpdate.PasswordSalt = passwordSalt;
            }

            entityUpdate.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();

            response = await base.Validate(entityUpdate);

            if (response.Success)
            {
                User entityResponse = await ((IUserRepository)_entityRepository).Update(entityUpdate);
                response.Success = true;
                response.Data = _mapper.Map<GetUserDto>(entityResponse);

                if (response.Success)
                    response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterUpdated, GeneralLanguageMenssageConstants.RegisterUpdated);
            }


            return response;
        }

        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<GetUserDto>> FindByID(long id)
        {
            ServiceResponse<GetUserDto> response = new ServiceResponse<GetUserDto>();

            User? entityResponse = await ((IUserRepository)_entityRepository).FindByID(id);
            if (entityResponse != null)
            {
                response.Data = _mapper.Map<GetUserDto>(entityResponse);

                fillRoleGroups(response, entityResponse);
            }
            response.Success = true;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterFind, GeneralLanguageMenssageConstants.RegisterFind);
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

            var roleGroups = entityResponse.UserRoleGroups?
                .Select(x => x.RoleGroup)
                .Where(item => item != null) ?? Enumerable.Empty<RoleGroup>();

            foreach (var item in roleGroups)
            {
                result.Add(new GetRoleGroupDto()
                {
                    RolePolicyClaimCode = item!.RolePolicyClaimCode,
                    Description = item.Description,
                    Id = item.Id,
                    Enable = item.Enable,
                    Language = item.Language,
                });
            }

            // Fallback when RoleGroupUser link is missing (e.g. incomplete seed)
            if (result.Count == 0 && !string.IsNullOrWhiteSpace(entityResponse.Role))
            {
                result.Add(new GetRoleGroupDto
                {
                    RolePolicyClaimCode = entityResponse.Role,
                    Description = entityResponse.Role,
                    Enable = true,
                    Language = entityResponse.Language ?? string.Empty
                });
            }

            if (entityResponse.Admin && !result.Exists(r => r.RolePolicyClaimCode == "Admin"))
            {
                result.Add(new GetRoleGroupDto
                {
                    RolePolicyClaimCode = "Admin",
                    Description = "Administrador",
                    Enable = true,
                    Language = entityResponse.Language ?? string.Empty
                });
            }

            return result;
        }
        private async Task SendEmailCreateAcessAsync(AddUserDto user, string accessUrl)
        {
            var templateResult = await _sharedServices.NotificationTemplateService.GetNotificationTemplatesAsync(EmailTemplateTagConstants.LoginReleaseEmail);

            if (templateResult != null && templateResult.Success && templateResult.Data != null)
            {
                var template = templateResult.Data;

                var tokens = new Dictionary<string, string>
                {
                    { "AccessUrl", accessUrl},
                    { "Email", user.Email },
                    { "Password", user.Password }
                };

                var notificationMessageVO = new DataNotificationTemplateVO()
                {
                    Subject = template.Subject,
                    Body = template.Body,
                    ToEmails = new List<string>() { "leocr_lem@yahoo.com.br" }
                };
                await _sharedServices.SendNotificationService.SendNotificationAsync(notificationMessageVO, ENotificationServiceType.Email, tokens);
            }
        }
    }
}


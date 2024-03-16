using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Security;
using SmartDigitalPsico.Domain.VO.Domains;
using SmartDigitalPsico.Domain.VO.User;
using SmartDigitalPsico.Domain.VO.Utils;
using SmartDigitalPsico.Service.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SmartDigitalPsico.Service.Principals
{
    public class UserService : EntityBaseService<User, AddUserVO, UpdateUserVO, GetUserVO, IUserRepository>, IUserService

    {
        private const string DATE_FORMAT = "yyyy-MM-dd HH:mm:ss";
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IRoleGroupRepository _roleGroupRepository;

        IConfiguration _configuration;
        ITokenConfiguration _configurationToken;
        private readonly ITokenService _tokenService;
        AuthConfigurationVO _configurationAuth;
        public UserService(
              IUserRepository entityRepository
            , IApplicationLanguageRepository applicationLanguageRepository
            , IRoleGroupRepository roleGroupRepository
            , IMapper mapper
            , IConfiguration configuration
            , ITokenConfiguration configurationToken
            , ITokenService tokenService
            , IOptions<AuthConfigurationVO> configurationAuth
            , IValidator<User> entityValidator
            , ICacheService cacheService
            )
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _userRepository = entityRepository;
            _roleGroupRepository = roleGroupRepository;
            _mapper = mapper;
            _configuration = configuration;
            _configurationToken = configurationToken;
            _configurationAuth = configurationAuth.Value;
            _tokenService = tokenService;
        }

        public async Task<ServiceResponse<GetUserAuthenticatedVO>> Login(string login, string password)
        {
            var response = new ServiceResponse<GetUserAuthenticatedVO>();

            var user = await _userRepository.FindByLogin(login);
            if (user == null)
            {
                response.Success = false;
                response.Message = "User not found.";
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
            ServiceResponse<GetUserVO> response = new ServiceResponse<GetUserVO>();
            try
            {
                SecurityHelper.CreatePasswordHash(userRegisterVO.Password, out byte[] passwordHash, out byte[] passwordSalt);

                User entityAdd = _mapper.Map<User>(userRegisterVO);

                entityAdd.PasswordHash = passwordHash;
                entityAdd.PasswordSalt = passwordSalt;
                entityAdd.CreatedDate = DateTime.Now;
                entityAdd.ModifyDate = DateTime.Now;
                entityAdd.LastAccessDate = DateTime.Now;
                entityAdd.Role = "Pending";
                entityAdd.Admin = false;

                response = await base.Validate(entityAdd);

                if (response.Success)
                {
                    User entityResponse = await _userRepository.Register(entityAdd);
                    response.Data = _mapper.Map<GetUserVO>(entityResponse);
                    response.Message = "User registred.";
                }
            }
            catch (Exception ex)
            {
                //TODO: GENARATE LOGS
                throw ex;
            }
            return response;
        }

        public override async Task<ServiceResponse<GetUserVO>> Update(UpdateUserVO updateUser)
        {
            ServiceResponse<GetUserVO> response = new ServiceResponse<GetUserVO>();

            try
            {
                User entityUpdate = await _userRepository.FindByID(updateUser.Id);

                if (entityUpdate == null || entityUpdate?.Id == 0)
                {
                    response.Success = false;
                    response.Message = "User not found.";
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
                var isAdmin = updateUser?.Admin.GetValueOrDefault();
                entityUpdate.Role = updateUser?.Role;
                //entityUpdate.Admin = isAdmin != null && isAdmin == true ? true : false; 

                entityUpdate.ModifyDate = DateTime.Now;
                entityUpdate.MedicalId = updateUser?.MedicalId;

                List<RoleGroup> roleGroups = await _roleGroupRepository.FindByIDs(updateUser?.RoleGroupsIds);
                entityUpdate.RoleGroups.Clear();
                roleGroups.ForEach(rg => entityUpdate.RoleGroups.Add(rg));

                response = await base.Validate(entityUpdate);

                if (response.Success)
                {

                    User entityResponse = await _userRepository.Update(entityUpdate);
                    response.Success = true;
                    response.Data = _mapper.Map<GetUserVO>(entityResponse);

                    if (response.Success)
                        response.Message = "User Updated.";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Errors = Domain.Helpers.HandleException.GerateListErrorResponse(ex);
                response.Message = Domain.Helpers.HandleException.GetMessage(ex);
            }

            return response;
        }
        public override async Task<ServiceResponse<GetUserVO>> Create(AddUserVO userRegisterVO)
        {
            ServiceResponse<GetUserVO> response = new ServiceResponse<GetUserVO>();
            try
            {
                SecurityHelper.CreatePasswordHash(userRegisterVO.Password, out byte[] passwordHash, out byte[] passwordSalt);

                User entityAdd = _mapper.Map<User>(userRegisterVO);

                entityAdd.PasswordHash = passwordHash;
                entityAdd.PasswordSalt = passwordSalt;
                entityAdd.CreatedDate = DateTime.Now;
                entityAdd.ModifyDate = DateTime.Now;
                entityAdd.LastAccessDate = DateTime.Now;
                entityAdd.Role = userRegisterVO?.Role;
                //entityAdd.Admin = userRegisterVO?.Admin != null ? true : false;
                List<RoleGroup> roleGroups = await _roleGroupRepository.FindByIDs(userRegisterVO?.RoleGroupsIds);
                entityAdd.RoleGroups = new List<RoleGroup>();
                roleGroups.ForEach(rg => entityAdd.RoleGroups.Add(rg));

                response = await base.Validate(entityAdd);

                if (response.Success)
                {
                    User entityResponse = await _userRepository.Register(entityAdd);
                    response.Data = _mapper.Map<GetUserVO>(entityResponse);
                    response.Message = "User registred.";
                }
            }
            catch (Exception ex)
            {
                //TODO: GENARATE LOGS
                throw ex;
            }
            return response;
        }

        public async Task<bool> UserExists(string login)
        {
            bool response = await _userRepository.UserExists(login);

            return response;
        }

        public async Task<ServiceResponse<bool>> Logout(string login)
        {
            var response = new ServiceResponse<bool>();
            bool user = await _userRepository.UserExists(login);
            if (!user)
            {
                response.Success = false;
                response.Message = "User not found.";
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
                //new Claim(JwtRegisteredClaimNames.UniqueName, user.Login),
                new Claim(JwtRegisteredClaimNames.NameId, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Name, user.Name),
                //new Claim(JwtRegisteredClaimNames.Email, user.Email)
            };

            var accessToken = _tokenService.GenerateAccessToken(claims);
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(_configurationToken.DaysToExpiry);

            await _userRepository.RefreshUserInfo(user);

            DateTime createDate = DateTime.Now;
            DateTime expirationDate = createDate.AddMinutes(_configurationToken.Minutes);
            return new TokenVO(true,
                createDate.ToString(DATE_FORMAT),
                expirationDate.ToString(DATE_FORMAT),
                accessToken,
                refreshToken
                );
        }

        public async Task<TokenVO> validateCredentials(TokenVO token)
        {
            var accessToken = token.AccessToken;
            var refreshToken = token.RefreshToken;

            var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);

            var username = principal?.Identity?.Name;

            long idUser = 0;

            long.TryParse(username, out idUser);

            var user = await _userRepository.FindByID(idUser);

            if (user == null ||
                user.RefreshToken != refreshToken ||
                user.RefreshTokenExpiryTime <= DateTime.Now) return null;

            accessToken = _tokenService.GenerateAccessToken(principal.Claims);
            refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;

            await _userRepository.RefreshUserInfo(user);

            DateTime createDate = DateTime.Now;
            DateTime expirationDate = createDate.AddMinutes(_configurationToken.Minutes);
            return new TokenVO(
            true,
                createDate.ToString(DATE_FORMAT),
                expirationDate.ToString(DATE_FORMAT),
                accessToken,
                refreshToken
                );
        }

        public async Task<ServiceResponse<GetUserVO>> UpdateProfile(UpdateUserProfileVO updateUser)
        {
            ServiceResponse<GetUserVO> response = new ServiceResponse<GetUserVO>();

            try
            {
                User entityUpdate = await _userRepository.FindByID(updateUser.Id);

                if (entityUpdate == null || entityUpdate?.Id == 0)
                {
                    response.Success = false;
                    response.Message = "User not found.";
                    return response;
                }
                entityUpdate.Name = updateUser.Name;
                entityUpdate.Email = updateUser.Email;
                entityUpdate.Language = updateUser.Language;
                entityUpdate.TimeZone = updateUser.TimeZone;

                if (!string.IsNullOrEmpty(updateUser.Password))
                {
                    SecurityHelper.CreatePasswordHash(updateUser.Password, out byte[] passwordHash, out byte[] passwordSalt);
                    entityUpdate.PasswordHash = passwordHash;
                    entityUpdate.PasswordSalt = passwordSalt;
                }

                entityUpdate.ModifyDate = DateTime.Now;

                response = await base.Validate(entityUpdate);

                if (response.Success)
                {
                    User entityResponse = await _userRepository.Update(entityUpdate);
                    response.Success = true;
                    response.Data = _mapper.Map<GetUserVO>(entityResponse);

                    if (response.Success)
                        response.Message = "User Updated.";
                }
            }
            catch (Exception)
            {

                throw;
            }

            return response;
        }
    }
}
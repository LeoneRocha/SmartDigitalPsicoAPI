using AutoMapper;
using SmartDigitalPsico.Domain.DTO.User.Common;
using SmartDigitalPsico.Domain.DTO.User.GET;
using SmartDigitalPsico.Domain.DTO.User.UPDATE;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            #region USER
            CreateMap<User, GetUserDto>();
            CreateMap<User, GetUserAuthenticatedDto>();
            CreateMap<GetUserDto, User>();
            CreateMap<UpdateUserDto, User>();
            CreateMap<UserLoginDto, User>();
            CreateMap<UserRegisterDto, User>();
            #endregion USER

            #region UserTokenSession
            CreateMap<UserTokenSession, UserTokenSessionTableEntity>();
            CreateMap<UserTokenSessionTableEntity, UserTokenSession>();
            #endregion UserTokenSession
        }
    }
}

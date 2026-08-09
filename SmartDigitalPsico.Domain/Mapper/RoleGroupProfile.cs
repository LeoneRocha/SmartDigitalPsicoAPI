using AutoMapper;
using SmartDigitalPsico.Domain.DTO.RoleGroup.ADD;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.UPDATE;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class RoleGroupProfile : Profile
    {
        public RoleGroupProfile()
        {
            #region RoleGroup
            CreateMap<RoleGroup, GetRoleGroupDto>();
            CreateMap<GetRoleGroupDto, RoleGroup>();

            CreateMap<AddRoleGroupDto, RoleGroup>();
            CreateMap<UpdateRoleGroupDto, RoleGroup>();
            #endregion RoleGroup
        }
    }
}

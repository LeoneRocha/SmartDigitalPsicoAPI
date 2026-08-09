using AutoMapper;
using SmartDigitalPsico.Domain.DTO.Leaves.ADD;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.UPDATE;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class LeavesProfile : Profile
    {
        public LeavesProfile()
        {
            #region Leaves
            CreateMap<Leaves, GetLeavesDto>();
            CreateMap<GetLeavesDto, Leaves>();

            CreateMap<AddLeavesDto, Leaves>();
            CreateMap<UpdateLeavesDto, Leaves>();
            #endregion Leaves
        }
    }
}

using AutoMapper;
using SmartDigitalPsico.Domain.DTO.Specialty.ADD;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.UPDATE;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class SpecialtyProfile : Profile
    {
        public SpecialtyProfile()
        {
            #region Specialty
            CreateMap<Specialty, GetSpecialtyDto>();
            CreateMap<GetSpecialtyDto, Specialty>();

            CreateMap<AddSpecialtyDto, Specialty>();
            CreateMap<UpdateSpecialtyDto, Specialty>();
            #endregion Specialty
        }
    }
}

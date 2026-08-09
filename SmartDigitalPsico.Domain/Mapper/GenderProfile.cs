using AutoMapper;
using SmartDigitalPsico.Domain.DTO.Gender.ADD;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Gender.UPDATE;
using SmartDigitalPsico.Domain.DTO.Report.Entity;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class GenderProfile : Profile
    {
        public GenderProfile()
        {
            #region Gender
            CreateMap<Gender, GetGenderDto>();
            CreateMap<GetGenderDto, Gender>();

            CreateMap<AddGenderDto, Gender>();
            CreateMap<UpdateGenderDto, Gender>();

            // Gender Report
            CreateMap<Gender, GenderReportDto>();
            CreateMap<GenderReportDto, Gender>();
            #endregion Gender
        }
    }
}

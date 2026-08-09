using AutoMapper;
using SmartDigitalPsico.Domain.DTO.Application.ADD;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Application.UPDATE;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            #region ApplicationConfigSetting
            CreateMap<ApplicationConfigSetting, GetApplicationConfigSettingDto>();
            CreateMap<GetApplicationConfigSettingDto, ApplicationConfigSetting>();

            CreateMap<AddApplicationConfigSettingDto, ApplicationConfigSetting>();
            CreateMap<UpdateApplicationConfigSettingDto, ApplicationConfigSetting>();
            #endregion ApplicationConfigSetting

            #region ApplicationLanguage
            CreateMap<ApplicationLanguage, GetApplicationLanguageDto>();
            CreateMap<GetApplicationLanguageDto, ApplicationLanguage>();

            CreateMap<AddApplicationLanguageDto, ApplicationLanguage>();
            CreateMap<UpdateApplicationLanguageDto, ApplicationLanguage>();
            #endregion ApplicationLanguage
        }
    }
}

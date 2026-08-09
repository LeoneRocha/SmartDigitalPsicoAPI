using AutoMapper;
using SmartDigitalPsico.Domain.DTO.Office.ADD;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.Office.UPDATE;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class OfficeProfile : Profile
    {
        public OfficeProfile()
        {
            #region Office
            CreateMap<Office, GetOfficeDto>();
            CreateMap<GetOfficeDto, Office>();

            CreateMap<AddOfficeDto, Office>();
            CreateMap<UpdateOfficeDto, Office>();
            #endregion Office
        }
    }
}

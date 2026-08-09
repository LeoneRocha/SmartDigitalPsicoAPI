using AutoMapper;
using SmartDigitalPsico.Domain.DTO.Audit.ADD;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.DTO.Audit.UPDATE;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            #region Audit
            CreateMap<AuditDataSelectiveEntityLog, GetAuditDataSelectiveEntityLogDto>();
            CreateMap<GetAuditDataSelectiveEntityLogDto, AuditDataSelectiveEntityLog>();
            CreateMap<AddAuditDataSelectiveEntityLogDto, AuditDataSelectiveEntityLog>();
            CreateMap<UpdateAuditDataSelectiveEntityLogDto, AuditDataSelectiveEntityLog>();
            #endregion Audit
        }
    }
}

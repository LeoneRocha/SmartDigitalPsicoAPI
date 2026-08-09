using AutoMapper;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class EntityBaseProfile : Profile
    {
        public EntityBaseProfile()
        {
            #region SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase
            CreateMap<SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBaseWithNameEmail, SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseName>();
            CreateMap<SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseName, SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBaseWithNameEmail>();

            CreateMap<SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase, SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomain>();
            CreateMap<SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseDomain, SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase>();
            #endregion
        }
    }
}

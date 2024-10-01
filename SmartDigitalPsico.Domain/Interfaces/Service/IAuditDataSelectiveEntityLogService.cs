using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IAuditDataSelectiveEntityLogService : IEntityBaseService<AuditDataSelectiveEntityLog
        , AddAuditDataSelectiveEntityLogDto, UpdateAuditDataSelectiveEntityLogDto, GetAuditDataSelectiveEntityLogDto>
    {

        Task Save(object entryOld, object entryNew, string operation, string[] propertiesToIgnore);
    }
}
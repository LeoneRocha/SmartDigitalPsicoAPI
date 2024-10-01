using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs
{
    public class UpdateAuditDataSelectiveEntityLogDto : AuditDataSelectiveEntityLogBaseDto, IEntityDto
    {
        public long Id { get; set; }
    }
}
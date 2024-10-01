using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.DTO.User;

namespace SmartDigitalPsico.Domain.DTO.Domains.GetDTOs
{
    public class GetAuditDataSelectiveEntityLogDto : EntityDtoBaseDomain, ISupportsHyperMedia
    {
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
         
        public string RowKey { get; set; } = string.Empty;
        public string PartitionKey { get; set; } = string.Empty;

        public string TableName { get; set; } = string.Empty;
        public string Operation { get; set; } = string.Empty;
        public string KeyValue { get; set; } = string.Empty;
        public string OldValues { get; set; } = string.Empty;
        public string NewValues { get; set; } = string.Empty;
        public DateTime AuditDate { get; set; } = DateTime.UtcNow;
        public string? UserAuditedLogin { get; set; } = null;

        public GetUserDto? UserAudited { get; set; }
        public long? UserAuditedId { get; set; }


    }
}
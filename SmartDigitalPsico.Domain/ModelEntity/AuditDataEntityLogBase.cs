﻿using SmartDigitalPsico.Domain.Contracts;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public abstract class AuditDataEntityLogBase : EntityBase 
    {
        protected AuditDataEntityLogBase()
        {
            ModifyDate = DateTime.UtcNow;
            CreatedDate = DateTime.UtcNow;
            LastAccessDate = DateTime.UtcNow;
            Enable = true;
        }
        public string TableName { get; set; } = string.Empty;
        public string Operation { get; set; } = string.Empty;
        public string KeyValue { get; set; } = string.Empty;
        public string OldValues { get; set; } = string.Empty;
        public string NewValues { get; set; } = string.Empty;
        public DateTime AuditDate { get; set; } = DateTime.UtcNow;
        public string? UserAuditedLogin { get; set; } = null;

        public User? UserAudited { get; set; }
        public long? UserAuditedId { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Audit
{
    public class AuditService : IAuditService
    {
        public AuditService()
        {
        }
        public List<AuditDataEntityLog> OnBeforeSaveChanges(DbContext context)
        {
            var auditEntries = new List<AuditDataEntityLog>();

            foreach (var entry in context.ChangeTracker.Entries())
            {
                if (entry == null || (entry.State != EntityState.Modified && entry.State != EntityState.Deleted))
                {
                    continue;
                }
                var auditEntry = CreateAuditEntry(entry);
                auditEntries.Add(auditEntry);
            }
            return auditEntries;
        }

        private AuditDataEntityLog CreateAuditEntry(EntityEntry entry)
        {
            var auditEntry = new AuditDataEntityLog
            {
                TableName = entry.Entity.GetType().Name,
                Operation = entry.State.ToString(),
                KeyValues = GetKeyValues(entry),
                OldValues = entry.State == EntityState.Modified ? SerializeOriginalValues(entry) : string.Empty,
                NewValues = entry.State == EntityState.Modified ? SerializeCurrentValues(entry) : string.Empty,
                UserAuditedId = GetCurrentUserId(entry).Item1,
                UserAuditedLogin = GetCurrentUserId(entry).Item2,
            };
            return auditEntry;
        }

        private static string GetKeyValues(EntityEntry entry)
        {
            var PrimaryKeyValues = entry.Properties.Where(p => p.Metadata.IsPrimaryKey()).ToList();

            return PrimaryKeyValues.First().CurrentValue?.ToString() ?? string.Empty;
        }
        private static string SerializeOriginalValues(EntityEntry entry)
        {
            var OriginalValues = entry.OriginalValues.Properties.ToDictionary(p => p.Name, p => entry.OriginalValues[p]).ToList();

            return JsonConvert.SerializeObject(OriginalValues, getJsonSettigns());
        }

        private static string SerializeCurrentValues(EntityEntry entry)
        {
            var OriginalValues = entry.CurrentValues.Properties.ToDictionary(p => p.Name, p => entry.CurrentValues[p]).ToList();
            return JsonConvert.SerializeObject(OriginalValues, getJsonSettigns());
        }
        private static JsonSerializerSettings getJsonSettigns()
        {
            return new JsonSerializerSettings
            {
                Error = (sender, args) =>
                {
                    args.ErrorContext.Handled = true;
                },
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore
            };
        }

        private static (long?, string userUserAudited) GetCurrentUserId(EntityEntry entry)
        {
            var createdUserId = entry.Property("CreatedUserId")?.CurrentValue as long?;
            if (createdUserId.HasValue)
            {
                return (createdUserId, string.Empty);
            }
            var modifyUserId = entry.Property("ModifyUserId")?.CurrentValue as long?;
            if (modifyUserId.HasValue)
            {
                return (modifyUserId, string.Empty);
            }
            var userId = entry.Property("UserId")?.CurrentValue as long?;
            if (userId.HasValue)
            {
                return (userId, string.Empty);
            }

            return (null, "admin");
        }
    }
}

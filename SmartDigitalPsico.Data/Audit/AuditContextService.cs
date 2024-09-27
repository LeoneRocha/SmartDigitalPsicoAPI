using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Audit
{
    public class AuditContextService : IAuditContextService
    {
        public AuditContextService()
        {
        }
        public List<AuditDataEntityLog> OnBeforeSaveChanges(DbContext context)
        {
            var auditEntries = new List<AuditDataEntityLog>();
            var entriesChanged = context.ChangeTracker.Entries().Where(entry => entry != null
            && (entry.State == EntityState.Modified || entry.State == EntityState.Deleted)).ToArray();

            foreach (var entry in entriesChanged)
            {
                var auditEntry = CreateAuditEntry(entry);
                auditEntries.Add(auditEntry);
            }
            return auditEntries;
        }

        private static AuditDataEntityLog CreateAuditEntry(EntityEntry entry)
        {
            var auditEntry = new AuditDataEntityLog
            {
                TableName = entry.Entity.GetType().Name,
                Operation = entry.State.ToString(),
                KeyValue = GetKeyValues(entry),
                OldValues = SerializeOriginalValues(entry),
                NewValues = SerializeCurrentValues(entry),
                UserAuditedId = GetCurrentUserId(entry).Item1,
                UserAuditedLogin = GetCurrentUserId(entry).Item2,
            };
            return auditEntry;
        }
        private static string GetKeyValues(EntityEntry entry)
        {
            var PrimaryKeyValues = entry.Properties.Where(p => p.Metadata.IsPrimaryKey()).ToArray();

            return PrimaryKeyValues[0].CurrentValue?.ToString() ?? string.Empty;
        }
        private static string SerializeOriginalValues(EntityEntry entry)
        {
            var originalValues = entry.OriginalValues.Properties
                .ToDictionary(p => p.Name, p => entry.OriginalValues[p]);

            return AuditLogHelper.SerializeObject(originalValues);
        }
        private static string SerializeCurrentValues(EntityEntry entry)
        {
            var currentValues = entry.CurrentValues.Properties
                .ToDictionary(p => p.Name, p => entry.CurrentValues[p]);

            return AuditLogHelper.SerializeObject(currentValues);
        }
        private static (long?, string) GetCurrentUserId(EntityEntry entry)
        {
            var userIdProperties = new List<string>() { "CreatedUserId", "ModifyUserId", "UserId" };

            // Verifica se pelo menos uma das propriedades existe no EntityEntry
            if (!userIdProperties.Exists(property => entry.Metadata.FindProperty(property) != null))
            {
                return (null, "admin");
            }

            foreach (var property in userIdProperties)
            {
                var userId = GetUserId(entry, property);
                if (userId.HasValue)
                {
                    return (userId, string.Empty);
                }
            }
            return (null, "admin");
        }
        private static long? GetUserId(EntityEntry entry, string propertyName)
        {
            var property = entry.Metadata.FindProperty(propertyName);
            return property != null ? entry.Property(propertyName)?.CurrentValue as long? : null;
        }
    }
}
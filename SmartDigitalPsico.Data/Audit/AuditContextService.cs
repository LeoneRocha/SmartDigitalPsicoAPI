using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
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
                KeyValue = GetKeyValues(entry),
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
            var userIdProperties = new[] { "CreatedUserId", "ModifyUserId", "UserId" };

            // Verifica se pelo menos uma das propriedades existe no EntityEntry
            if (!userIdProperties.Any(property => entry.Metadata.FindProperty(property) != null))
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
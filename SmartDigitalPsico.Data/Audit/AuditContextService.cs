using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Caching.Memory;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Audit
{
    public class AuditContextService : IAuditContextService
    {
        private readonly IMemoryCacheRepository _memoryCacheRepository;
        public AuditContextService(IMemoryCacheRepository memoryCacheRepository)
        {
            _memoryCacheRepository = memoryCacheRepository;
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
        public List<AuditDataEntityLog> GetExistingEntries(DbContext context, List<AuditDataEntityLog> auditEntriesInput)
        {
            var dtUtcNow = DataHelper.GetDateTimeNow();
            var twoMinutesAgo = dtUtcNow.AddMinutes(-2);
            var minDateAauditEntrie = auditEntriesInput.Min(x => x.AuditDate).AddMinutes(-2);
            List<string> tableNames = auditEntriesInput.Select(x => x.TableName).Distinct().ToList();
            List<string> operations = auditEntriesInput.Select(x => x.Operation).Distinct().ToList();
            List<string> keyValues = auditEntriesInput.Select(x => x.KeyValue).Distinct().ToList();

            var existingEntries = context.Set<AuditDataEntityLog>().AsNoTracking()
                .Where(adel => (adel.AuditDate >= twoMinutesAgo && adel.AuditDate <= dtUtcNow)
                && (adel.AuditDate >= minDateAauditEntrie)
                && (tableNames.Any(tn => tn == adel.TableName) && operations.Any(op => op == adel.Operation) && keyValues.Any(op => op == adel.KeyValue)))
                .ToList();
            return existingEntries;
        }
        public List<AuditDataEntityLog> GetNewEntries(DbContext context, List<AuditDataEntityLog> auditEntriesInput)
        {
            var existingEntries = handleMemoryIfNotExists(auditEntriesInput);
            if (existingEntries == null || existingEntries.Count == 0)
                return auditEntriesInput;

            var resultList = auditEntriesInput
                .Where(e => !existingEntries.Exists(a => e.AuditDate.Date == a.AuditDate.Date
                && e.AuditDate.Hour == a.AuditDate.Hour
                && e.AuditDate.Minute == a.AuditDate.Minute
                && a.TableName.Equals(e.TableName)
                && a.Operation.Equals(e.Operation)
                && a.KeyValue.Equals(e.KeyValue)
                && a.OldValues.Equals(e.OldValues)
                && a.NewValues.Equals(e.NewValues)
                )).ToList();

            return resultList;
        }

        private List<AuditDataEntityLog> handleMemoryIfNotExists(List<AuditDataEntityLog> auditEntriesInput)
        {

            var dtUtcNow = DataHelper.GetDateTimeNow();
            var twoMinutesAgo = dtUtcNow.AddMinutes(-2);
            var minDateAauditEntrie = auditEntriesInput.Min(x => x.AuditDate).AddMinutes(-2);
            List<string> tableNames = auditEntriesInput.Select(x => x.TableName).Distinct().ToList();
            List<string> operations = auditEntriesInput.Select(x => x.Operation).Distinct().ToList();
            List<string> keyValues = auditEntriesInput.Select(x => x.KeyValue).Distinct().ToList(); 
            var cacheKey = $"AuditEntries";

            List<AuditDataEntityLog> cachedEntriesOut;
            if (_memoryCacheRepository.TryGet(cacheKey, out cachedEntriesOut!))
            {
                var recentEntries = cachedEntriesOut
                    .Where(adel => (adel.AuditDate >= twoMinutesAgo && adel.AuditDate <= dtUtcNow)
                    && (adel.AuditDate >= minDateAauditEntrie)
                    && (tableNames.Exists(tn => tn == adel.TableName) && operations.Exists(op => op == adel.Operation) && keyValues.Exists(op => op == adel.KeyValue)))
                    .ToList();

                if (recentEntries.Count > 0)
                {
                    // Retorna os registros correspondentes
                    return recentEntries;
                }
            }
            var _cacheOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DataHelper.GetDateTimeNow().AddHours(0).AddMinutes(3),
                Priority = CacheItemPriority.High,
                SlidingExpiration = TimeSpan.FromMinutes(3)
            };

            // Se não existirem registros correspondentes, salva os novos registros
            _memoryCacheRepository.Set(cacheKey, auditEntriesInput, _cacheOptions);
            return cachedEntriesOut;


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
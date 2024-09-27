using Newtonsoft.Json;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Helpers
{
    public static class AuditLogHelper
    {
        public static JsonSerializerSettings GetJsonSettings()
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
        public static string SerializeObject(object dataAuditLog)
        {
            if (dataAuditLog != null)
                return JsonConvert.SerializeObject(dataAuditLog, GetJsonSettings());

            return string.Empty;
        }
        public static string SerializeObject(object dataAuditLog, string[] propertiesToIgnore)
        {
            var jsonSettings = GetJsonSettings();
            jsonSettings.ContractResolver = new IgnorableSerializerContractResolver(propertiesToIgnore);
            if (dataAuditLog != null)
                return JsonConvert.SerializeObject(dataAuditLog, jsonSettings);

            return string.Empty;
        }
        public static AuditDataEntityLog CreateAuditEntry(object entryOld, object entryNew, string operation)
        {
            var auditEntry = new AuditDataEntityLog
            {
                TableName = entryNew.GetType().Name,
                Operation = operation,
                KeyValue = GetKeyValues(entryNew),
                OldValues = SerializeObject(entryOld),
                NewValues = SerializeObject(entryNew),
                UserAuditedId = GetCurrentUserId(entryNew!).Item1,
                UserAuditedLogin = GetCurrentUserId(entryNew!).Item2,
            };
            return auditEntry;
        }
        public static AuditDataEntityLog CreateAuditEntry(object entryOld, object entryNew, string operation, string[] propertiesToIgnore)
        {
            var auditEntry = new AuditDataEntityLog
            {
                TableName = entryNew.GetType().Name,
                Operation = operation,
                KeyValue = GetKeyValues(entryNew),
                OldValues = SerializeObject(entryOld, propertiesToIgnore),
                NewValues = SerializeObject(entryNew, propertiesToIgnore),
                UserAuditedId = GetCurrentUserId(entryNew!).Item1,
                UserAuditedLogin = GetCurrentUserId(entryNew!).Item2,
            };
            return auditEntry;
        }
        private static string GetKeyValues(object obj)
        {
            var result = string.Empty;
            var idProperty = obj.GetType().GetProperty("Id");
            if (idProperty != null)
            {
                result = idProperty.GetValue(obj)?.ToString();
            }
            return result ?? string.Empty;
        }

        private static (long?, string) GetCurrentUserId(object obj)
        {
            var userIdProperties = new[] { "CreatedUserId", "ModifyUserId", "UserId" };

            foreach (var property in userIdProperties)
            {
                var propInfo = obj.GetType().GetProperty(property);
                if (propInfo != null)
                {
                    var userId = propInfo.GetValue(obj) as long?;
                    if (userId.HasValue)
                    {
                        return (userId, string.Empty);
                    }
                }
            }
            return (null, "admin");
        }
    }
}
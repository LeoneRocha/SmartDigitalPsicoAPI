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
            var jsonResult = JsonConvert.SerializeObject(dataAuditLog, GetJsonSettings());

            return jsonResult;
        }
        public static string SerializeObject(object dataAuditLog, string[] propertiesToIgnore)
        {
            var jsonSettings = GetJsonSettings();
            jsonSettings.ContractResolver = new IgnorableSerializerContractResolver(propertiesToIgnore);
            var jsonResult = JsonConvert.SerializeObject(dataAuditLog, jsonSettings);

            return jsonResult;
        }
        public static AuditDataEntityLog CreateAuditEntry(object entryOld, object entryNew, string operation)
        {
            var auditEntry = new AuditDataEntityLog
            {
                TableName = entryNew.GetType().Name,
                Operation = operation,
                KeyValue = GetKeyValues(entryNew),
                OldValues = entryOld != null ? SerializeObject(entryOld) : string.Empty,
                NewValues = entryNew != null ? SerializeObject(entryNew) : string.Empty,
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
                OldValues = entryOld != null ? SerializeObject(entryOld, propertiesToIgnore) : string.Empty,
                NewValues = entryNew != null ? SerializeObject(entryNew, propertiesToIgnore) : string.Empty,
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
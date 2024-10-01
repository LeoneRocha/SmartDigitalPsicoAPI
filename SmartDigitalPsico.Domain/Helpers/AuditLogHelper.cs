using Newtonsoft.Json;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;

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
        public static AddAuditDataSelectiveEntityLogDto CreateAuditEntry(object entryOld, object entryNew, string operation, string[] propertiesToIgnore)
        {
            var auditEntry = new AddAuditDataSelectiveEntityLogDto
            {
                TableName = entryNew.GetType().Name,
                Operation = operation,
                KeyValue = GetKeyValues(entryNew),
                OldValues = SerializeObject(entryOld, propertiesToIgnore),
                NewValues = SerializeObject(entryNew, propertiesToIgnore),
                UserAuditedId = GetCurrentUserId(entryNew!).Item1,
                UserAuditedLogin = GetCurrentUserName(entryOld!),
            };
            return auditEntry;
        }

        private static string GetCurrentUserName(object obj)
        {
            var userIdProperties = new[] { "ModifyUser.Name" };

            foreach (var property in userIdProperties)
            { 
                var propertyPath = property;
                var propertyNames = propertyPath.Split('.');
                object currentObject = obj;


                foreach (var propertyName in propertyNames)
                {
                    if (currentObject == null)
                    {
                        return "admin";
                    }

                    var propInfo = currentObject.GetType().GetProperty(propertyName);
                    if (propInfo == null)
                    {
                        return "admin";
                    }

                    currentObject = propInfo.GetValue(currentObject)!;
                }
                var userName = currentObject as string;

                if (!string.IsNullOrEmpty(userName))
                {
                    return userName;
                }
            }
            return "admin";
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

        public static T DeepClone<T>(T obj, string[] propertiesToIgnore)
        {
            var jsonSettings = GetJsonSettings();
            jsonSettings.ContractResolver = new IgnorableSerializerContractResolver(propertiesToIgnore);

            var json = JsonConvert.SerializeObject(obj, jsonSettings);
            return JsonConvert.DeserializeObject<T>(json)!;
        }
    }
}
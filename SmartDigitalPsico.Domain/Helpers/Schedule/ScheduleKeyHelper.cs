namespace SmartDigitalPsico.Domain.Helpers.Schedule
{
    /// <summary>
    /// Generic schedule key utilities for Core engines — no product/tenant defaults.
    /// Adapters supply TenantKey / OwnerKey / SubjectKey explicitly.
    /// </summary>
    public static class ScheduleKeyHelper
    {
        /// <summary>
        /// Validates and trims TenantKey. Does not apply any default — caller must provide it.
        /// </summary>
        public static string RequireTenant(string? tenantKey)
        {
            if (string.IsNullOrWhiteSpace(tenantKey))
                throw new ArgumentException("TenantKey is required.", nameof(tenantKey));
            return tenantKey.Trim();
        }

        public static string Build(string prefix, long id)
        {
            if (string.IsNullOrWhiteSpace(prefix))
                throw new ArgumentException("Prefix is required.", nameof(prefix));
            return $"{prefix}{id}";
        }

        public static bool TryParse(string? key, string prefix, out long id)
        {
            id = 0;
            if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(prefix))
                return false;
            if (!key.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                return false;
            return long.TryParse(key.AsSpan(prefix.Length), out id);
        }

        public static bool TryParse(string? key, IEnumerable<string> prefixes, out long id)
        {
            id = 0;
            if (string.IsNullOrWhiteSpace(key) || prefixes == null)
                return false;

            foreach (var prefix in prefixes)
            {
                if (TryParse(key, prefix, out id))
                    return true;
            }
            return false;
        }
    }
}

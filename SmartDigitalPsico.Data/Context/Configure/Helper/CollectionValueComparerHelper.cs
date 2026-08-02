using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;

namespace SmartDigitalPsico.Data.Context.Configure.Helper
{
    /// <summary>
    /// ValueComparer para propriedades com HasConversion (coleções/arrays).
    /// Sem comparer, o EF emite warning de validação e pode falhar no change tracking.
    /// </summary>
    public static class CollectionValueComparerHelper
    {
        public static ValueComparer<T[]> ForArray<T>()
        {
            return new ValueComparer<T[]>(
                (a, b) => ReferenceEquals(a, b) || (a != null && b != null && a.SequenceEqual(b)),
                a => a == null ? 0 : a.Aggregate(0, (h, v) => HashCode.Combine(h, EqualityComparer<T>.Default.GetHashCode(v!))),
                a => a == null ? Array.Empty<T>() : a.ToArray());
        }

        public static ValueComparer<T[]> ForJsonArray<T>()
        {
            return new ValueComparer<T[]>(
                (a, b) => JsonConvert.SerializeObject(a) == JsonConvert.SerializeObject(b),
                a => a == null ? 0 : JsonConvert.SerializeObject(a).GetHashCode(StringComparison.Ordinal),
                a => a == null
                    ? Array.Empty<T>()
                    : JsonConvert.DeserializeObject<T[]>(JsonConvert.SerializeObject(a))!);
        }
    }
}

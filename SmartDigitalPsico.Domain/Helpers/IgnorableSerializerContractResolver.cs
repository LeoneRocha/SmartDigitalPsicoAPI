using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace SmartDigitalPsico.Domain.Helpers
{
    public class IgnorableSerializerContractResolver : DefaultContractResolver
    {
        private readonly HashSet<string> _propertiesToIgnore;

        public IgnorableSerializerContractResolver(IEnumerable<string> propertiesToIgnore)
        {
            _propertiesToIgnore = new HashSet<string>(propertiesToIgnore);
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            if (property.PropertyName != null && _propertiesToIgnore.Contains(property.PropertyName!))
            {
                property.ShouldSerialize = _ => false;
            }
            return property;
        }
    }
}
